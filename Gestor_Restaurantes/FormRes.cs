using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_Restaurantes
{
    public partial class FormRes : Form
    {
        public FormRes()
        {
            InitializeComponent();
        }

        private void FormRes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbrestDataSet.restaurantes' table. You can move, or remove it, as needed.
            this.restaurantesTableAdapter.Fill(this.dbrestDataSet.restaurantes);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
