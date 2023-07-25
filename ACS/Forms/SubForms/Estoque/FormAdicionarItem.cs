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
using TextBox = System.Windows.Forms.TextBox;

namespace ACS.Forms.SubForms
{
    public partial class FormAdicionarItem : Form
    {
        string data_source = "server=localhost;database=acs;uid=root;pwd=heron362;port=3306";


        public FormAdicionarItem()
        {
            InitializeComponent();
        }

        private void FormAdicionarItem_Load(object sender, EventArgs e)
        {

        }

        private bool textBoxVazias()
        {
            foreach (Control c in this.Controls)
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                        return true;
                }
            return false;


        }

        //Função para cadastra o Item
        private void Cadastrar()
        {
            DateTime dataCadastro = DateTime.Now; // ou substitua DateTime.Now pelo valor desejado
            string dataCadastroFormatada = dataCadastro.ToString("dd/MM/yyyy HH:mm:ss");

            int quant = Convert.ToInt32(textBox3.Text);
            for (int i = 0; i < quant; i++)
            {
                MySqlConnection Conexao;

                try
                {


                    Conexao = new MySqlConnection(data_source);
                    string sql = "INSERT INTO Estoque (CodigoItem, Item, Descricao, Marca, Tipo, Localizacao, Stts, Procedencia, Quantidade, dataCadastro) VALUES (null, '" + textBox1.Text + "' ,'" + textBox2.Text + "' ,'" + textBox4.Text + "','" + comboBox2.Text + "','" + textBox5.Text + "', '" + comboBox3.Text + "', '" + comboBox4.Text + "', 1, '"+dataCadastroFormatada+"')";
                    MySqlCommand comando = new MySqlCommand(sql, Conexao);
                    Conexao.Open();
                    comando.ExecuteReader();

                    Conexao.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }

            }
            MessageBox.Show("Cadastrado Concluído !");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";


        }


        //Função para verificar todas as TextBox e comboBox necessárias para o cadastro do item
        private void button1_Click(object sender, EventArgs e)
        {
            //this.textBoxVazias();
            //if (textBoxVazias()) MessageBox.Show("Preencha todas as informações");
            //else
            //{
            //    this.Cadastrar();
            //}
            if (textBox1.Text != "" && textBox2.Text !="" && textBox3.Text !="" && textBox4.Text != "" && textBox5.Text != "" && comboBox2.Text !="" && comboBox3.Text !="" && comboBox4.Text != "")
            {
                this.Cadastrar();
            }
            else
            {
                MessageBox.Show("Preencha todas as informações");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
