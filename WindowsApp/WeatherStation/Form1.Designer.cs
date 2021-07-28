namespace WeatherStation
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_exit = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.cmbobx_year = new System.Windows.Forms.ComboBox();
            this.panel21 = new System.Windows.Forms.Panel();
            this.cmbobx_month = new System.Windows.Forms.ComboBox();
            this.panel22 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.btn_show_weather_graphs = new System.Windows.Forms.Button();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_weather = new System.Windows.Forms.TabPage();
            this.dgv_weather = new System.Windows.Forms.DataGridView();
            this.tab_environmental = new System.Windows.Forms.TabPage();
            this.dgv_environment = new System.Windows.Forms.DataGridView();
            this.btn_show_environmental_graphs = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel21.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel19.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_weather.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_weather)).BeginInit();
            this.tab_environmental.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_environment)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.Location = new System.Drawing.Point(230, 1);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 39);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel8, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel19, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(926, 542);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.tableLayoutPanel5);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(920, 49);
            this.panel8.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel5.Controls.Add(this.panel20, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.panel21, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.panel22, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(920, 49);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.cmbobx_year);
            this.panel20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel20.Location = new System.Drawing.Point(3, 3);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(297, 43);
            this.panel20.TabIndex = 0;
            // 
            // cmbobx_year
            // 
            this.cmbobx_year.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbobx_year.FormattingEnabled = true;
            this.cmbobx_year.Location = new System.Drawing.Point(70, 6);
            this.cmbobx_year.Name = "cmbobx_year";
            this.cmbobx_year.Size = new System.Drawing.Size(172, 24);
            this.cmbobx_year.Sorted = true;
            this.cmbobx_year.TabIndex = 0;
            this.cmbobx_year.SelectedIndexChanged += new System.EventHandler(this.cmbobx_year_SelectedIndexChanged);
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.cmbobx_month);
            this.panel21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel21.Location = new System.Drawing.Point(306, 3);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(297, 43);
            this.panel21.TabIndex = 1;
            // 
            // cmbobx_month
            // 
            this.cmbobx_month.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbobx_month.FormattingEnabled = true;
            this.cmbobx_month.Location = new System.Drawing.Point(58, 6);
            this.cmbobx_month.Name = "cmbobx_month";
            this.cmbobx_month.Size = new System.Drawing.Size(172, 24);
            this.cmbobx_month.TabIndex = 1;
            this.cmbobx_month.SelectedIndexChanged += new System.EventHandler(this.cmbobx_month_SelectedIndexChanged);
            // 
            // panel22
            // 
            this.panel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel22.Location = new System.Drawing.Point(609, 3);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(308, 43);
            this.panel22.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel4.Controls.Add(this.panel16, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel17, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel18, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 490);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(920, 49);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.btn_show_weather_graphs);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel16.Location = new System.Drawing.Point(3, 3);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(297, 43);
            this.panel16.TabIndex = 0;
            // 
            // btn_show_weather_graphs
            // 
            this.btn_show_weather_graphs.Location = new System.Drawing.Point(60, 10);
            this.btn_show_weather_graphs.Name = "btn_show_weather_graphs";
            this.btn_show_weather_graphs.Size = new System.Drawing.Size(150, 29);
            this.btn_show_weather_graphs.TabIndex = 0;
            this.btn_show_weather_graphs.Text = "Weather Graphs";
            this.btn_show_weather_graphs.UseVisualStyleBackColor = true;
            this.btn_show_weather_graphs.Click += new System.EventHandler(this.btn_show_weather_graphs_Click);
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.btn_show_environmental_graphs);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel17.Location = new System.Drawing.Point(306, 3);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(297, 43);
            this.panel17.TabIndex = 1;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.btn_exit);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel18.Location = new System.Drawing.Point(609, 3);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(308, 43);
            this.panel18.TabIndex = 2;
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.tabControl1);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel19.Location = new System.Drawing.Point(3, 58);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(920, 426);
            this.panel19.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_weather);
            this.tabControl1.Controls.Add(this.tab_environmental);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(920, 426);
            this.tabControl1.TabIndex = 1;
            // 
            // tab_weather
            // 
            this.tab_weather.Controls.Add(this.dgv_weather);
            this.tab_weather.Location = new System.Drawing.Point(4, 25);
            this.tab_weather.Name = "tab_weather";
            this.tab_weather.Padding = new System.Windows.Forms.Padding(3);
            this.tab_weather.Size = new System.Drawing.Size(912, 397);
            this.tab_weather.TabIndex = 0;
            this.tab_weather.Text = "Weather";
            this.tab_weather.UseVisualStyleBackColor = true;
            // 
            // dgv_weather
            // 
            this.dgv_weather.AllowUserToAddRows = false;
            this.dgv_weather.AllowUserToDeleteRows = false;
            this.dgv_weather.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_weather.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_weather.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_weather.Location = new System.Drawing.Point(3, 3);
            this.dgv_weather.Name = "dgv_weather";
            this.dgv_weather.ReadOnly = true;
            this.dgv_weather.RowTemplate.Height = 24;
            this.dgv_weather.Size = new System.Drawing.Size(906, 391);
            this.dgv_weather.TabIndex = 2;
            // 
            // tab_environmental
            // 
            this.tab_environmental.Controls.Add(this.dgv_environment);
            this.tab_environmental.Location = new System.Drawing.Point(4, 25);
            this.tab_environmental.Name = "tab_environmental";
            this.tab_environmental.Padding = new System.Windows.Forms.Padding(3);
            this.tab_environmental.Size = new System.Drawing.Size(912, 397);
            this.tab_environmental.TabIndex = 1;
            this.tab_environmental.Text = "Environmental";
            this.tab_environmental.UseVisualStyleBackColor = true;
            // 
            // dgv_environment
            // 
            this.dgv_environment.AllowUserToAddRows = false;
            this.dgv_environment.AllowUserToDeleteRows = false;
            this.dgv_environment.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_environment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_environment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_environment.Location = new System.Drawing.Point(3, 3);
            this.dgv_environment.Name = "dgv_environment";
            this.dgv_environment.ReadOnly = true;
            this.dgv_environment.RowTemplate.Height = 24;
            this.dgv_environment.Size = new System.Drawing.Size(906, 391);
            this.dgv_environment.TabIndex = 2;
            // 
            // btn_show_environmental_graphs
            // 
            this.btn_show_environmental_graphs.Location = new System.Drawing.Point(58, 6);
            this.btn_show_environmental_graphs.Name = "btn_show_environmental_graphs";
            this.btn_show_environmental_graphs.Size = new System.Drawing.Size(192, 29);
            this.btn_show_environmental_graphs.TabIndex = 1;
            this.btn_show_environmental_graphs.Text = "Environmental Graphs";
            this.btn_show_environmental_graphs.UseVisualStyleBackColor = true;
            this.btn_show_environmental_graphs.Click += new System.EventHandler(this.btn_show_environmental_graphs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 542);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Weather Station";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tab_weather.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_weather)).EndInit();
            this.tab_environmental.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_environment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.ComboBox cmbobx_year;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.ComboBox cmbobx_month;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_weather;
        private System.Windows.Forms.DataGridView dgv_weather;
        private System.Windows.Forms.TabPage tab_environmental;
        private System.Windows.Forms.DataGridView dgv_environment;
        private System.Windows.Forms.Button btn_show_weather_graphs;
        private System.Windows.Forms.Button btn_show_environmental_graphs;
    }
}

