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
            // código quando o botao logar for clicado

            if (txtLogin.Text == "12345678901" && txtSenha.Text == "123456")
            {
                lblMensagem.Text = "Usuário autenticado!";
            }
            else
            {
                lblMensagem.Text = "Usuário inválido!";
            }
        }
    }
}