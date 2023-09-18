using FrequenciaMedica.Telas;

namespace FrequenciaMedica
{
    public partial class Form_Login : Form
    {
        
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            //Parametros par = new Parametros();
            Parametros.Tipo = cbx_Tipo.Text;
            Parametros.Tipo = txt_Usuario.Text;
            FormMain main = new FormMain();
            main.ShowDialog();
        }

        private void Form_Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }

        private void txt_Usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_Login_Load(object sender, EventArgs e)
        {

        }
    }
}