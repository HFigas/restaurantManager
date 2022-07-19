using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Gestor_Restaurantes
{
    public partial class AddEmp : Form
    {
        public AddEmp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|dbrest.accdb;
Persist Security Info=False;";

            try
            {
                conn.Open();
                String nome = textBox1.Text;
                String telefone = textBox2.Text;
                String nif = textBox3.Text;
                String cc = textBox4.Text;
                String endereco = textBox5.Text;
                String funcao = textBox6.Text;
                String my_querry = "INSERT INTO empregados(nome, telefone, nif, cc, endereco, funcao) " +
                           "Values('" + nome + "', '" + telefone + "', '" + nif + "', '" + cc + "',  '" + endereco + "',  '" + funcao + "')";

                OleDbCommand cmd = new OleDbCommand(my_querry, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Empregado adicionado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddEmp_Load(object sender, EventArgs e)
        {

        }
    }
}
