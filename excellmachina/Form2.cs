using excellmachina;
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
using System.Diagnostics;

namespace excellmachina
{
    public partial class importForm : Form
    {
        public String sfName = "";
        public String fName { get; set; }
        public List<string> SheetNames { get; set; }
        private Form1 form1;
        public importForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1; //eventuell unnötig siehe form 4. Form is eine teilklasse der Form klasse
        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            //open file restrict to excel
            //OpenFileDialog openfialdialog1 = new OpenFileDialog();
            //Excel-Datein (*.xl*)|*.xl*

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fName = openFileDialog1.FileName;
                sfName = openFileDialog1.SafeFileName;
                DataNameLabel.Text = sfName;
            }
            
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkBook = xlApp.Workbooks.Open(fName);

            List<string> sheetList = new List<string>();
            foreach (Excel.Worksheet xlWorkSheet in xlWorkBook.Worksheets)
            {
                sheetList.Add(xlWorkSheet.Name);
            }

            // Bind the sheet names to the ListBox control
            listBox2.DataSource = sheetList;
            SheetNames = sheetList;

            // Close the Excel workbook and release resources
            xlWorkBook.Close(false);
            xlApp.Quit();


            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            //ButtonClicked?.Invoke(this, EventArgs.Empty);
            //Form1 form = new Form1();
            //form.Owner = this;
            //form.AddExcelSheet(fName, SheetNames);
            form1.Owner = this;
            form1.AddExcelSheet(fName, SheetNames);
        }

        private void cancelButtonF2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}

//initialize appliction with admin mode for win7/vista users to allow drag and drop
//public Form1()
//{
//    InitializeComponent();
//    this.AllowDrop = true;
//    this.DragEnter += new DragEventHandler(Form1_DragEnter);
//    this.DragDrop += new DragEventHandler(Form1_DragDrop);
//}

//void Form1_DragEnter(object sender, DragEventArgs e)
//{
//    if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
//}

//void Form1_DragDrop(object sender, DragEventArgs e)
//{
//    string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
//    foreach (string file in files) Console.WriteLine(file);
//}