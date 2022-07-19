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
    public partial class FormEmp : Form
    {
        public FormEmp()
        {
            InitializeComponent();
        }

        private void FormEmp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbrestDataSet.empregados' table. You can move, or remove it, as needed.
            this.empregadosTableAdapter.Fill(this.dbrestDataSet.empregados);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
