using MySql.Data.MySqlClient;

namespace tela_de_login
{
    public partial class FormLogin : Form
    {
        private MySqlConnection connection;
        public FormLogin()
        {
            InitializeComponent();
            connection = new MySqlConnection("server=localhost;database=loginDB;user=root;password=");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "SELECT nome FROM usuarios WHERE usuario=@usuario AND senha=@senha";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                cmd.Parameters.AddWithValue("@senha", txtSenha.Text);
                var result = cmd.ExecuteScalar();

                if (result != null)
                {
                    this.Hide();
                    var formMain = new FormMain(result.ToString());
                    formMain.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}