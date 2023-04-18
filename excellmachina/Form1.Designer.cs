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
            this.panel5 = new System.Windows.Forms.Panel();
            this.radioButtonTemplate = new System.Windows.Forms.RadioButton();
            this.radioButtonNewSheet = new System.Windows.Forms.RadioButton();
            this.radioButtonSheetDelete = new System.Windows.Forms.RadioButton();
            this.dataNameLabelFrm1 = new System.Windows.Forms.Label();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSelectPnl = new System.Windows.Forms.Button();
            this.buttonEditPnl = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.panelConture = new System.Windows.Forms.Panel();
            this.panelSelect = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelConture.SuspendLayout();
            this.panelSelect.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.radioButtonTemplate);
            this.panel5.Controls.Add(this.radioButtonNewSheet);
            this.panel5.Controls.Add(this.radioButtonSheetDelete);
            this.panel5.Location = new System.Drawing.Point(742, 114);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(149, 100);
            this.panel5.TabIndex = 25;
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
            // dataNameLabelFrm1
            // 
            this.dataNameLabelFrm1.AutoSize = true;
            this.dataNameLabelFrm1.Location = new System.Drawing.Point(740, 55);
            this.dataNameLabelFrm1.Name = "dataNameLabelFrm1";
            this.dataNameLabelFrm1.Size = new System.Drawing.Size(58, 13);
            this.dataNameLabelFrm1.TabIndex = 18;
            this.dataNameLabelFrm1.Text = "Dateiname";
            // 
            // sheetLockLabel
            // 
            this.sheetLockLabel.AutoSize = true;
            this.sheetLockLabel.Location = new System.Drawing.Point(740, 24);
            this.sheetLockLabel.Name = "sheetLockLabel";
            this.sheetLockLabel.Size = new System.Drawing.Size(102, 13);
            this.sheetLockLabel.TabIndex = 24;
            this.sheetLockLabel.Text = "Blatt ist ungeschützt";
            // 
            // moveSheetChkbx
            // 
            this.moveSheetChkbx.AutoSize = true;
            this.moveSheetChkbx.Location = new System.Drawing.Point(743, 89);
            this.moveSheetChkbx.Name = "moveSheetChkbx";
            this.moveSheetChkbx.Size = new System.Drawing.Size(148, 17);
            this.moveSheetChkbx.TabIndex = 23;
            this.moveSheetChkbx.Text = "Tabellenblatt verschieben";
            this.moveSheetChkbx.UseVisualStyleBackColor = true;
            this.moveSheetChkbx.CheckedChanged += new System.EventHandler(this.moveSheetChkbx_CheckedChanged);
            // 
            // sheetRadioBtn
            // 
            this.sheetRadioBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sheetRadioBtn.FlatAppearance.BorderSize = 0;
            this.sheetRadioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sheetRadioBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.sheetRadioBtn.Location = new System.Drawing.Point(523, 114);
            this.sheetRadioBtn.Name = "sheetRadioBtn";
            this.sheetRadioBtn.Size = new System.Drawing.Size(168, 23);
            this.sheetRadioBtn.TabIndex = 22;
            this.sheetRadioBtn.Text = "Tabellenblatt löschen";
            this.sheetRadioBtn.UseVisualStyleBackColor = false;
            this.sheetRadioBtn.Click += new System.EventHandler(this.sheetRadioBtn_Click);
            // 
            // sheetLockBtn
            // 
            this.sheetLockBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sheetLockBtn.FlatAppearance.BorderSize = 0;
            this.sheetLockBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sheetLockBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.sheetLockBtn.Location = new System.Drawing.Point(523, 19);
            this.sheetLockBtn.Name = "sheetLockBtn";
            this.sheetLockBtn.Size = new System.Drawing.Size(168, 23);
            this.sheetLockBtn.TabIndex = 21;
            this.sheetLockBtn.Text = "Blattschutz an/aus";
            this.sheetLockBtn.UseVisualStyleBackColor = false;
            this.sheetLockBtn.Click += new System.EventHandler(this.sheetLockBtn_Click);
            // 
            // importWorkbookBtn
            // 
            this.importWorkbookBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.importWorkbookBtn.FlatAppearance.BorderSize = 0;
            this.importWorkbookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importWorkbookBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.importWorkbookBtn.Location = new System.Drawing.Point(523, 164);
            this.importWorkbookBtn.Name = "importWorkbookBtn";
            this.importWorkbookBtn.Size = new System.Drawing.Size(168, 50);
            this.importWorkbookBtn.TabIndex = 19;
            this.importWorkbookBtn.Text = "Arbeitsmappe importieren...";
            this.importWorkbookBtn.UseVisualStyleBackColor = false;
            this.importWorkbookBtn.Click += new System.EventHandler(this.importWorkbookBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(273, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Einfügen vor:";
            // 
            // copySheetBtn
            // 
            this.copySheetBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.copySheetBtn.FlatAppearance.BorderSize = 0;
            this.copySheetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copySheetBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.copySheetBtn.Location = new System.Drawing.Point(523, 85);
            this.copySheetBtn.Name = "copySheetBtn";
            this.copySheetBtn.Size = new System.Drawing.Size(168, 23);
            this.copySheetBtn.TabIndex = 20;
            this.copySheetBtn.Text = "Tabellenblatt kopieren";
            this.copySheetBtn.UseVisualStyleBackColor = false;
            this.copySheetBtn.Click += new System.EventHandler(this.copySheetBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(276, 52);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(168, 95);
            this.listBox1.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tabellenblatt auswählen:";
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.searchBox);
            this.panel4.Controls.Add(this.searchButton);
            this.panel4.Location = new System.Drawing.Point(179, 59);
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
            this.searchButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.ForeColor = System.Drawing.SystemColors.Window;
            this.searchButton.Location = new System.Drawing.Point(46, 34);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(66, 20);
            this.searchButton.TabIndex = 16;
            this.searchButton.Text = "🔍";
            this.searchButton.UseVisualStyleBackColor = false;
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
            this.panel3.Location = new System.Drawing.Point(343, 59);
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
            this.deleteButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.ForeColor = System.Drawing.SystemColors.Window;
            this.deleteButton.Location = new System.Drawing.Point(44, 113);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 25;
            this.deleteButton.Text = "Löschen";
            this.deleteButton.UseVisualStyleBackColor = false;
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
            this.radioButtonSearchVar.Location = new System.Drawing.Point(33, 59);
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
            this.radioButtonAreaDel.Location = new System.Drawing.Point(33, 92);
            this.radioButtonAreaDel.Name = "radioButtonAreaDel";
            this.radioButtonAreaDel.Size = new System.Drawing.Size(101, 17);
            this.radioButtonAreaDel.TabIndex = 1;
            this.radioButtonAreaDel.Text = "Bereich löschen";
            this.radioButtonAreaDel.UseVisualStyleBackColor = true;
            this.radioButtonAreaDel.CheckedChanged += new System.EventHandler(this.radioButtonAreaDel_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(81, 281);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(902, 344);
            this.dataGridView1.TabIndex = 19;
            // 
            // buttonSelectPnl
            // 
            this.buttonSelectPnl.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonSelectPnl.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.buttonSelectPnl.FlatAppearance.BorderSize = 0;
            this.buttonSelectPnl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectPnl.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonSelectPnl.Location = new System.Drawing.Point(0, 0);
            this.buttonSelectPnl.Name = "buttonSelectPnl";
            this.buttonSelectPnl.Size = new System.Drawing.Size(80, 60);
            this.buttonSelectPnl.TabIndex = 42;
            this.buttonSelectPnl.Text = "button2";
            this.buttonSelectPnl.UseVisualStyleBackColor = false;
            this.buttonSelectPnl.Click += new System.EventHandler(this.buttonSelectPnl_Click);
            // 
            // buttonEditPnl
            // 
            this.buttonEditPnl.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonEditPnl.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.buttonEditPnl.FlatAppearance.BorderSize = 0;
            this.buttonEditPnl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditPnl.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonEditPnl.Location = new System.Drawing.Point(0, 59);
            this.buttonEditPnl.Name = "buttonEditPnl";
            this.buttonEditPnl.Size = new System.Drawing.Size(80, 60);
            this.buttonEditPnl.TabIndex = 43;
            this.buttonEditPnl.Text = "button3";
            this.buttonEditPnl.UseVisualStyleBackColor = false;
            this.buttonEditPnl.Click += new System.EventHandler(this.buttonEditPnl_Click);
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.okButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.okButton.FlatAppearance.BorderSize = 0;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.ForeColor = System.Drawing.SystemColors.Window;
            this.okButton.Location = new System.Drawing.Point(0, 505);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(80, 60);
            this.okButton.TabIndex = 44;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Tomato;
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cancelButton.Location = new System.Drawing.Point(0, 564);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(80, 60);
            this.cancelButton.TabIndex = 45;
            this.cancelButton.Text = "Abbrechen";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // panelConture
            // 
            this.panelConture.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelConture.Controls.Add(this.buttonEditPnl);
            this.panelConture.Controls.Add(this.buttonSelectPnl);
            this.panelConture.Controls.Add(this.cancelButton);
            this.panelConture.Controls.Add(this.okButton);
            this.panelConture.Location = new System.Drawing.Point(0, 0);
            this.panelConture.Name = "panelConture";
            this.panelConture.Size = new System.Drawing.Size(80, 626);
            this.panelConture.TabIndex = 46;
            // 
            // panelSelect
            // 
            this.panelSelect.BackColor = System.Drawing.SystemColors.Window;
            this.panelSelect.Controls.Add(this.panel1);
            this.panelSelect.Controls.Add(this.dataNameLabelFrm1);
            this.panelSelect.Controls.Add(this.panel5);
            this.panelSelect.Controls.Add(this.label6);
            this.panelSelect.Controls.Add(this.sheetLockLabel);
            this.panelSelect.Controls.Add(this.listBox1);
            this.panelSelect.Controls.Add(this.moveSheetChkbx);
            this.panelSelect.Controls.Add(this.copySheetBtn);
            this.panelSelect.Controls.Add(this.sheetRadioBtn);
            this.panelSelect.Controls.Add(this.label7);
            this.panelSelect.Controls.Add(this.sheetLockBtn);
            this.panelSelect.Controls.Add(this.importWorkbookBtn);
            this.panelSelect.Location = new System.Drawing.Point(80, 0);
            this.panelSelect.Name = "panelSelect";
            this.panelSelect.Size = new System.Drawing.Size(902, 276);
            this.panelSelect.TabIndex = 47;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(33, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 21);
            this.panel1.TabIndex = 26;
            // 
            // panelEdit
            // 
            this.panelEdit.BackColor = System.Drawing.SystemColors.Window;
            this.panelEdit.Controls.Add(this.panel4);
            this.panelEdit.Controls.Add(this.panel3);
            this.panelEdit.Controls.Add(this.radioButtonSearchVar);
            this.panelEdit.Controls.Add(this.radioButtonAreaDel);
            this.panelEdit.Location = new System.Drawing.Point(80, 0);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(902, 276);
            this.panelEdit.TabIndex = 48;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(982, 625);
            this.Controls.Add(this.panelConture);
            this.Controls.Add(this.panelSelect);
            this.Controls.Add(this.panelEdit);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ExcelMachina";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelConture.ResumeLayout(false);
            this.panelSelect.ResumeLayout(false);
            this.panelSelect.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button buttonSelectPnl;
        private System.Windows.Forms.Button buttonEditPnl;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Panel panelConture;
        private System.Windows.Forms.Panel panelSelect;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Panel panel1;
    }
}

