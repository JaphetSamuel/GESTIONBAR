namespace GESTIONBAR
{
    partial class FormDepense
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelSomme = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSomme = new System.Windows.Forms.TextBox();
            this.rtInfo = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSomme
            // 
            this.labelSomme.AutoSize = true;
            this.labelSomme.Location = new System.Drawing.Point(27, 25);
            this.labelSomme.Name = "labelSomme";
            this.labelSomme.Size = new System.Drawing.Size(53, 17);
            this.labelSomme.TabIndex = 0;
            this.labelSomme.Text = "somme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "information";
            // 
            // tbSomme
            // 
            this.tbSomme.Location = new System.Drawing.Point(114, 25);
            this.tbSomme.Name = "tbSomme";
            this.tbSomme.Size = new System.Drawing.Size(137, 22);
            this.tbSomme.TabIndex = 2;
            // 
            // rtInfo
            // 
            this.rtInfo.Location = new System.Drawing.Point(115, 66);
            this.rtInfo.Name = "rtInfo";
            this.rtInfo.Size = new System.Drawing.Size(179, 119);
            this.rtInfo.TabIndex = 3;
            this.rtInfo.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormDepense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 378);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtInfo);
            this.Controls.Add(this.tbSomme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelSomme);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDepense";
            this.Text = "Enregistrer une nouvelle depense";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSomme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSomme;
        private System.Windows.Forms.RichTextBox rtInfo;
        private System.Windows.Forms.Button button1;
    }
}