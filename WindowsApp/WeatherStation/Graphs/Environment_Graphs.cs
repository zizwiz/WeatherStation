using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WeatherStation.Graphs
{
    public partial class Environment_Graphs : Form
    {
        Point? prevPosition = null;
        ToolTip tooltip = new ToolTip();

        public Environment_Graphs()
        {
            InitializeComponent();
        }

        
        private void btn_close_environmental_graph_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Environment_Graphs_Load(object sender, EventArgs e)
        {
            //----------------------------------------------------------------------------------
            //chart_light

            chart_light.Series["Series_light"].Color = Color.Blue; //set colour
            
            chart_light.Legends.Clear(); // We do not need a legend
            chart_light.ChartAreas[0].AxisX.IsMarginVisible = false;

            Series series_light = chart_light.Series.Add("");

            // enable autoscroll, zoom etc 
            ChartArea ca_light = chart_light.ChartAreas[series_light.ChartArea]; // get hold of chart

            ca_light.AxisX.ScaleView.Zoomable = true;
            ca_light.CursorX.AutoScroll = true;
            ca_light.CursorX.IsUserSelectionEnabled = true; //adds reset button on left
            ca_light.AxisX.ScaleView.SmallScrollSize = 100;

            //----------------------------------------------------------------------------------
            //chart_sound

            chart_sound.Series["Series_sound"].Color = Color.Red; //set colour

            chart_sound.Legends.Clear(); // We do not need a legend
            chart_sound.ChartAreas[0].AxisX.IsMarginVisible = false;

            Series series_sound = chart_sound.Series.Add("");

            // enable autoscroll, zoom etc 
            ChartArea ca_sound = chart_sound.ChartAreas[series_sound.ChartArea]; // get hold of chart

            ca_sound.AxisX.ScaleView.Zoomable = true;
            ca_sound.CursorX.AutoScroll = true;
            ca_sound.CursorX.IsUserSelectionEnabled = true; //adds reset button on left
            ca_sound.AxisX.ScaleView.SmallScrollSize = 100;
        }

        private void btn_save_environmental_graph_Click(object sender, EventArgs e)
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
                        if (tabcntrl_environmental.SelectedTab.Name == "tab_alight")
                        {
                            chart_light.SaveImage(saveFileDialog.FileName, imgFormats[fileExt]);
                        }
                        else if (tabcntrl_environmental.SelectedTab.Name == "tab_asound")
                        {
                            chart_sound.SaveImage(saveFileDialog.FileName, imgFormats[fileExt]);
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

        private void chart_sound_MouseMove(object sender, MouseEventArgs e)
        {
            var pos = e.Location;
            if (prevPosition.HasValue && pos == prevPosition.Value)
                return;
            tooltip.RemoveAll();
            prevPosition = pos;
            var results = chart_sound.HitTest(pos.X, pos.Y, false, ChartElementType.DataPoint); // set ChartElementType.PlottingArea for full area, not only DataPoints
            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.DataPoint) // set ChartElementType.PlottingArea for full area, not only DataPoints
                {
                    var yVal = result.ChartArea.AxisY.PixelPositionToValue(pos.Y);
                    tooltip.Show(((int)yVal).ToString(), chart_sound, pos.X, pos.Y - 15);
                }
            }
        }

        private void chart_light_MouseMove(object sender, MouseEventArgs e)
        {
            var pos = e.Location;
            if (prevPosition.HasValue && pos == prevPosition.Value)
                return;
            tooltip.RemoveAll();
            prevPosition = pos;
            var results = chart_light.HitTest(pos.X, pos.Y, false, ChartElementType.DataPoint); // set ChartElementType.PlottingArea for full area, not only DataPoints
            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.DataPoint) // set ChartElementType.PlottingArea for full area, not only DataPoints
                {
                    var yVal = result.ChartArea.AxisY.PixelPositionToValue(pos.Y);
                    tooltip.Show(((int)yVal).ToString(), chart_light, pos.X, pos.Y - 15);
                }
            }
        }
    }
}
