using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace ACS
{
    public partial class TelaPrincipal : Form
    {
        string data_source = "server=localhost;database=acs;uid=root;pwd=heron362;port=3306";


        private void VerificacaoAdmin()
        {
            string select = "SELECT admin from login where usuario = '" + label2.Text + "'";
            string valorRecuperado = string.Empty;
            MySqlConnection Conexao;
            try
            {
                using (MySqlConnection connection = new MySqlConnection(data_source))
                {
                    // Abra a conexão
                    connection.Open();

                    // Crie um comando com a consulta SQL e a conexão
                    using (MySqlCommand command = new MySqlCommand(select, connection))
                    {
                        // Execute a consulta e obtenha o resultado
                        object resultado = command.ExecuteScalar();

                        // Verifique se o resultado é nulo
                        if (resultado != null)
                        {
                            // Converte o resultado para o tipo correto (neste caso, string)
                            valorRecuperado = resultado.ToString();
                        }
                        connection.Close();
                    }
                }
                if (valorRecuperado == "1")
                {
                    button7.Enabled = true;

                }
                else
                {
                    button7.Enabled = false;
                    button7.Text = "";
                }

            }
            catch (Exception)
            {
                throw;
            }
        }
        private Form activeForm;
        public TelaPrincipal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        public TelaPrincipal(string valor)
        {
            InitializeComponent();
            label2.Text = valor;
        }
        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            this.VerificacaoAdmin();
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(childForm);
            this.panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label1.Text = childForm.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormEstoque(), sender);
        }
        private void button2_Click(object sender, EventArgs e)
        {
        }
        private void button3_Click(object sender, EventArgs e)
        {
        }
        private void button4_Click(object sender, EventArgs e)
        {
        }
        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCadastrarUsuario(), sender);
        }
    }
}
