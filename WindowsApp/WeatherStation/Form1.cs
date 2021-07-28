using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WeatherStation.Graphs;

namespace WeatherStation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            FillYearComboBox();

            //  Populate_Weather_Grid();

        }


        // search data folder and put all the folder names into sorted combobox
        void FillYearComboBox()
        {
            // fill the combobox with entries
            cmbobx_year.Items.Clear();
            cmbobx_month.Items.Clear();

            try
            {
                //gets dir with its path 
                String[] dirs = Directory.GetDirectories(@"data\");

                foreach (string d in dirs)
                {
                    //remove path then populate combobox.
                    int StartIndex = (d.IndexOf('\\') + 1);
                    cmbobx_year.Items.Add(d.Substring(StartIndex, (d.Length) - StartIndex));
                }

                cmbobx_year.SelectedIndex = (cmbobx_year.Items.Count) - 1; //Start with most recent year

                FillMonthComboBox("data\\" + cmbobx_year.Text);
            }
            catch
            {
                //do nothing as no folder exists
            }
        }

        void FillMonthComboBox(string year)
        {
            // fill the combobox with entries
            cmbobx_month.Items.Clear();


            DirectoryInfo dir = new System.IO.DirectoryInfo(year);
            string[] MonthName = new string[dir.GetFiles().Length];
            int counter = 0;

            try
            {

                DirectoryInfo d = new DirectoryInfo(year); //go to the directory

                FileInfo[] Files = d.GetFiles("*.csv"); //Getting csv files

                foreach (FileInfo file in Files)
                {
                    // put the list of file names into array so we can sort into month order
                    MonthName[counter] = Path.GetFileNameWithoutExtension(file.Name);
                    counter++;
                }

                SortMonth(MonthName);
            }
            catch
            {
                //do nothing as no folder exists
            }
        }

        //Sort the months into month order rather than alphabetical order and select month before
        void SortMonth(string[] MonthName)
        {
            var sortedMonths = MonthName
                .Select(x => new { Name = x, Sort = DateTime.ParseExact(x, "MMMM", CultureInfo.InvariantCulture) })
                .OrderBy(x => x.Sort.Month)
                .Select(x => x.Name)
                .ToArray();

            for (int i = 0; i < MonthName.Length; i++)
            {
                //put month names into combobox
                cmbobx_month.Items.Add(sortedMonths[i]);
            }

            // If this year then Get the last full month and select it in combobox.
            // If not then select index 0
            
            string PreviousMonth = DateTime.Now.AddMonths(-1).ToString("MMMM", CultureInfo.InvariantCulture);
            
            if (cmbobx_month.Items.Contains(PreviousMonth))
            {
                try
                {
                    cmbobx_month.SelectedIndex = cmbobx_month.Items.IndexOf(PreviousMonth);
                }
                catch (Exception e)
                {
                    cmbobx_month.SelectedIndex = 0;
                }
            }
            else
            {
                cmbobx_month.SelectedIndex = 0;
            }


            Populate_Weather_Grid();
            Populate_Environmental_Grid();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbobx_year_SelectedIndexChanged(object sender, EventArgs e)
         {
             cmbobx_month.Items.Clear();
             FillMonthComboBox("data\\" + cmbobx_year.Text);
         }

         private void cmbobx_month_SelectedIndexChanged(object sender, EventArgs e)
         {
             Populate_Weather_Grid();
             Populate_Environmental_Grid();
         }

        private void btn_show_weather_graphs_Click(object sender, EventArgs e)
        {
            var G1 = new Weather_Graphs();
            int counter = 0;
            int num_rows = 0;
            double data = 0;


           foreach (DataGridViewRow row in dgv_weather.Rows)
           {
                //[Chart Series] DGV[column name]

               G1.chart_temperature.Series["iTemp"].Points.Add(Convert.ToDouble(dgv_weather["iTemp", counter].Value));
               G1.chart_temperature.Series["oTemp"].Points.Add(Convert.ToDouble(dgv_weather["oTemp", counter].Value));
               G1.chart_temperature.Series["Max"].Points.Add(38.7);
               G1.chart_temperature.Series["Min"].Points.Add(-17.2);
               G1.chart_temperature.Series["aMax"].Points.Add(15);
               G1.chart_temperature.Series["aMin"].Points.Add(6.3);


                G1.chart_humidity.Series["iHumid"].Points.Add(Convert.ToDouble(dgv_weather["iHumid", counter].Value));
               G1.chart_humidity.Series["oHumid"].Points.Add(Convert.ToDouble(dgv_weather["oHumid", counter].Value));

               G1.chart_air_pressure.Series["Air Pressure"].Points.Add(Convert.ToDouble(dgv_weather["pressure", counter].Value));
               G1.chart_air_pressure.Series["Max"].Points.Add(1053.6);
               G1.chart_air_pressure.Series["Average"].Points.Add(1013.25);
               G1.chart_air_pressure.Series["Min"].Points.Add(925.6);


                counter++;
            }
           
            G1.ShowDialog();
        }

        private void btn_show_environmental_graphs_Click(object sender, EventArgs e)
        {
            var G2 = new Environment_Graphs();
            int counter = 0;
            int num_rows = 0;
            double data = 0;


            foreach (DataGridViewRow row in dgv_environment.Rows)
            {
                //[Chart Series] DGV[column name]

                G2.chart_light.Series["Series_light"].Points.Add(Convert.ToDouble(dgv_environment["iLight", counter].Value));
                G2.chart_sound.Series["Series_sound"].Points.Add(Convert.ToDouble(dgv_environment["iSound", counter].Value));

                counter++;
            }

            G2.ShowDialog();
        }
    }
}
