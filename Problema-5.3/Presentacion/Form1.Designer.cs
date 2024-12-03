namespace Problema_5._3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCodigo = new TextBox();
            txtDetalle = new TextBox();
            txtPrecio = new TextBox();
            lstProductos = new ListBox();
            dtpfecha = new DateTimePicker();
            rbtNotebook = new RadioButton();
            rbtNetbook = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cboMarca = new ComboBox();
            btnNuevo = new Button();
            btnCancelar = new Button();
            btnGrabar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(335, 80);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(264, 27);
            txtCodigo.TabIndex = 0;
            // 
            // txtDetalle
            // 
            txtDetalle.Location = new Point(335, 129);
            txtDetalle.Name = "txtDetalle";
            txtDetalle.Size = new Size(264, 27);
            txtDetalle.TabIndex = 1;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(335, 286);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(264, 27);
            txtPrecio.TabIndex = 2;
            // 
            // lstProductos
            // 
            lstProductos.FormattingEnabled = true;
            lstProductos.Location = new Point(773, 80);
            lstProductos.Name = "lstProductos";
            lstProductos.Size = new Size(461, 284);
            lstProductos.TabIndex = 3;
            // 
            // dtpfecha
            // 
            dtpfecha.Location = new Point(335, 319);
            dtpfecha.Name = "dtpfecha";
            dtpfecha.Size = new Size(272, 27);
            dtpfecha.TabIndex = 4;
            // 
            // rbtNotebook
            // 
            rbtNotebook.AutoSize = true;
            rbtNotebook.FlatAppearance.CheckedBackColor = Color.White;
            rbtNotebook.Location = new Point(335, 215);
            rbtNotebook.Name = "rbtNotebook";
            rbtNotebook.Size = new Size(97, 24);
            rbtNotebook.TabIndex = 5;
            rbtNotebook.TabStop = true;
            rbtNotebook.Text = "Notebook";
            rbtNotebook.UseVisualStyleBackColor = true;
            // 
            // rbtNetbook
            // 
            rbtNetbook.AutoSize = true;
            rbtNetbook.Location = new Point(335, 245);
            rbtNetbook.Name = "rbtNetbook";
            rbtNetbook.Size = new Size(88, 24);
            rbtNetbook.TabIndex = 6;
            rbtNetbook.TabStop = true;
            rbtNetbook.Text = "Netbook";
            rbtNetbook.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(250, 87);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 7;
            label1.Text = "Codigo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(250, 136);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 8;
            label2.Text = "Detalle";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(250, 179);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 9;
            label3.Text = "Marca";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(250, 228);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 10;
            label4.Text = "Tipo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(250, 289);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 11;
            label5.Text = "Precio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(250, 326);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 12;
            label6.Text = "Fecha";
            // 
            // cboMarca
            // 
            cboMarca.FormattingEnabled = true;
            cboMarca.Location = new Point(335, 181);
            cboMarca.Name = "cboMarca";
            cboMarca.Size = new Size(264, 28);
            cboMarca.TabIndex = 13;
            // 
            // btnNuevo
            // 
            btnNuevo.ImageAlign = ContentAlignment.TopRight;
            btnNuevo.Location = new Point(14, 584);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(129, 104);
            btnNuevo.TabIndex = 14;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(205, 584);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(129, 104);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(397, 584);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(129, 104);
            btnGrabar.TabIndex = 16;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(1105, 584);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(129, 104);
            btnSalir.TabIndex = 17;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(1281, 721);
            Controls.Add(btnSalir);
            Controls.Add(btnGrabar);
            Controls.Add(btnCancelar);
            Controls.Add(btnNuevo);
            Controls.Add(cboMarca);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rbtNetbook);
            Controls.Add(rbtNotebook);
            Controls.Add(dtpfecha);
            Controls.Add(lstProductos);
            Controls.Add(txtPrecio);
            Controls.Add(txtDetalle);
            Controls.Add(txtCodigo);
            Name = "Form1";
            Text = "Productos";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCodigo;
        private TextBox txtDetalle;
        private TextBox txtPrecio;
        private ListBox lstProductos;
        private DateTimePicker dtpfecha;
        private RadioButton rbtNotebook;
        private RadioButton rbtNetbook;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cboMarca;
        private Button btnNuevo;
        private Button btnCancelar;
        private Button btnGrabar;
        private Button btnSalir;
    }
}
