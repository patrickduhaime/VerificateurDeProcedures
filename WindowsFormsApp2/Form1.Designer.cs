namespace WindowsFormsApp2
{
    partial class Verificateur
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
            this.panelControls = new System.Windows.Forms.Panel();
            this.buttonTest = new System.Windows.Forms.Button();
            this.textBoxProcedure = new System.Windows.Forms.RichTextBox();
            this.textBoxResultats = new System.Windows.Forms.RichTextBox();
            this.labelPorcedure = new System.Windows.Forms.Label();
            this.labelResultats = new System.Windows.Forms.Label();
            this.panelControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControls
            // 
            this.panelControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelControls.Controls.Add(this.buttonTest);
            this.panelControls.Location = new System.Drawing.Point(575, 21);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(200, 224);
            this.panelControls.TabIndex = 1;
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(19, 24);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(161, 48);
            this.buttonTest.TabIndex = 2;
            this.buttonTest.Text = "Tester la procedure";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxProcedure
            // 
            this.textBoxProcedure.Location = new System.Drawing.Point(12, 21);
            this.textBoxProcedure.Name = "textBoxProcedure";
            this.textBoxProcedure.Size = new System.Drawing.Size(557, 101);
            this.textBoxProcedure.TabIndex = 2;
            this.textBoxProcedure.Text = "";
            // 
            // textBoxResultats
            // 
            this.textBoxResultats.Location = new System.Drawing.Point(12, 144);
            this.textBoxResultats.Name = "textBoxResultats";
            this.textBoxResultats.Size = new System.Drawing.Size(557, 101);
            this.textBoxResultats.TabIndex = 3;
            this.textBoxResultats.Text = "";
            // 
            // labelPorcedure
            // 
            this.labelPorcedure.AutoSize = true;
            this.labelPorcedure.Location = new System.Drawing.Point(12, 5);
            this.labelPorcedure.Name = "labelPorcedure";
            this.labelPorcedure.Size = new System.Drawing.Size(96, 13);
            this.labelPorcedure.TabIndex = 4;
            this.labelPorcedure.Text = "Procedure éditable";
            // 
            // labelResultats
            // 
            this.labelResultats.AutoSize = true;
            this.labelResultats.Location = new System.Drawing.Point(12, 128);
            this.labelResultats.Name = "labelResultats";
            this.labelResultats.Size = new System.Drawing.Size(81, 13);
            this.labelResultats.TabIndex = 5;
            this.labelResultats.Text = "Résultat du test";
            // 
            // Verificateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 258);
            this.Controls.Add(this.labelResultats);
            this.Controls.Add(this.labelPorcedure);
            this.Controls.Add(this.textBoxResultats);
            this.Controls.Add(this.textBoxProcedure);
            this.Controls.Add(this.panelControls);
            this.Name = "Verificateur";
            this.Text = "Verificateur de procedures";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.RichTextBox textBoxProcedure;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.RichTextBox textBoxResultats;
        private System.Windows.Forms.Label labelPorcedure;
        private System.Windows.Forms.Label labelResultats;
    }
}

