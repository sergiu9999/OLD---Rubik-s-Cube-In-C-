namespace WindowsFormsApplication1
{
    partial class Statistici
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rubiksDataSet = new WindowsFormsApplication1.RubiksDataSet();
            this.timpTableAdapter = new WindowsFormsApplication1.RubiksDataSetTableAdapters.TimpTableAdapter();
            this.statisticiBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubiksDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.DataSource = this.timpBindingSource;
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(660, 733);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // timpBindingSource
            // 
            this.timpBindingSource.DataMember = "Timp";
            this.timpBindingSource.DataSource = this.rubiksDataSet;
            // 
            // rubiksDataSet
            // 
            this.rubiksDataSet.DataSetName = "RubiksDataSet";
            this.rubiksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timpTableAdapter
            // 
            this.timpTableAdapter.ClearBeforeFill = true;
            // 
            // statisticiBtn
            // 
            this.statisticiBtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.statisticiBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statisticiBtn.Font = new System.Drawing.Font("MingLiU", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticiBtn.Location = new System.Drawing.Point(516, 188);
            this.statisticiBtn.Name = "statisticiBtn";
            this.statisticiBtn.Size = new System.Drawing.Size(132, 68);
            this.statisticiBtn.TabIndex = 3;
            this.statisticiBtn.Text = "Back";
            this.statisticiBtn.UseVisualStyleBackColor = false;
            this.statisticiBtn.Click += new System.EventHandler(this.statisticiBtn_Click);
            // 
            // Statistici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(660, 733);
            this.Controls.Add(this.statisticiBtn);
            this.Controls.Add(this.chart1);
            this.KeyPreview = true;
            this.Name = "Statistici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistici";
            this.Load += new System.EventHandler(this.Statistici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubiksDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private RubiksDataSet rubiksDataSet;
        private System.Windows.Forms.BindingSource timpBindingSource;
        private RubiksDataSetTableAdapters.TimpTableAdapter timpTableAdapter;
        private System.Windows.Forms.Button statisticiBtn;
    }
}