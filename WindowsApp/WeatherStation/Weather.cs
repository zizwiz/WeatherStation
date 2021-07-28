using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WeatherStation
{
    public partial class Form1
    {

        public void Populate_Weather_Grid()
        {
            int num_rows = 0;
            int num_cols = 0;
            string short_date = "";

            int tim;
            int itemp;
            int otemp;
            int pressure;
            int ihumid;
            int ohumid;
            int dat; //date

            string[] headings;
            string[] uk_weather_data;

            string FileName = "data\\" + cmbobx_year.Text + "\\" + cmbobx_month.Text + ".csv";

            // Get the data.
            string[,] values = Load_vac_Csv(FileName);

            uk_weather_data = File.ReadAllLines(FileName);
            headings = Regex.Split(uk_weather_data[0], ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");

            dat = Array.IndexOf(headings, "Date");
            tim = Array.IndexOf(headings, "Time");
            itemp = Array.IndexOf(headings, "ITemp");
            ihumid = Array.IndexOf(headings, "IHumidity");
            otemp = Array.IndexOf(headings, "OTemp");
            ohumid = Array.IndexOf(headings, "OHumidity");
            pressure = Array.IndexOf(headings, "Pressure");
            
            num_rows = values.GetUpperBound(0) + 1;

            int value2 = 0;
            int value = 0;

            // Make column headers.
            // For this example, we assume the first row
            // contains the column names.
            dgv_weather.Columns.Clear();
           
            dgv_weather.Columns.Add("Date", "Date");
            dgv_weather.Columns["Date"].DefaultCellStyle.Format = "dd.MM.yyyy";
            dgv_weather.Columns["Date"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_weather.Columns["Date"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

            dgv_weather.Columns.Add("Time", "Time");
            dgv_weather.Columns["Time"].DefaultCellStyle.Format = "HH:mm:ss";
            dgv_weather.Columns["Time"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_weather.Columns["Time"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

            dgv_weather.Columns.Add("iTemp", "Inside Temp");
            dgv_weather.Columns["iTemp"].DefaultCellStyle.Format = "#0.##";
            dgv_weather.Columns["iTemp"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_weather.Columns["iTemp"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

            dgv_weather.Columns.Add("iHumid", "Inside Humidity");
            dgv_weather.Columns["iHumid"].DefaultCellStyle.Format = "##0.##";
            dgv_weather.Columns["iHumid"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_weather.Columns["iHumid"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

            dgv_weather.Columns.Add("oTemp", "Outside Temp");
            dgv_weather.Columns["oTemp"].DefaultCellStyle.Format = "#0.##";
            dgv_weather.Columns["oTemp"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_weather.Columns["oTemp"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

            dgv_weather.Columns.Add("oHumid", "oHumidity");
            dgv_weather.Columns["oHumid"].DefaultCellStyle.Format = "##0.##";
            dgv_weather.Columns["oHumid"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_weather.Columns["oHumid"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

            dgv_weather.Columns.Add("Pressure", "Pressure");
            dgv_weather.Columns["Pressure"].DefaultCellStyle.Format = "###0.##";
            dgv_weather.Columns["Pressure"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_weather.Columns["Pressure"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

            // Add the data.
            for (int r = 1; r < num_rows; r++)
            {
                dgv_weather.Rows.Add();
                dgv_weather.Rows[r-1].Cells[0].Value = values[r, dat]; //Date
                dgv_weather.Rows[r-1].Cells[1].Value = values[r, tim]; //Time
                dgv_weather.Rows[r-1].Cells[2].Value = values[r, itemp];
                dgv_weather.Rows[r-1].Cells[3].Value = values[r, ihumid];
                dgv_weather.Rows[r-1].Cells[4].Value = values[r, otemp];
                dgv_weather.Rows[r-1].Cells[5].Value = values[r, ohumid];
                dgv_weather.Rows[r-1].Cells[6].Value = values[r, pressure];

            }

            dgv_weather.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_weather.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_weather.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_weather.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_weather.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_weather.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_weather.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgv_weather.FirstDisplayedScrollingRowIndex = dgv_weather.RowCount - 1;
            dgv_weather.RowHeadersVisible = false;

            //Turn off sorting
            foreach (DataGridViewColumn column in dgv_weather.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
    }
}
