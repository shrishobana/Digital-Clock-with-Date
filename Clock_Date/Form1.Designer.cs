namespace Clock_Date
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
            this.components = new System.ComponentModel.Container();
            this.lbtime = new System.Windows.Forms.Label();
            this.lbdate = new System.Windows.Forms.Label();
            this.lbday = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbtime
            // 
            this.lbtime.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtime.Location = new System.Drawing.Point(161, 51);
            this.lbtime.Name = "lbtime";
            this.lbtime.Size = new System.Drawing.Size(401, 63);
            this.lbtime.TabIndex = 0;
            this.lbtime.Text = "00:00:00";
            this.lbtime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbtime.Click += new System.EventHandler(this.lbtime_Click);
            // 
            // lbdate
            // 
            this.lbdate.Font = new System.Drawing.Font("Arial Narrow", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdate.Location = new System.Drawing.Point(52, 145);
            this.lbdate.Name = "lbdate";
            this.lbdate.Size = new System.Drawing.Size(247, 63);
            this.lbdate.TabIndex = 1;
            this.lbdate.Text = "June 25 2019";
            this.lbdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbday
            // 
            this.lbday.Font = new System.Drawing.Font("Baskerville Old Face", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbday.Location = new System.Drawing.Point(437, 145);
            this.lbday.Name = "lbday";
            this.lbday.Size = new System.Drawing.Size(209, 63);
            this.lbday.TabIndex = 2;
            this.lbday.Text = "Sunday";
            this.lbday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Controls.Add(this.lbday);
            this.Controls.Add(this.lbdate);
            this.Controls.Add(this.lbtime);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital Clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbtime;
        private System.Windows.Forms.Label lbdate;
        private System.Windows.Forms.Label lbday;
        private System.Windows.Forms.Timer timer1;
    }
}

