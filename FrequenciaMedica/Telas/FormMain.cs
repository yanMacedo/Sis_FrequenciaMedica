using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrequenciaMedica.Telas
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btn_RegistreSe_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form_RegistroDePonto registro = new Form_RegistroDePonto();
            registro.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form_Frequencia frequencia = new Form_Frequencia();
            frequencia.ShowDialog();
        }
    }
}
