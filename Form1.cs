using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpreadsheetApp
{
    public partial class Form1 : Form
    {
        private ShareableSpreadSheet sheet;

        public Form1()
        {
            InitializeComponent();
        }

        private void create_Click(object sender, EventArgs e)
        {
            try
            {
                int row = Int32.Parse(rowCreate.Text);
                int col = Int32.Parse(colCreate.Text);

                if (row < 1 || col < 1)
                {
                    Result.Text = "Try Again!";
                    return;
                }

                sheet = new ShareableSpreadSheet(row, col);

                if (sheet == null)
                    Result.Text = "Fail";
                show();

                Result.Text = "Success";
            }
            catch (Exception e1)
            {
                Console.WriteLine(e.ToString());
                Result.Text = "Try Again!";
                return;
            }
        }

        private void show()
        {
            int r1 = 0;
            int c1 = 0;
            sheet.getSize(ref r1, ref c1);

            DataTable table = new DataTable();
            dataGridView1.DataSource = table;

            table.Columns.Add("Row / Col ", typeof(string));
            for (int i = 1; i < c1 + 1; i++)
            {
                table.Columns.Add(i.ToString(), typeof(string));
            }

            for (int i = 1; i < r1 + 1; i++)
            {
                DataRow dr = table.NewRow();
                dr[0] = i;
                for (int j = 1; j < c1 + 1; j++)
                {
                    dr[j] = sheet.getCell(i, j);
                }
                table.Rows.Add(dr);
            }
        }

        private void load_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "dat |*.dat";

            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            openFileDialog1.InitialDirectory = appPath;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog1.SafeFileName;
                nameToLoad.Text = file;
            }
            try
            {
                if (sheet == null)
                    Result.Text = "First create sheet";
                else
                {
                    bool b = sheet.load(nameToLoad.Text);
                    if (b)
                    {
                        Result.Text = "Success";
                        show();
                    }
                    else
                        Result.Text = "Fail";
                }
            }
            catch (Exception e1)
            {
                Result.Text = "Try Again!";
                return;
            }
        }

        private void nameToLoad_TextChanged(object sender, EventArgs e)
        {

        }

        private void returnLoad_Click(object sender, EventArgs e)
        {

        }

        private void addRow_Click(object sender, EventArgs e)
        {
            try
            {
                bool b = false;
                int row = Int32.Parse(addRowAt.Text);
                if (row < 1)
                {
                    Result.Text = "Try Again!";
                    return;
                }

                if (sheet == null)
                {
                    Result.Text = "First create sheet";
                    return;
                }
                else
                {
                    b = sheet.addRow(row);
                    if (!b)
                        Result.Text = "Fail";
                    else
                    {
                        show();
                        Result.Text = "Success";
                    }
                }
            }
            catch (Exception e1)
            {
                Result.Text = "Try Again!";
                return;
            }
        }

        private void addCol_Click(object sender, EventArgs e)
        {
            try
            {
                bool b = false;
                int col = Int32.Parse(addColAt.Text);
                if (col < 1)
                {
                    Result.Text = "Try Again!";
                    return;
                }

                if (sheet == null)
                {
                    Result.Text = "First create sheet";
                    return;
                }
                else
                {
                    b = sheet.addCol(col);
                    if (!b)
                        Result.Text = "Fail";
                    else
                    {
                        show();
                        Result.Text = "Success";
                    }
                }
            }
            catch (Exception e1)
            {
                Result.Text = "Try Again!";
                return;
            }
        }

        private void addColAt_TextChanged(object sender, EventArgs e)
        {

        }


        private void searchRange_Click(object sender, EventArgs e)
        {
            try
            {
                int row1 = Int32.Parse(searchRow1.Text);
                int col1 = Int32.Parse(searchCol1.Text);
                int row2 = Int32.Parse(searchRow2.Text);
                int col2 = Int32.Parse(searchCol2.Text);
                string str = stringToSearch.Text;

                if (sheet == null)
                {
                    Result.Text = "First create sheet";
                    return;
                }
                if (row1 < 1 || col1 < 1 || row2 < 1 || col2 < 1)
                {
                    Result.Text = "Try Again!";
                    return;
                }
                int r1 = 0, r2 = 0;
                //int col1, int col2, int row1, int row2, String str, ref int row, ref int col
                bool b = sheet.searchInRange(col1, col2, row1, row2, str, ref r1, ref r2);
                if (!b)
                {
                    SearchResult.Text = "Not Found..";
                    return;
                }
                SearchResult.Text = r1 + "," + r2;
            }
            catch (Exception e1)
            {
                Result.Text = "Try Again!";
                return;
            }
        }

        private void searchCol1_TextChanged(object sender, EventArgs e)
        {

        }

        private void colCreate_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void stringToSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            string name = filetoSave.Text;
            if (sheet == null)
            {
                Result.Text = "First create sheet";
                return;
            }
            sheet.save(name+ ".dat");
            Result.Text = "Success";
        }


    }
}
