namespace excellmachina
{
    partial class editValueForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.replaceChckbx = new System.Windows.Forms.CheckBox();
            this.replaceButton = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ersetzen mit:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(411, 20);
            this.textBox1.TabIndex = 1;
            // 
            // replaceChckbx
            // 
            this.replaceChckbx.AutoSize = true;
            this.replaceChckbx.Location = new System.Drawing.Point(302, 70);
            this.replaceChckbx.Name = "replaceChckbx";
            this.replaceChckbx.Size = new System.Drawing.Size(86, 17);
            this.replaceChckbx.TabIndex = 2;
            this.replaceChckbx.Text = "Alle ersetzen";
            this.replaceChckbx.UseVisualStyleBackColor = true;
            // 
            // replaceButton
            // 
            this.replaceButton.Location = new System.Drawing.Point(302, 93);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(121, 30);
            this.replaceButton.TabIndex = 3;
            this.replaceButton.Text = "Ersetzen";
            this.replaceButton.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Tomato;
            this.buttonCancel.Location = new System.Drawing.Point(302, 129);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(121, 30);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Abbrechen";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Gefundener Ort:";
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(168, 93);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(46, 30);
            this.buttonPrevious.TabIndex = 8;
            this.buttonPrevious.Text = "⮜";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(220, 93);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(46, 30);
            this.buttonNext.TabIndex = 9;
            this.buttonNext.Text = "⮞";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Vorheriger / Nächster Wert";
            // 
            // editValueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 171);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.replaceButton);
            this.Controls.Add(this.replaceChckbx);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "editValueForm";
            this.Text = "Wert Bearbeiten";
            this.Load += new System.EventHandler(this.editValueForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox replaceChckbx;
        private System.Windows.Forms.Button replaceButton;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label label3;
    }
}