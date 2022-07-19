using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gestor_Restaurantes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void verEmpregadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmp _FormEmp = new FormEmp();
            _FormEmp.Show();
        }

        private void adicionarEmpregadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmp _AddEmp = new AddEmp();
            _AddEmp.Show();
        }

        private void removerEmpregadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemEmp _RemEmp = new RemEmp();
            _RemEmp.Show();
        }

        private void verRestaurantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRes _FormRes = new FormRes();
            _FormRes.Show();
        }

        private void adicionarRestaurantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRes _AddRes = new AddRes();
            _AddRes.Show();
        }

        private void removerRestaurantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemRes _RemRes = new RemRes();
            _RemRes.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
