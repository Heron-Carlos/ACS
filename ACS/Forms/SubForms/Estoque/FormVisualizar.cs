using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ACS.Forms.SubForms.Estoque
{
    public partial class FormVisualizar : Form
    {
        string data_source = "server=localhost;database=acs;uid=root;pwd=heron362;port=3306";

        public FormVisualizar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection Cn;
                Cn = new MySqlConnection(data_source);
                Cn.Open();
                var exibirVagas = "SELECT * FROM Estoque ";
                using (MySqlDataAdapter da = new MySqlDataAdapter(exibirVagas, Cn))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
                Cn.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string item = Convert.ToString(comboBox2.Text);
                try
                {
                    if (item != "")
                    {
                        var sqlComand = "";
                        if (item == "Codigo")
                        {
                            sqlComand = " SELECT * FROM Estoque WHERE CodigoItem = '" + textBox1.Text + "' ";
                        }
                        if (item == "Marca")
                        {
                            sqlComand = "SELECT * FROM Estoque WHERE Marca = '" + textBox1.Text + "'";
                        }
                        if (item == "Descrição")
                        {
                            sqlComand = "SELECT * FROM Estoque WHERE Descricao = '" + textBox1.Text + "'";
                        }
                        if (item == "Local")
                        {
                            sqlComand = "SELECT * FROM Estoque WHERE Localizacao = '" + textBox1.Text + "'";
                        }
                        if (item == "Tipo")
                        {
                            sqlComand = "SELECT * FROM Estoque WHERE Tipo = '" + textBox1.Text + "'";
                        }
                        if (item == "Item")
                        {
                            sqlComand = "SELECT * FROM Estoque WHERE Item = '" + textBox1.Text + "'";
                        }
                        if (item == "Procedencia")
                        {
                            sqlComand = "SELECT * FROM Estoque WHERE Procedencia = '" + textBox1.Text + "'";
                        }
                        MySqlConnection Cn;
                        Cn = new MySqlConnection(data_source);
                        Cn.Open();
                        using (MySqlDataAdapter da = new MySqlDataAdapter(sqlComand, Cn))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                da.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                        }
                        Cn.Close();

                    }
                    else MessageBox.Show("Descreva o tipo de Item desejado!");
                }

                catch (Exception)
                {

                    throw;
                }
            }


            else MessageBox.Show("Complete os espaços para fazer a pesquisa detalhada!");



        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection Cn;
                Cn = new MySqlConnection(data_source);
                Cn.Open();
                var exibirVagas = "SELECT * FROM Estoque Where Tipo = '" + comboBox1.Text + "' AND Localizacao = '" + textBox2.Text + "' AND STTS = '" + comboBox3.Text + "' AND Procedencia = '" + comboBox4.Text + "' ";
                using (MySqlDataAdapter da = new MySqlDataAdapter(exibirVagas, Cn))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
                Cn.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
