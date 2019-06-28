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
    public partial class formVente : Form
    {
        public formVente()
        {
            InitializeComponent();
        }

        private void formVente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tbSomme.Text == string.Empty)
            {
                MessageBox.Show("Entrez une somme valide", "Erreur");
                return;
            }
            Journal.Vendu(int.Parse(tbSomme.Text), rtInfo.Text);
            this.Close();
            
        }
    }
}
