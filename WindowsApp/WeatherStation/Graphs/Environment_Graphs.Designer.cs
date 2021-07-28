namespace WeatherStation.Graphs
{
    partial class Environment_Graphs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Environment_Graphs));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_save_environmental_graph = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_close_environmental_graph = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabcntrl_environmental = new System.Windows.Forms.TabControl();
            this.tab_alight = new System.Windows.Forms.TabPage();
            this.tab_asound = new System.Windows.Forms.TabPage();
            this.chart_light = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_sound = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabcntrl_environmental.SuspendLayout();
            this.tab_alight.SuspendLayout();
            this.tab_asound.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_light)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_sound)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(812, 524);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 472);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 49);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(806, 49);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_save_environmental_graph);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(397, 43);
            this.panel3.TabIndex = 0;
            // 
            // btn_save_environmental_graph
            // 
            this.btn_save_environmental_graph.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save_environmental_graph.Location = new System.Drawing.Point(152, 2);
            this.btn_save_environmental_graph.Name = "btn_save_environmental_graph";
            this.btn_save_environmental_graph.Size = new System.Drawing.Size(93, 39);
            this.btn_save_environmental_graph.TabIndex = 0;
            this.btn_save_environmental_graph.Text = "Save";
            this.btn_save_environmental_graph.UseVisualStyleBackColor = true;
            this.btn_save_environmental_graph.Click += new System.EventHandler(this.btn_save_environmental_graph_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_close_environmental_graph);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(406, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(397, 43);
            this.panel4.TabIndex = 1;
            // 
            // btn_close_environmental_graph
            // 
            this.btn_close_environmental_graph.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close_environmental_graph.Location = new System.Drawing.Point(152, 2);
            this.btn_close_environmental_graph.Name = "btn_close_environmental_graph";
            this.btn_close_environmental_graph.Size = new System.Drawing.Size(93, 39);
            this.btn_close_environmental_graph.TabIndex = 1;
            this.btn_close_environmental_graph.Text = "Exit";
            this.btn_close_environmental_graph.UseVisualStyleBackColor = true;
            this.btn_close_environmental_graph.Click += new System.EventHandler(this.btn_close_environmental_graph_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabcntrl_environmental);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(806, 463);
            this.panel2.TabIndex = 1;
            // 
            // tabcntrl_environmental
            // 
            this.tabcntrl_environmental.Controls.Add(this.tab_alight);
            this.tabcntrl_environmental.Controls.Add(this.tab_asound);
            this.tabcntrl_environmental.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcntrl_environmental.Location = new System.Drawing.Point(0, 0);
            this.tabcntrl_environmental.Name = "tabcntrl_environmental";
            this.tabcntrl_environmental.SelectedIndex = 0;
            this.tabcntrl_environmental.Size = new System.Drawing.Size(806, 463);
            this.tabcntrl_environmental.TabIndex = 0;
            // 
            // tab_alight
            // 
            this.tab_alight.Controls.Add(this.chart_light);
            this.tab_alight.Location = new System.Drawing.Point(4, 25);
            this.tab_alight.Name = "tab_alight";
            this.tab_alight.Size = new System.Drawing.Size(798, 434);
            this.tab_alight.TabIndex = 0;
            this.tab_alight.Text = "Ambient Light";
            this.tab_alight.UseVisualStyleBackColor = true;
            // 
            // tab_asound
            // 
            this.tab_asound.Controls.Add(this.chart_sound);
            this.tab_asound.Location = new System.Drawing.Point(4, 25);
            this.tab_asound.Name = "tab_asound";
            this.tab_asound.Size = new System.Drawing.Size(798, 434);
            this.tab_asound.TabIndex = 1;
            this.tab_asound.Text = "Ambient Sound";
            this.tab_asound.UseVisualStyleBackColor = true;
            // 
            // chart_light
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_light.ChartAreas.Add(chartArea1);
            this.chart_light.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart_light.Legends.Add(legend1);
            this.chart_light.Location = new System.Drawing.Point(0, 0);
            this.chart_light.Name = "chart_light";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "Series_light";
            this.chart_light.Series.Add(series1);
            this.chart_light.Size = new System.Drawing.Size(798, 434);
            this.chart_light.TabIndex = 0;
            this.chart_light.Text = "chart1";
            this.chart_light.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart_light_MouseMove);
            // 
            // chart_sound
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_sound.ChartAreas.Add(chartArea2);
            this.chart_sound.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart_sound.Legends.Add(legend2);
            this.chart_sound.Location = new System.Drawing.Point(0, 0);
            this.chart_sound.Name = "chart_sound";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.Name = "Series_sound";
            this.chart_sound.Series.Add(series2);
            this.chart_sound.Size = new System.Drawing.Size(798, 434);
            this.chart_sound.TabIndex = 0;
            this.chart_sound.Text = "chart1";
            this.chart_sound.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart_sound_MouseMove);
            // 
            // Environment_Graphs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 524);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Environment_Graphs";
            this.Text = "Environment_Graphs";
            this.Load += new System.EventHandler(this.Environment_Graphs_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabcntrl_environmental.ResumeLayout(false);
            this.tab_alight.ResumeLayout(false);
            this.tab_asound.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_light)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_sound)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_save_environmental_graph;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_close_environmental_graph;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabcntrl_environmental;
        private System.Windows.Forms.TabPage tab_alight;
        private System.Windows.Forms.TabPage tab_asound;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart_light;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart_sound;
    }
}