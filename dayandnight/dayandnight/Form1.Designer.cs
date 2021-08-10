
namespace dayandnight
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDay = new System.Windows.Forms.Button();
            this.btnNight = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDay
            // 
            this.btnDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDay.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDay.Location = new System.Drawing.Point(518, 145);
            this.btnDay.Name = "btnDay";
            this.btnDay.Size = new System.Drawing.Size(122, 48);
            this.btnDay.TabIndex = 0;
            this.btnDay.Text = "Day";
            this.btnDay.UseVisualStyleBackColor = false;
            this.btnDay.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // btnNight
            // 
            this.btnNight.BackColor = System.Drawing.Color.Navy;
            this.btnNight.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNight.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNight.Location = new System.Drawing.Point(518, 268);
            this.btnNight.Name = "btnNight";
            this.btnNight.Padding = new System.Windows.Forms.Padding(2);
            this.btnNight.Size = new System.Drawing.Size(128, 48);
            this.btnNight.TabIndex = 1;
            this.btnNight.Text = "Night";
            this.btnNight.UseVisualStyleBackColor = false;
            this.btnNight.Click += new System.EventHandler(this.btnNight_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Product Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime.Location = new System.Drawing.Point(71, 133);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(130, 183);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Time\r\nof\r\nday";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnNight);
            this.Controls.Add(this.btnDay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDay;
        private System.Windows.Forms.Button btnNight;
        private System.Windows.Forms.Label lblTime;
    }
}

