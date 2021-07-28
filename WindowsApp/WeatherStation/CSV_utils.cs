using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WeatherStation
{
    public partial class Form1
    {
        // Load a CSV file into an array of rows and columns.
        // Assume there may be blank lines but every line has
        // the same number of fields.
        private string[,] Load_vac_Csv(string filename)
        {
            string whole_file = "";
            
            try
            {
                // Get the file's text.
                whole_file = File.ReadAllText(filename);
            }
            catch (Exception e)
            {
                MessageBox.Show("Check the file \"" + filename + "\" exists");

                if (filename.Contains("environment"))
                {
                    dgv_environment.Rows.Clear();
                    dgv_environment.Refresh();
                }
                else
                {
                    dgv_weather.Rows.Clear();
                    dgv_weather.Refresh();
                }
                
                throw;
            }
           

            // Split into lines.
                whole_file = whole_file.Replace('\n', '\r');
            string[] lines = whole_file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            // See how many rows and columns there are.
            int num_rows = lines.Length;
            int num_cols = (lines[0].Split(',').Length);

            // Allocate the data array.
            string[,] values = new string[num_rows, num_cols];

            // Load the array.
            for (int r = 0; r < num_rows; r++)
            {
                // string[] line_r = lines[r].Split(',');

                string[] line_r = Regex.Split(lines[r], ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");

                for (int c = 0; c < num_cols; c++)
                {
                    values[r, c] = line_r[c];

                }
            }
            // Return the values.
            return values;
        }

    }
}
