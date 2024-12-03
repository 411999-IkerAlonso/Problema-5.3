using Problema_5._3.Datos;
using Problema_5._3.Dominio;
using System.Data;

namespace Problema_5._3
{
    public partial class Form1 : Form
    {
        private DAO dao;
        Producto producto = new Producto();
        List<Parametro> parametros = new List<Parametro>();
        int Modo = 0;
        public Form1()
        {
            InitializeComponent();
            dao = new DAO();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarCboMarca();
            IniciarForm();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Close();
            }
        }

        public void CargarCboMarca()
        {
            DataTable dt = dao.Cargar("Marcas");
            cboMarca.DataSource = dt;
            cboMarca.ValueMember = dt.Columns[0].ColumnName;
            cboMarca.DisplayMember = dt.Columns[1].ColumnName;
        }

        public void CargarLista()
        {
            DataTable dt = dao.Cargar("Productos");
            lstProductos.DataSource = dt;
            lstProductos.ValueMember = dt.Columns[0].ColumnName;
            lstProductos.DisplayMember = dt.Columns[1].ColumnName;
        }
        public void IniciarForm()
        {
            txtCodigo.Enabled = false;
            txtCodigo.Clear();
            txtDetalle.Enabled = false;
            txtDetalle.Clear();
            txtPrecio.Enabled = false;
            txtPrecio.Clear();
            cboMarca.Enabled = false;
            cboMarca.SelectedIndex = -1;
            lstProductos.Enabled = true;
            CargarLista();
            rbtNotebook.Enabled = false;
            rbtNotebook.Checked = true;
            rbtNetbook.Enabled = false;
            dtpfecha.Enabled = false;
            btnGrabar.Enabled = false;
            btnCancelar.Enabled = false;
            cboMarca.SelectedIndex = -1;
            dtpfecha.Value = DateTime.Now;
        }

        public void HabilitarForm()
        {
            txtCodigo.Enabled = true;
            txtDetalle.Enabled = true;
            txtPrecio.Enabled = true;
            cboMarca.Enabled = true;
            lstProductos.Enabled = true;
            rbtNotebook.Enabled = true;
            rbtNotebook.Checked = true;
            rbtNetbook.Enabled = true;
            dtpfecha.Enabled = true;
            btnGrabar.Enabled = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            HabilitarForm();
            Modo = 1;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (Modo == 1)
                {
                    producto.Codigo = Convert.ToInt32(txtCodigo.Text);
                    producto.Detalle = txtDetalle.Text;
                    producto.Marca = Convert.ToInt32(cboMarca.SelectedValue);
                    if (rbtNetbook.Checked)
                    {
                        producto.tipo = "netbook";
                    }
                    else if (rbtNotebook.Checked)
                    {
                        producto.tipo = "Notebook";
                    }
                    producto.Precio = Convert.ToDouble(txtPrecio.Text);
                    producto.Fecha = dtpfecha.Value;
                    NuevoProducto();
                    IniciarForm();
                }
            }
        }

        public void NuevoProducto()
        {
            string consultaSQL = "INSERT INTO productos(codigo, detalle, Marca, tipo, precio, fecha)" +
                "VALUES (@codigo, @detalle, @Marca, @tipo, @precio, @fecha)";
            parametros.Add(new Parametro("@codigo", producto.Codigo));
            parametros.Add(new Parametro("@detalle", producto.Detalle));
            parametros.Add(new Parametro("@Marca", producto.Marca));
            parametros.Add(new Parametro("@tipo", producto.tipo));
            parametros.Add(new Parametro("@precio", producto.Precio));
            parametros.Add(new Parametro("@fecha", producto.Fecha));
            int filasAfectadas = dao.Actualizar(consultaSQL, parametros);
            if (filasAfectadas == 0)
            {
                MessageBox.Show("Algo ha salido mal, el Producto no se insertó");
            }
            else
            {
                MessageBox.Show("Producto Creado con exito");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            IniciarForm();
        }

        public bool Validar()
        {
            if(string.IsNullOrEmpty(txtCodigo.Text) || !int.TryParse(txtCodigo.Text, out _))
            {
                MessageBox.Show("Debe ingresar un codigo valido (Entero)");
                txtCodigo.Focus();
                return false;
            }
            if(string.IsNullOrEmpty(txtDetalle.Text))
            {
                MessageBox.Show("Debe ingresar un detalle");
                txtDetalle.Focus();
                return false;
            }
            if(cboMarca.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una Marca");
                txtDetalle.Focus();
                return false;
            }
            if(string.IsNullOrEmpty(txtPrecio.Text) || !int.TryParse(txtPrecio.Text, out _))
            {
                MessageBox.Show("Debe ingresar un precio valido");
                txtPrecio.Focus();
                return false;
            }
            if(dtpfecha.Value > DateTime.Now)
            {
                MessageBox.Show("Debe seleccionar una fecha menor o igual al dia de hoy");
                dtpfecha.Focus();
                return false;
            }
            return true;
        }
    }
}
