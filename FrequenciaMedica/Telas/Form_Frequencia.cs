using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrequenciaMedica.Telas
{
    public partial class Form_Frequencia : Form
    {

        DataTable dt = new DataTable();

        string baseLocal = "Server=USUARIO-PC\\SQLEXPRESS;Database=FREQUENCIA_MEDICA;User Id=sa;Password=S@";
        public Form_Frequencia()
        {
            InitializeComponent();
            dgv_Master.AutoGenerateColumns = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Frequencia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }

        private DataTable Form_Frequencia_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(baseLocal);
            connection.Open();
            string sqlCommand = $@"SELECT NUMCRA, NUMCAD, DATA, HORA, NOME, SINCRONIZADO AS SINC, DIRACC FROM TBL_FREQUENCIA_MEDICA;";
            var listaFuncionarios = new SqlDataAdapter(sqlCommand, connection);
            listaFuncionarios.Fill(dt);
            dgv_Master.DataSource = dt;
            return dt;
        }

        private void SALVAR_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(baseLocal);
            connection.Open();
            string sqlCommand = "";
            //var listaRegistros = new SqlCommand(sqlCommand, connection);
            //SqlDataReader lRegistros = listaRegistros.ExecuteReader();
            foreach (DataGridViewRow item in dgv_Master.Rows)
            {
                if (item.Cells["GRID_Ok"].Value != null && item.Cells["GRID_Ok"].Equals("1"))
                {
                    sqlCommand = $@"INSERT INTO TBL_FREQUENCIA_MEDICA ([NUMCRA],[NUMCAD],[DATA],[HORA],[NOME],[EMPRESA],[CODRELOGIO],[OS],[SINCRONIZADO],[USUA_CRIACAO],[USUA_LANCAMENTO],[OBS],DIRACC)
                                         VALUES(,'{item.Cells["NumCra"].Value.ToString()}','{item.Cells["NumCad"].Value.ToString()}','{item.Cells["Data"].Value.ToString()}','{item.Cells["Hora"].Value.ToString()}','{item.Cells["Nome"].Value.ToString()}','{item.Cells["DiraCc"].Value.ToString()}',{item.Cells["Sinc"].Value.ToString()}')";
                    var listaRegistros = new SqlCommand(sqlCommand, connection);
                    listaRegistros.ExecuteNonQuery();
                }
                else
                {
                    //algo deu errado
                }
            }
        }
    }
}
