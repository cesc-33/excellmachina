using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using Microsoft.Office.Tools.Excel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace excellmachina
{
    public partial class Form1 : Form
    {
        importForm impForm;
        private string excelFilePath = "";
        private bool sheetProtection = false;
        private bool moveSheetCheck = false;
        private List<string> sheetList = new List<string>();
        private List<string> sheetList2 = new List<string>();

        Excel.Application xlApp;
        Excel.Workbook xlWorkBook;
        Excel.Worksheet xlWorkSheet;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //adding the events to the same eventhandler
            radioButtonSheetDelete.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            radioButtonNewSheet.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            radioButtonTemplate.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
        }

        //Import data from excel and display on grid
        private void Excel2Grid(int boxIndex)
        {
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(excelFilePath);               //Open excel file
            xlWorkSheet = xlWorkBook.Worksheets[boxIndex];          //Sheet with data


            if (xlWorkSheet.ProtectContents || xlWorkBook.ProtectStructure || xlWorkSheet.ProtectDrawingObjects || xlWorkSheet.ProtectScenarios)
            {
                sheetLockLabel.Text = "Blatt ist geschützt";
                if (sheetProtection)
                {
                    xlWorkSheet.Unprotect();
                    sheetLockLabel.Text = "Blatt ist ungeschützt";
                    sheetProtection = false;
                    xlWorkBook.Save();
                }
            }
            else
            {
                sheetLockLabel.Text = "Blatt ist ungeschützt";
                if (sheetProtection)
                {
                    xlWorkSheet.Protect();
                    sheetLockLabel.Text = "Blatt ist geschützt";
                    sheetProtection = false;
                    xlWorkBook.Save();
                }
            }

            DataTable dataTable = new DataTable();
            Excel.Range xlRange = xlWorkSheet.UsedRange;

            //Add columns to the DataTable
            for (int col = 1; col <= xlRange.Columns.Count + 1; col++)
            {
                if (xlRange.Cells[1, col].Value != null)
                {
                    dataTable.Columns.Add(xlRange.Cells[1, col].Value.ToString());
                }
                else
                {
                    dataTable.Columns.Add("Column " + col);
                }
            }

            //Add rows to the DataTable
            for (int row = 2; row <= xlRange.Rows.Count; row++)
            {
                DataRow dataRow = dataTable.NewRow();
                for (int col = 1; col <= xlRange.Columns.Count; col++)
                {
                    if (xlRange.Cells[row, col].Value != null)
                    {
                        dataRow[col - 1] = xlRange.Cells[row, col].Value.ToString();
                    }
                    else
                    {
                        dataRow[col - 1] = "";
                    }
                }
                dataTable.Rows.Add(dataRow);
            }

            //Set the DataGridView's DataSource to the DataTable
            dataGridView1.DataSource = dataTable;

            //Close the Excel workbook and release resources
            xlWorkBook.Close(false);
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);
        }

        //This method is used to refresh the sheet lists in the comboBox and ListBox items
        private void refreshSheetList()
        {
            comboBox1.SelectedIndexChanged -= comboBox1_SelectedIndexChanged;
            comboBox1.DataSource = null;
            listBox1.DataSource = null;
            comboBox1.Items.Clear();
            listBox1.Items.Clear();
            sheetList.Clear();
            sheetList2.Clear();

            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkBook = xlApp.Workbooks.Open(excelFilePath);

            foreach (Excel.Worksheet sheet in xlWorkBook.Worksheets)
            {
                sheetList.Add(sheet.Name);
                sheetList2.Add(sheet.Name);
            }

            comboBox1.DataSource = sheetList;
            listBox1.DataSource = sheetList2;

            //Close the Excel workbook and release resources
            xlWorkBook.Close(false);
            xlApp.Quit();


            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }
        private void importWorkbookBtn_Click(object sender, EventArgs e)
        {
            impForm = new importForm(this);
            impForm.ShowDialog();
        }
        public void AddExcelSheet(string filePath, List<string> importedSheetList)
        {
            sheetList.Clear();
            sheetList2.Clear();
            foreach (var item in importedSheetList)
            {
                sheetList.Add(item);
                sheetList2.Add(item);
            }
            comboBox1.DataSource = sheetList;
            listBox1.DataSource = sheetList2;
            dataNameLabelFrm1.Text = (filePath == "") ? "Dateiname" : filePath;
            excelFilePath = filePath;
            Excel2Grid(comboBox1.SelectedIndex + 1);
        }

        private void radioButtonSearchVar_CheckedChanged(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = true;
        }

        private void radioButtonAreaDel_CheckedChanged(object sender, EventArgs e)
        {
            panel3.Location = new Point(159);
            panel3.Visible = true;
            panel4.Visible = false;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Excel2Grid(comboBox1.SelectedIndex + 1);
        }

        private void sheetLockBtn_Click(object sender, EventArgs e)
        {
            if (sheetProtection == false)
            {
                sheetProtection = true;
                Excel2Grid(comboBox1.SelectedIndex + 1);
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Determine which RadioButton was checked and take appropriate actions
            if (radioButtonSheetDelete.Checked)
            {
                sheetRadioBtn.Text = radioButtonSheetDelete.Text;
            }
            else if (radioButtonNewSheet.Checked)
            {
                sheetRadioBtn.Text = radioButtonNewSheet.Text;
            }
            else if (radioButtonTemplate.Checked)
            {
                sheetRadioBtn.Text = radioButtonTemplate.Text;
            }
        }

        private void moveSheetChkbx_CheckedChanged(object sender, EventArgs e)
        {
            if (moveSheetChkbx.Checked)
            {
                copySheetBtn.Text = moveSheetChkbx.Text;
                moveSheetCheck = true;
            }
            else
            {
                copySheetBtn.Text = "Tabellenblatt kopieren";
                moveSheetCheck = false;
            }
        }

        private void copySheetBtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Open(excelFilePath);
                xlWorkSheet = xlWorkBook.Sheets[comboBox1.SelectedItem];
                if (moveSheetCheck)
                {
                    xlWorkSheet.Move(After: xlWorkBook.Sheets[listBox1.SelectedItem]);
                }
                else
                {
                    xlWorkSheet.Copy(After: xlWorkBook.Sheets[listBox1.SelectedItem]);
                }
                xlWorkBook.Save();
            }
            catch (Exception exept)
            {
                MessageBox.Show(exept.Message);
            }
            finally
            {
                //Close the Excel workbook and release resources
                xlWorkBook.Close();
                xlApp.Quit();
                Marshal.ReleaseComObject(xlWorkSheet);
                Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(xlApp);
                refreshSheetList(); //Excel2Grid(comboBox1.SelectedIndex + 1); // hier refreshlist anstatt excel2grid*****************
            }
        }

        private void sheetRadioBtn_Click(object sender, EventArgs e)
        {
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(excelFilePath);
            xlWorkSheet = xlWorkBook.Sheets[comboBox1.SelectedItem];

            xlApp.DisplayAlerts = false; //Turn off excel's permission asking

            if (radioButtonSheetDelete.Checked)
            {
                xlWorkSheet.Delete();
            }
            else if (radioButtonNewSheet.Checked)
            {
                Excel.Worksheet xlNewSheet = xlWorkBook.Sheets.Add(After: xlWorkBook.Sheets[listBox1.SelectedItem]);
                InputDialogBox inputBox = new InputDialogBox();
                if (inputBox.ShowDialog() == DialogResult.OK)
                {
                    xlNewSheet.Name = inputBox.InputText;
                }
                else
                {
                    xlNewSheet.Name = "Tabellenblatt " + xlWorkBook.Sheets.Count.ToString();
                }
            }
            else if (radioButtonTemplate.Checked)
            {

                Excel.Worksheet recentlySheet = null;
                xlWorkSheet.Copy(After: xlWorkBook.Sheets[listBox1.SelectedItem]);

                try
                {
                    recentlySheet = xlWorkBook.Sheets[listBox1.SelectedIndex + 2];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                //Delete the contents of the copied worksheet
                Excel.Range range = recentlySheet.UsedRange;
                range.Cells.ClearContents();
                
            }
            else
            {
                MessageBox.Show("EventHandler Error!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            xlApp.DisplayAlerts = true;

            
            xlWorkBook.Save();

            //Close the Excel workbook and release resources
            xlWorkBook.Close();
            xlApp.Quit();
            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);
            
            refreshSheetList();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            editValueForm editValForm = new editValueForm(this);
            editValForm.SearchValue = searchBox.Text;
            editValForm.excelFilePath = excelFilePath;
            editValForm.ShowDialog();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Programm beenden?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (xlWorkBook != null && xlApp != null)
                {
                    xlWorkBook.Close(false);
                    xlApp.Quit();
                    Marshal.ReleaseComObject(xlWorkSheet);
                    Marshal.ReleaseComObject(xlWorkBook);
                    Marshal.ReleaseComObject(xlApp);
                }
                //Release all running instances of Excel
                System.Diagnostics.Process[] procs = System.Diagnostics.Process.GetProcessesByName("EXCEL");
                foreach (System.Diagnostics.Process proc in procs)
                {
                    proc.Kill();
                }
                Application.Exit();
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Speichern und beenden?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (xlWorkBook != null && xlApp != null)
                {
                    xlWorkBook.Save();
                    xlWorkBook.Close();
                    xlApp.Quit();
                    Marshal.ReleaseComObject(xlWorkSheet);
                    Marshal.ReleaseComObject(xlWorkBook);
                    Marshal.ReleaseComObject(xlApp);
                }
                //Release all running instances of Excel
                System.Diagnostics.Process[] procs = System.Diagnostics.Process.GetProcessesByName("EXCEL");
                foreach (System.Diagnostics.Process proc in procs)
                {
                    proc.Kill();
                }
                Application.Exit();
            }
        }
    }
}