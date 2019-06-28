using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace GESTIONBAR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Journal.Charger();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Actualisation();         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Journal.Sauvegarder();
        }

        private void btnVendre_Click(object sender, EventArgs e)
        {
            formVente fvente = new formVente();
            fvente.ShowDialog();
            Actualisation();
        }

        private void Actualisation()
        {
            lblFdd.Text = Journal.SommeDepart.ToString();
            lblRecette.Text = Journal.Recette.ToString();
            ActulisationGrid();
        }
        private void ActulisationGrid()
        {
            dgvLogOperations.DataSource = Journal.Operations.ToList();
            
            if(cheDepense.IsChecked == true && cheDepense.Enabled)
            {
                var d = from k in Journal.Operations
                        where k.Value.Contains("sortie")
                        select k;
                dgvLogOperations.DataSource = d.ToList();
                
            }
            if(cheVente.IsChecked == true && cheVente.Enabled)
            {
                var d = from k in Journal.Operations
                        where k.Value.Contains("vendu")
                        select k;
                dgvLogOperations.DataSource = d.ToList();
            }
        }

    

        private void checkFiltre_CheckedChanged(object sender, EventArgs e)
        {
            cheVente.Enabled = (checkFiltre.Checked) ? true : false;
            cheDepense.Enabled = (checkFiltre.Checked) ? true : false;
            ActulisationGrid();
        }

        private void cheDepense_CheckedChanged_1(object sender, EventArgs e)
        {
            ActulisationGrid();
        }

        private void cheVente_CheckedChanged(object sender, EventArgs e)
        {
            ActulisationGrid();
        }

        private void sauvegarderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Journal.Sauvegarder();
            MessageBox.Show("document sauvegardé");
        }

        private void archiverManuellementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            var warn = MessageBox.Show("le resumé actuelle va être reinitialiser. Voulez vous continuer?","Attention!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (warn == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                try
                {
                    Journal.Archiver();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Erreur à l'archivage \n" + err.Message);
                }
                MessageBox.Show("Resumé archivé");
            }
            
            Actualisation();
            
        }

        private void btnDepenser_Click_1(object sender, EventArgs e)
        {
            FormDepense fdepense = new FormDepense();
            fdepense.ShowDialog();
            Actualisation();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cheDepense_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            ActulisationGrid();
        }

        private void cheVente_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            ActulisationGrid();
        }
    }
}
