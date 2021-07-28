using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WeatherStation.Graphs
{
    public partial class Weather_Graphs : Form
    {
        Point? prevPosition = null;
        ToolTip tooltip = new ToolTip();

        public Weather_Graphs()
        {
            InitializeComponent();
        }

        private void btn_close_weather_graph_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Image Files|*.png|Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|JPEG Image (.jpeg)|*.jpeg|Png Image (.png)|*.png|Tiff Image (.tiff)|*.tiff";
            saveFileDialog.Title = "Save Chart Image As file";
            saveFileDialog.DefaultExt = ".png";
            saveFileDialog.FileName = "Sample.png";

            DialogResult result = saveFileDialog.ShowDialog();
            saveFileDialog.RestoreDirectory = true;

            if (result == DialogResult.OK && saveFileDialog.FileName != "")
            {
                try
                {

                    var imgFormats = new Dictionary<string, ChartImageFormat>()
                    {
                        {".bmp", ChartImageFormat.Bmp},
                        {".gif", ChartImageFormat.Gif},
                        {".jpg", ChartImageFormat.Jpeg},
                        {".jpeg", ChartImageFormat.Jpeg},
                        {".png", ChartImageFormat.Png},
                        {".tiff", ChartImageFormat.Tiff},
                    };
                    var fileExt = System.IO.Path.GetExtension(saveFileDialog.FileName).ToString().ToLower();
                    if (imgFormats.ContainsKey(fileExt))
                    {
                        if (tabControl1.SelectedTab.Name == "tab_temp")
                        {
                            chart_temperature.SaveImage(saveFileDialog.FileName, imgFormats[fileExt]);
                        }
                        else if(tabControl1.SelectedTab.Name == "tab_humidity")
                        {
                            chart_humidity.SaveImage(saveFileDialog.FileName, imgFormats[fileExt]);
                        }
                        else if (tabControl1.SelectedTab.Name == "tab_air_pressure")
                        {
                            chart_air_pressure.SaveImage(saveFileDialog.FileName, imgFormats[fileExt]);
                        }
                    }
                    else
                    {
                        throw new Exception(String.Format("Only image formats '{0}' supported", string.Join(", ", imgFormats.Keys)));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
        private void chart_air_pressure_MouseMove(object sender, MouseEventArgs e)
        {
            var pos = e.Location;
            if (prevPosition.HasValue && pos == prevPosition.Value)
                return;
            tooltip.RemoveAll();
            prevPosition = pos;
            var results = chart_air_pressure.HitTest(pos.X, pos.Y, false, ChartElementType.DataPoint); // set ChartElementType.PlottingArea for full area, not only DataPoints
            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.DataPoint) // set ChartElementType.PlottingArea for full area, not only DataPoints
                {
                    var yVal = result.ChartArea.AxisY.PixelPositionToValue(pos.Y);
                    tooltip.Show(((int)yVal).ToString(), chart_air_pressure, pos.X, pos.Y - 15);
                }
            }
        }

        private void chart_humidity_MouseMove(object sender, MouseEventArgs e)
        {
            var pos = e.Location;
            if (prevPosition.HasValue && pos == prevPosition.Value)
                return;
            tooltip.RemoveAll();
            prevPosition = pos;
            var results = chart_humidity.HitTest(pos.X, pos.Y, false, ChartElementType.DataPoint); // set ChartElementType.PlottingArea for full area, not only DataPoints
            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.DataPoint) // set ChartElementType.PlottingArea for full area, not only DataPoints
                {
                    var yVal = result.ChartArea.AxisY.PixelPositionToValue(pos.Y);
                    tooltip.Show(((int)yVal).ToString(), chart_humidity, pos.X, pos.Y - 15);
                }
            }
        }

        private void chart_temperature_MouseMove(object sender, MouseEventArgs e)
        {
            var pos = e.Location;
            if (prevPosition.HasValue && pos == prevPosition.Value)
                return;
            tooltip.RemoveAll();
            prevPosition = pos;
            var results = chart_temperature.HitTest(pos.X, pos.Y, false, ChartElementType.DataPoint); // set ChartElementType.PlottingArea for full area, not only DataPoints
            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.DataPoint) // set ChartElementType.PlottingArea for full area, not only DataPoints
                {
                    var yVal = result.ChartArea.AxisY.PixelPositionToValue(pos.Y);
                    tooltip.Show(((int)yVal).ToString(), chart_temperature, pos.X, pos.Y - 15);
                }
            }
        }

        private void Weather_Graphs_Load(object sender, EventArgs e)
        {
            //chart_temperature
            chart_temperature.Series["iTemp"].ChartType = SeriesChartType.FastLine; //set type
            chart_temperature.Series["iTemp"].Color = Color.Chartreuse; //set colour
           
            chart_temperature.Series["oTemp"].ChartType = SeriesChartType.FastLine; //set type
            chart_temperature.Series["oTemp"].Color = Color.Orange; //set colour

            chart_temperature.Series["Max"].Color = Color.Red; //set colour
            chart_temperature.Series["Min"].Color = Color.Blue; //set colour
            chart_temperature.Series["aMax"].Color = Color.PaleVioletRed; //set colour
            chart_temperature.Series["aMin"].Color = Color.LightBlue; //set colour

            chart_temperature.Legends.Clear(); // We do not need a legend
            chart_temperature.ChartAreas[0].AxisX.IsMarginVisible = false;

            Series series_iTemp = chart_temperature.Series.Add("");

            // enable autoscroll, zoom etc only need do for one series on graph all others follow
            ChartArea ca_iTemp = chart_temperature.ChartAreas[series_iTemp.ChartArea]; // get hold of chart

            ca_iTemp.AxisX.ScaleView.Zoomable = true;
            ca_iTemp.CursorX.AutoScroll = true;
            ca_iTemp.CursorX.IsUserSelectionEnabled = true; //adds reset button on left
            ca_iTemp.AxisX.ScaleView.SmallScrollSize = 100;

            //----------------------------------------------------------------------------------
            //chart_humidity

            chart_humidity.Series["iHumid"].ChartType = SeriesChartType.FastLine; //set type
            chart_humidity.Series["iHumid"].Color = Color.Blue; //set colour
            
            chart_humidity.Series["oHumid"].ChartType = SeriesChartType.FastLine; //set type
            chart_humidity.Series["oHumid"].Color = Color.Red; //set colour

            chart_humidity.Legends.Clear(); // We do not need a legend
            chart_humidity.ChartAreas[0].AxisX.IsMarginVisible = false;

            Series series_oHumid = chart_humidity.Series.Add("");

            // enable autoscroll, zoom etc only need do for one series on graph all others follow
            ChartArea ca_iHumid = chart_humidity.ChartAreas[series_oHumid.ChartArea]; // get hold of chart

            ca_iHumid.AxisX.ScaleView.Zoomable = true;
            ca_iHumid.CursorX.AutoScroll = true;
            ca_iHumid.CursorX.IsUserSelectionEnabled = true; //adds reset button on left
            ca_iHumid.AxisX.ScaleView.SmallScrollSize = 100;

            //----------------------------------------------------------------------------------
            //chart_air_pressure
            chart_air_pressure.Series["Air Pressure"].ChartType = SeriesChartType.FastLine; //set type
            chart_air_pressure.Series["Air Pressure"].Color = Color.Chartreuse; //set colour
            

            chart_air_pressure.Series["Average"].ChartType = SeriesChartType.FastLine; //set type
            chart_air_pressure.Series["Average"].Color = Color.Purple; //set colour

            chart_air_pressure.Series["Max"].ChartType = SeriesChartType.FastLine; //set type
            chart_air_pressure.Series["Max"].Color = Color.Red; //set colour

            chart_air_pressure.Series["Min"].ChartType = SeriesChartType.FastLine; //set type
            chart_air_pressure.Series["Min"].Color = Color.Blue; //set colour

            chart_air_pressure.Legends.Clear(); // We do not need a legend
            chart_air_pressure.ChartAreas[0].AxisX.IsMarginVisible = false;

            chart_air_pressure.ChartAreas[0].AxisY.Maximum = 1055;
            chart_air_pressure.ChartAreas[0].AxisY.Minimum = 920;

            Series series_air_pressure = chart_air_pressure.Series.Add("");

            // enable autoscroll, zoom etc 
            ChartArea ca_air_pressure = chart_air_pressure.ChartAreas[series_air_pressure.ChartArea]; // get hold of chart

            ca_air_pressure.AxisX.ScaleView.Zoomable = true;
            ca_air_pressure.CursorX.AutoScroll = true;
            ca_air_pressure.CursorX.IsUserSelectionEnabled = true; //adds reset button on left
            ca_air_pressure.AxisX.ScaleView.SmallScrollSize = 100;
        }
    }
}
