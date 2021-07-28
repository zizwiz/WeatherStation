using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WeatherStation
{
    public partial class Form1
    {

        public void Populate_Environmental_Grid()
        {
            int num_rows = 0;
            int num_cols = 0;
            string short_date = "";

            int tim;
            int ilight;
            int isound;
            int dat; //date

            string[] headings;
            string[] uk_weather_data;

            string FileName = "data\\" + cmbobx_year.Text + "\\environment\\" + cmbobx_month.Text + ".csv";

            // Get the data.
            string[,] values = Load_vac_Csv(FileName);

            uk_weather_data = File.ReadAllLines(FileName);
            headings = Regex.Split(uk_weather_data[0], ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");

            dat = Array.IndexOf(headings, "Date");
            tim = Array.IndexOf(headings, "Time");
            ilight = Array.IndexOf(headings, "Light");
            isound = Array.IndexOf(headings, "Sound");


            num_rows = values.GetUpperBound(0) + 1;

            int value2 = 0;
            int value = 0;

            // Make column headers.
            // For this example, we assume the first row
            // contains the column names.
            dgv_environment.Columns.Clear();

            dgv_environment.Columns.Add("Date", "Date");
            dgv_environment.Columns["Date"].DefaultCellStyle.Format = "dd.MM.yyyy";
            dgv_environment.Columns["Date"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_environment.Columns["Date"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

            dgv_environment.Columns.Add("Time", "Time");
            dgv_environment.Columns["Time"].DefaultCellStyle.Format = "HH:mm:ss";
            dgv_environment.Columns["Time"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_environment.Columns["Time"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

            dgv_environment.Columns.Add("ilight", "Ambient Light");
            dgv_environment.Columns["ilight"].DefaultCellStyle.Format = "####0";
            dgv_environment.Columns["ilight"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_environment.Columns["ilight"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

            dgv_environment.Columns.Add("isound", "Ambient Sound");
            dgv_environment.Columns["isound"].DefaultCellStyle.Format = "######0";
            dgv_environment.Columns["isound"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_environment.Columns["isound"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

            // Add the data.
            for (int r = 1; r < num_rows; r++)
            {
                dgv_environment.Rows.Add();
                dgv_environment.Rows[r - 1].Cells[0].Value = values[r, dat]; //Date
                dgv_environment.Rows[r - 1].Cells[1].Value = values[r, tim]; //Time
                dgv_environment.Rows[r - 1].Cells[2].Value = values[r, ilight];
                dgv_environment.Rows[r - 1].Cells[3].Value = values[r, isound];
            }

            dgv_environment.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_environment.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_environment.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_environment.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            dgv_environment.FirstDisplayedScrollingRowIndex = dgv_environment.RowCount - 1;
            dgv_environment.RowHeadersVisible = false;

            //Turn off sorting
            foreach (DataGridViewColumn column in dgv_environment.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
    }
}
