namespace GESTIONBAR
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition4 = new Telerik.WinControls.UI.TableViewDefinition();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDepenser = new Telerik.WinControls.UI.RadButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkFiltre = new System.Windows.Forms.CheckBox();
            this.lblRecette = new System.Windows.Forms.Label();
            this.lblFdd = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegarderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirUnAutreJourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archiverManuellementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changerDeStockageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnVendre = new Telerik.WinControls.UI.RadButton();
            this.dgvLogOperations = new Telerik.WinControls.UI.RadGridView();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.cheDepense = new Telerik.WinControls.UI.RadRadioButton();
            this.cheVente = new Telerik.WinControls.UI.RadRadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDepenser)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVendre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogOperations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogOperations.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheDepense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheVente)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radLabel1);
            this.groupBox1.Controls.Add(this.btnVendre);
            this.groupBox1.Controls.Add(this.btnDepenser);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lblRecette);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblFdd);
            this.groupBox1.Location = new System.Drawing.Point(25, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 367);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "iNFO JOURNALIERE";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnDepenser
            // 
            this.btnDepenser.BackColor = System.Drawing.Color.Tomato;
            this.btnDepenser.Location = new System.Drawing.Point(165, 313);
            this.btnDepenser.Name = "btnDepenser";
            this.btnDepenser.Size = new System.Drawing.Size(137, 30);
            this.btnDepenser.TabIndex = 7;
            this.btnDepenser.Text = "Depenser";
            this.btnDepenser.ThemeName = "Fluent";
            this.btnDepenser.Click += new System.EventHandler(this.btnDepenser_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cheVente);
            this.groupBox2.Controls.Add(this.cheDepense);
            this.groupBox2.Controls.Add(this.checkFiltre);
            this.groupBox2.Location = new System.Drawing.Point(10, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 113);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // checkFiltre
            // 
            this.checkFiltre.AutoSize = true;
            this.checkFiltre.Location = new System.Drawing.Point(16, 12);
            this.checkFiltre.Name = "checkFiltre";
            this.checkFiltre.Size = new System.Drawing.Size(122, 21);
            this.checkFiltre.TabIndex = 0;
            this.checkFiltre.Text = "activer ce filtre";
            this.checkFiltre.UseVisualStyleBackColor = true;
            this.checkFiltre.CheckedChanged += new System.EventHandler(this.checkFiltre_CheckedChanged);
            // 
            // lblRecette
            // 
            this.lblRecette.AutoSize = true;
            this.lblRecette.Location = new System.Drawing.Point(130, 84);
            this.lblRecette.Name = "lblRecette";
            this.lblRecette.Size = new System.Drawing.Size(52, 17);
            this.lblRecette.TabIndex = 3;
            this.lblRecette.Text = "recette";
            // 
            // lblFdd
            // 
            this.lblFdd.AutoSize = true;
            this.lblFdd.Location = new System.Drawing.Point(127, 43);
            this.lblFdd.Name = "lblFdd";
            this.lblFdd.Size = new System.Drawing.Size(101, 17);
            this.lblFdd.TabIndex = 1;
            this.lblFdd.Text = "fond de depart";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.configurationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sauvegarderToolStripMenuItem,
            this.ouvrirUnAutreJourToolStripMenuItem,
            this.archiverManuellementToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // sauvegarderToolStripMenuItem
            // 
            this.sauvegarderToolStripMenuItem.Name = "sauvegarderToolStripMenuItem";
            this.sauvegarderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.sauvegarderToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.sauvegarderToolStripMenuItem.Text = "Sauvegarder";
            this.sauvegarderToolStripMenuItem.Click += new System.EventHandler(this.sauvegarderToolStripMenuItem_Click);
            // 
            // ouvrirUnAutreJourToolStripMenuItem
            // 
            this.ouvrirUnAutreJourToolStripMenuItem.Name = "ouvrirUnAutreJourToolStripMenuItem";
            this.ouvrirUnAutreJourToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.ouvrirUnAutreJourToolStripMenuItem.Text = "Ouvrir un autre jour";
            // 
            // archiverManuellementToolStripMenuItem
            // 
            this.archiverManuellementToolStripMenuItem.Name = "archiverManuellementToolStripMenuItem";
            this.archiverManuellementToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.archiverManuellementToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.archiverManuellementToolStripMenuItem.Text = "Archiver manuellement";
            this.archiverManuellementToolStripMenuItem.ToolTipText = "archiver de façcon manuelle le resumé du jour.le resume est archiver automatiquem" +
    "ent toutes les 24 heures";
            this.archiverManuellementToolStripMenuItem.Click += new System.EventHandler(this.archiverManuellementToolStripMenuItem_Click);
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changerDeStockageToolStripMenuItem});
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.configurationToolStripMenuItem.Text = "configuration";
            // 
            // changerDeStockageToolStripMenuItem
            // 
            this.changerDeStockageToolStripMenuItem.Name = "changerDeStockageToolStripMenuItem";
            this.changerDeStockageToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.changerDeStockageToolStripMenuItem.Text = "changer de stockage";
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(GESTIONBAR.Form1);
            // 
            // btnVendre
            // 
            this.btnVendre.BackColor = System.Drawing.Color.ForestGreen;
            this.btnVendre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVendre.Location = new System.Drawing.Point(10, 312);
            this.btnVendre.Name = "btnVendre";
            this.btnVendre.Size = new System.Drawing.Size(137, 30);
            this.btnVendre.TabIndex = 8;
            this.btnVendre.Text = "Vendre";
            this.btnVendre.ThemeName = "Fluent";
            // 
            // dgvLogOperations
            // 
            this.dgvLogOperations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLogOperations.Location = new System.Drawing.Point(383, 70);
            // 
            // 
            // 
            this.dgvLogOperations.MasterTemplate.ViewDefinition = tableViewDefinition4;
            this.dgvLogOperations.Name = "dgvLogOperations";
            this.dgvLogOperations.Size = new System.Drawing.Size(395, 358);
            this.dgvLogOperations.TabIndex = 3;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radLabel1.Location = new System.Drawing.Point(10, 35);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(120, 25);
            this.radLabel1.TabIndex = 9;
            this.radLabel1.Text = "Fond de depart";
            this.radLabel1.ThemeName = "Fluent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Recette actuelle :";
            // 
            // cheDepense
            // 
            this.cheDepense.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cheDepense.Location = new System.Drawing.Point(16, 40);
            this.cheDepense.Name = "cheDepense";
            this.cheDepense.Size = new System.Drawing.Size(256, 25);
            this.cheDepense.TabIndex = 3;
            this.cheDepense.Text = "Afficher seulement les depenses";
            this.cheDepense.ThemeName = "Fluent";
            this.cheDepense.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.cheDepense_ToggleStateChanged);
            // 
            // cheVente
            // 
            this.cheVente.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cheVente.Location = new System.Drawing.Point(16, 72);
            this.cheVente.Name = "cheVente";
            this.cheVente.Size = new System.Drawing.Size(235, 25);
            this.cheVente.TabIndex = 4;
            this.cheVente.Text = "Afficher seulement les ventes";
            this.cheVente.ThemeName = "Fluent";
            this.cheVente.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.cheVente_ToggleStateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvLogOperations);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Gestion Bar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDepenser)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVendre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogOperations.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogOperations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheDepense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheVente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFdd;
        private System.Windows.Forms.Label lblRecette;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkFiltre;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sauvegarderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirUnAutreJourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changerDeStockageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archiverManuellementToolStripMenuItem;
        private Telerik.WinControls.UI.RadButton btnDepenser;
        private Telerik.WinControls.UI.RadButton btnVendre;
        private Telerik.WinControls.UI.RadGridView dgvLogOperations;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadRadioButton cheVente;
        private Telerik.WinControls.UI.RadRadioButton cheDepense;
        private System.Windows.Forms.Label label2;
    }
}

