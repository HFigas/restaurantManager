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
    public partial class RemEmp : Form
    {
        public RemEmp()
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
                OleDbCommand cmd = new OleDbCommand("DELETE FROM empregados WHERE nome ='" + nome + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Empregado removido com sucesso!");
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

    }
}
