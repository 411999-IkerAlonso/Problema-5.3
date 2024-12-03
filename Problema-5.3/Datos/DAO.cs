using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Problema_5._3.Datos
{
    public  class DAO
    {
        private string cadenaConexion = "Data Source=COSITAS;Initial Catalog=Problema_5_3;Persist Security Info=True;User ID=sa; password =Fermin11;Encrypt=False";
        private SqlConnection conexion;
        private SqlCommand comando;
        
        public DAO()
        {
            conexion = new SqlConnection(cadenaConexion);
        }

        public void Conectar()
        {
            conexion.Open();
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }

        public void Desconectar()
        {
            conexion.Close();
        }

        public DataTable Cargar(string tabla)
        {
            DataTable dt = new DataTable();
            Conectar();
            comando.CommandText = "SELECT * FROM " + tabla;
            dt.Load(comando.ExecuteReader());
            Desconectar();
            return dt;
        }

        public DataTable ConsultarBD(string consultaSQL)
        {
            DataTable dt = new DataTable();
            Conectar();
            comando.CommandText = consultaSQL;
            dt.Load(comando.ExecuteReader());
            Desconectar();
            return dt;
        }
        public int Actualizar(string consultaSQl, List<Parametro> parametros)
        {
            Conectar();
            comando.CommandText= consultaSQl;
            foreach(Parametro p in parametros)
            {
                comando.Parameters.AddWithValue(p.Nombre, p.Valor);
            }
            int filasAfectadas = comando.ExecuteNonQuery();
            Desconectar();
            return filasAfectadas;
        }
    }
}
