namespace excellmachina
{
    partial class importForm
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
            this.openFileBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.insertButton = new System.Windows.Forms.Button();
            this.DataNameLabel = new System.Windows.Forms.Label();
            this.cancelButtonF2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileBtn
            // 
            this.openFileBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.openFileBtn.FlatAppearance.BorderSize = 0;
            this.openFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openFileBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.openFileBtn.Location = new System.Drawing.Point(297, 175);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(125, 50);
            this.openFileBtn.TabIndex = 0;
            this.openFileBtn.Text = "Arbeitsmappe öffnen...";
            this.openFileBtn.UseVisualStyleBackColor = false;
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Excel-Datein (*.xl*)|*.xl*";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(53, 117);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(212, 108);
            this.listBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tabellenblatt auswahl:";
            // 
            // insertButton
            // 
            this.insertButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.insertButton.FlatAppearance.BorderSize = 0;
            this.insertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertButton.ForeColor = System.Drawing.SystemColors.Window;
            this.insertButton.Location = new System.Drawing.Point(297, 117);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(125, 23);
            this.insertButton.TabIndex = 3;
            this.insertButton.Text = "Einfügen";
            this.insertButton.UseVisualStyleBackColor = false;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // DataNameLabel
            // 
            this.DataNameLabel.AutoSize = true;
            this.DataNameLabel.Location = new System.Drawing.Point(50, 40);
            this.DataNameLabel.Name = "DataNameLabel";
            this.DataNameLabel.Size = new System.Drawing.Size(58, 13);
            this.DataNameLabel.TabIndex = 4;
            this.DataNameLabel.Text = "Dateiname";
            // 
            // cancelButtonF2
            // 
            this.cancelButtonF2.BackColor = System.Drawing.Color.Tomato;
            this.cancelButtonF2.FlatAppearance.BorderSize = 0;
            this.cancelButtonF2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButtonF2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cancelButtonF2.Location = new System.Drawing.Point(297, 146);
            this.cancelButtonF2.Name = "cancelButtonF2";
            this.cancelButtonF2.Size = new System.Drawing.Size(125, 23);
            this.cancelButtonF2.TabIndex = 5;
            this.cancelButtonF2.Text = "Abbrechen";
            this.cancelButtonF2.UseVisualStyleBackColor = false;
            this.cancelButtonF2.Click += new System.EventHandler(this.cancelButtonF2_Click);
            // 
            // importForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(481, 270);
            this.Controls.Add(this.cancelButtonF2);
            this.Controls.Add(this.DataNameLabel);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.openFileBtn);
            this.Name = "importForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Tabelle Einfügen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openFileBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Label DataNameLabel;
        private System.Windows.Forms.Button cancelButtonF2;
    }
}