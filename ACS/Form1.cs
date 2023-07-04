using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;

namespace ACS
{
    public partial class Form1 : Form
    {
        string data_source = "server=localhost;database=acs;uid=root;pwd=heron362;port=3306";

        public Form1()
        {
            InitializeComponent();
        }

        public void Verificação()
        {

            try
            {
                MySqlConnection Conexao;
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();
                string user = textBox1.Text;
                string pass = textBox2.Text;
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Login WHERE usuario='" + textBox1.Text + "' AND senha ='" + textBox2.Text + "'", Conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    //Abre Form Geral caso os dados do Login estejam certos
                    this.Hide();
                    var form2 = new TelaPrincipal(textBox1.Text);
                    form2.Closed += (s, args) => this.Close();
                    form2.Show();

                }
                else
                {
                    label3.Visible = true;
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            label3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Verificação();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



    }

}