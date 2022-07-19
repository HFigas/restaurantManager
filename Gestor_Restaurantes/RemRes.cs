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
    public partial class RemRes : Form
    {
        public RemRes()
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
                String nome_res = textBox1.Text;
                OleDbCommand cmd = new OleDbCommand("DELETE FROM restaurantes WHERE nome_restaurante ='" + nome_res + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Restaurante removido com sucesso!");
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
