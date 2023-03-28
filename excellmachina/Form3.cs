using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace excellmachina
{
    public partial class editValueForm : Form
    {
        public string SearchValue { get; set; }
        public string excelFilePath { get; set; }
        private Form1 form;
        
        private Excel.Application xlApp;
        private Excel.Workbook xlWorkBook;


        public editValueForm(Form1 form1)
        {
            InitializeComponent();
            this.form = form1;
        }

        private void editValueForm_Load(object sender, EventArgs e)
        {
            try
            {
                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Open(excelFilePath);

                Excel.Range currentFind = null;
                Excel.Range firstFind = null;

                Excel.Range Fruits = xlApp.Cells;
                
                currentFind = Fruits.Find(What: SearchValue, LookIn: XlFindLookIn.xlValues, LookAt: XlLookAt.xlPart,
                    SearchOrder: XlSearchOrder.xlByRows, SearchDirection: XlSearchDirection.xlNext, MatchCase: false);

                if (currentFind != null)
                {
                    firstFind = currentFind;
                    label2.Text = "Found at " + currentFind.Worksheet.Name + "\ncolumn - " + currentFind.Column +
                        "\nrow - " + currentFind.Row;
                }
                else
                {
                    label2.Text = "nothing found";
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        
        private void buttonNext_Click(object sender, EventArgs e)
        {
            //empty
        }


        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            //empty
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            xlWorkBook.Close(false);
            xlApp.Quit();
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);
        }
    }
}
