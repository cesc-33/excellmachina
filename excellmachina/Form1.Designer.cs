namespace excellmachina
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButtonTemplate = new System.Windows.Forms.RadioButton();
            this.radioButtonNewSheet = new System.Windows.Forms.RadioButton();
            this.radioButtonSheetDelete = new System.Windows.Forms.RadioButton();
            this.sheetLockLabel = new System.Windows.Forms.Label();
            this.moveSheetChkbx = new System.Windows.Forms.CheckBox();
            this.sheetRadioBtn = new System.Windows.Forms.Button();
            this.sheetLockBtn = new System.Windows.Forms.Button();
            this.importWorkbookBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.copySheetBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.fromBox = new System.Windows.Forms.TextBox();
            this.toBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.radioButtonSearchVar = new System.Windows.Forms.RadioButton();
            this.radioButtonAreaDel = new System.Windows.Forms.RadioButton();
            this.dataNameLabelFrm1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(879, 280);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 60);
            this.okButton.TabIndex = 13;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Tomato;
            this.cancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.cancelButton.Location = new System.Drawing.Point(879, 346);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 60);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Abbrechen";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ItemSize = new System.Drawing.Size(64, 50);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(983, 274);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.dataNameLabelFrm1);
            this.tabPage1.Controls.Add(this.sheetLockLabel);
            this.tabPage1.Controls.Add(this.moveSheetChkbx);
            this.tabPage1.Controls.Add(this.sheetRadioBtn);
            this.tabPage1.Controls.Add(this.sheetLockBtn);
            this.tabPage1.Controls.Add(this.importWorkbookBtn);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.copySheetBtn);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 54);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(975, 216);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Auswählen";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButtonTemplate);
            this.panel2.Controls.Add(this.radioButtonNewSheet);
            this.panel2.Controls.Add(this.radioButtonSheetDelete);
            this.panel2.Location = new System.Drawing.Point(764, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(161, 100);
            this.panel2.TabIndex = 25;
            // 
            // radioButtonTemplate
            // 
            this.radioButtonTemplate.AutoSize = true;
            this.radioButtonTemplate.Location = new System.Drawing.Point(1, 49);
            this.radioButtonTemplate.Name = "radioButtonTemplate";
            this.radioButtonTemplate.Size = new System.Drawing.Size(103, 17);
            this.radioButtonTemplate.TabIndex = 27;
            this.radioButtonTemplate.Text = "Vorlage erstellen";
            this.radioButtonTemplate.UseVisualStyleBackColor = true;
            // 
            // radioButtonNewSheet
            // 
            this.radioButtonNewSheet.AutoSize = true;
            this.radioButtonNewSheet.Location = new System.Drawing.Point(1, 26);
            this.radioButtonNewSheet.Name = "radioButtonNewSheet";
            this.radioButtonNewSheet.Size = new System.Drawing.Size(120, 17);
            this.radioButtonNewSheet.TabIndex = 26;
            this.radioButtonNewSheet.Text = "Neues Tabellenblatt";
            this.radioButtonNewSheet.UseVisualStyleBackColor = true;
            // 
            // radioButtonSheetDelete
            // 
            this.radioButtonSheetDelete.AutoSize = true;
            this.radioButtonSheetDelete.Checked = true;
            this.radioButtonSheetDelete.Location = new System.Drawing.Point(1, 3);
            this.radioButtonSheetDelete.Name = "radioButtonSheetDelete";
            this.radioButtonSheetDelete.Size = new System.Drawing.Size(126, 17);
            this.radioButtonSheetDelete.TabIndex = 25;
            this.radioButtonSheetDelete.TabStop = true;
            this.radioButtonSheetDelete.Text = "Tabellenblatt löschen";
            this.radioButtonSheetDelete.UseVisualStyleBackColor = true;
            // 
            // sheetLockLabel
            // 
            this.sheetLockLabel.AutoSize = true;
            this.sheetLockLabel.Location = new System.Drawing.Point(761, 16);
            this.sheetLockLabel.Name = "sheetLockLabel";
            this.sheetLockLabel.Size = new System.Drawing.Size(102, 13);
            this.sheetLockLabel.TabIndex = 24;
            this.sheetLockLabel.Text = "Blatt ist ungeschützt";
            // 
            // moveSheetChkbx
            // 
            this.moveSheetChkbx.AutoSize = true;
            this.moveSheetChkbx.Location = new System.Drawing.Point(765, 74);
            this.moveSheetChkbx.Name = "moveSheetChkbx";
            this.moveSheetChkbx.Size = new System.Drawing.Size(148, 17);
            this.moveSheetChkbx.TabIndex = 23;
            this.moveSheetChkbx.Text = "Tabellenblatt verschieben";
            this.moveSheetChkbx.UseVisualStyleBackColor = true;
            this.moveSheetChkbx.CheckedChanged += new System.EventHandler(this.moveSheetChkbx_CheckedChanged);
            // 
            // sheetRadioBtn
            // 
            this.sheetRadioBtn.Location = new System.Drawing.Point(545, 99);
            this.sheetRadioBtn.Name = "sheetRadioBtn";
            this.sheetRadioBtn.Size = new System.Drawing.Size(168, 23);
            this.sheetRadioBtn.TabIndex = 22;
            this.sheetRadioBtn.Text = "Tabellenblatt löschen";
            this.sheetRadioBtn.UseVisualStyleBackColor = true;
            this.sheetRadioBtn.Click += new System.EventHandler(this.sheetRadioBtn_Click);
            // 
            // sheetLockBtn
            // 
            this.sheetLockBtn.Location = new System.Drawing.Point(545, 11);
            this.sheetLockBtn.Name = "sheetLockBtn";
            this.sheetLockBtn.Size = new System.Drawing.Size(168, 23);
            this.sheetLockBtn.TabIndex = 21;
            this.sheetLockBtn.Text = "Blattschutz an/aus";
            this.sheetLockBtn.UseVisualStyleBackColor = true;
            this.sheetLockBtn.Click += new System.EventHandler(this.sheetLockBtn_Click);
            // 
            // importWorkbookBtn
            // 
            this.importWorkbookBtn.Location = new System.Drawing.Point(545, 139);
            this.importWorkbookBtn.Name = "importWorkbookBtn";
            this.importWorkbookBtn.Size = new System.Drawing.Size(168, 50);
            this.importWorkbookBtn.TabIndex = 19;
            this.importWorkbookBtn.Text = "Arbeitsmappe importieren...";
            this.importWorkbookBtn.UseVisualStyleBackColor = true;
            this.importWorkbookBtn.Click += new System.EventHandler(this.importWorkbookBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Einfügen vor:";
            // 
            // copySheetBtn
            // 
            this.copySheetBtn.Location = new System.Drawing.Point(545, 70);
            this.copySheetBtn.Name = "copySheetBtn";
            this.copySheetBtn.Size = new System.Drawing.Size(168, 23);
            this.copySheetBtn.TabIndex = 20;
            this.copySheetBtn.Text = "Tabellenblatt kopieren";
            this.copySheetBtn.UseVisualStyleBackColor = true;
            this.copySheetBtn.Click += new System.EventHandler(this.copySheetBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(298, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(168, 95);
            this.listBox1.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tabellenblatt auswählen:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(27, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 54);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(975, 216);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bearbeiten";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.radioButtonSearchVar);
            this.panel1.Controls.Add(this.radioButtonAreaDel);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 210);
            this.panel1.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.searchBox);
            this.panel4.Controls.Add(this.searchButton);
            this.panel4.Location = new System.Drawing.Point(159, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(158, 138);
            this.panel4.TabIndex = 27;
            // 
            // searchBox
            // 
            this.searchBox.AccessibleDescription = "test";
            this.searchBox.Location = new System.Drawing.Point(0, 3);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(158, 20);
            this.searchBox.TabIndex = 6;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(46, 34);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(66, 20);
            this.searchButton.TabIndex = 16;
            this.searchButton.Text = "🔍";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Controls.Add(this.deleteButton);
            this.panel3.Controls.Add(this.fromBox);
            this.panel3.Controls.Add(this.toBox);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(323, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(158, 138);
            this.panel3.TabIndex = 26;
            this.panel3.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(0, 35);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(158, 21);
            this.comboBox2.TabIndex = 17;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(44, 113);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 25;
            this.deleteButton.Text = "Löschen";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // fromBox
            // 
            this.fromBox.Location = new System.Drawing.Point(0, 88);
            this.fromBox.Name = "fromBox";
            this.fromBox.Size = new System.Drawing.Size(70, 20);
            this.fromBox.TabIndex = 18;
            // 
            // toBox
            // 
            this.toBox.Location = new System.Drawing.Point(88, 87);
            this.toBox.Name = "toBox";
            this.toBox.Size = new System.Drawing.Size(70, 20);
            this.toBox.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Tabellenblatt auswählen:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Von";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(85, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Bis";
            // 
            // radioButtonSearchVar
            // 
            this.radioButtonSearchVar.AutoSize = true;
            this.radioButtonSearchVar.Checked = true;
            this.radioButtonSearchVar.Location = new System.Drawing.Point(13, 13);
            this.radioButtonSearchVar.Name = "radioButtonSearchVar";
            this.radioButtonSearchVar.Size = new System.Drawing.Size(86, 17);
            this.radioButtonSearchVar.TabIndex = 0;
            this.radioButtonSearchVar.TabStop = true;
            this.radioButtonSearchVar.Text = "Wert suchen";
            this.radioButtonSearchVar.UseVisualStyleBackColor = true;
            this.radioButtonSearchVar.CheckedChanged += new System.EventHandler(this.radioButtonSearchVar_CheckedChanged);
            // 
            // radioButtonAreaDel
            // 
            this.radioButtonAreaDel.AutoSize = true;
            this.radioButtonAreaDel.Location = new System.Drawing.Point(13, 46);
            this.radioButtonAreaDel.Name = "radioButtonAreaDel";
            this.radioButtonAreaDel.Size = new System.Drawing.Size(101, 17);
            this.radioButtonAreaDel.TabIndex = 1;
            this.radioButtonAreaDel.Text = "Bereich löschen";
            this.radioButtonAreaDel.UseVisualStyleBackColor = true;
            this.radioButtonAreaDel.CheckedChanged += new System.EventHandler(this.radioButtonAreaDel_CheckedChanged);
            // 
            // dataNameLabelFrm1
            // 
            this.dataNameLabelFrm1.AutoSize = true;
            this.dataNameLabelFrm1.Location = new System.Drawing.Point(762, 50);
            this.dataNameLabelFrm1.Name = "dataNameLabelFrm1";
            this.dataNameLabelFrm1.Size = new System.Drawing.Size(58, 13);
            this.dataNameLabelFrm1.TabIndex = 18;
            this.dataNameLabelFrm1.Text = "Dateiname";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 280);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(866, 344);
            this.dataGridView1.TabIndex = 19;
            // 
            // Form1
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 627);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ExcelMachina";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton radioButtonTemplate;
        private System.Windows.Forms.RadioButton radioButtonNewSheet;
        private System.Windows.Forms.RadioButton radioButtonSheetDelete;
        private System.Windows.Forms.Label sheetLockLabel;
        private System.Windows.Forms.CheckBox moveSheetChkbx;
        private System.Windows.Forms.Button sheetRadioBtn;
        private System.Windows.Forms.Button sheetLockBtn;
        private System.Windows.Forms.Button copySheetBtn;
        private System.Windows.Forms.Button importWorkbookBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.RadioButton radioButtonAreaDel;
        private System.Windows.Forms.RadioButton radioButtonSearchVar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox toBox;
        private System.Windows.Forms.TextBox fromBox;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label dataNameLabelFrm1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
    }
}

