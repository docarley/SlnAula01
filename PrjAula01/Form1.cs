namespace PrjAula01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            // c�digo quando o botao logar for clicado

            if (txtLogin.Text == "12345678901" && txtSenha.Text == "123456")
            {
                lblMensagem.Text = "Usu�rio autenticado!";
            }
            else
            {
                lblMensagem.Text = "Usu�rio inv�lido!";
            }
        }
    }
}