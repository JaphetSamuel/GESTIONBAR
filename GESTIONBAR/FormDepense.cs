using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTIONBAR
{
    public partial class FormDepense : Form
    {
        public FormDepense()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tbSomme.Text == string.Empty)
            {
                MessageBox.Show("Erreur! entrez une somme valide");
            }
            Journal.Depenser(int.Parse(tbSomme.Text), rtInfo.Text);

            this.Close();
        }
    }
}
