namespace WindowsFormsApplication1
{
    partial class Rezolva
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.statisticiBtn = new System.Windows.Forms.Button();
            this.timePassed = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Press \"P\" to start the timer";
            // 
            // statisticiBtn
            // 
            this.statisticiBtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.statisticiBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statisticiBtn.Font = new System.Drawing.Font("MingLiU", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticiBtn.Location = new System.Drawing.Point(74, 483);
            this.statisticiBtn.Name = "statisticiBtn";
            this.statisticiBtn.Size = new System.Drawing.Size(265, 68);
            this.statisticiBtn.TabIndex = 2;
            this.statisticiBtn.Text = "Statistics";
            this.statisticiBtn.UseVisualStyleBackColor = false;
            this.statisticiBtn.Click += new System.EventHandler(this.Invata_Click);
            this.statisticiBtn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.statisticiBtn_KeyPress);
            // 
            // timePassed
            // 
            this.timePassed.AutoSize = true;
            this.timePassed.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePassed.Location = new System.Drawing.Point(250, 135);
            this.timePassed.Name = "timePassed";
            this.timePassed.Size = new System.Drawing.Size(178, 108);
            this.timePassed.TabIndex = 3;
            this.timePassed.Text = "0:0";
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("MingLiU", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(345, 483);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(265, 68);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "&Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Rezolva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(660, 741);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.timePassed);
            this.Controls.Add(this.statisticiBtn);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "Rezolva";
            this.Text = "Rezolva";
            this.Load += new System.EventHandler(this.Rezolva_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Rezolva_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Rezolva_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button statisticiBtn;
        private System.Windows.Forms.Label timePassed;
        private System.Windows.Forms.Button exitBtn;
    }
}