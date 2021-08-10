
namespace FiveColors
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.radioLime = new System.Windows.Forms.RadioButton();
            this.radioRose = new System.Windows.Forms.RadioButton();
            this.radioCyan = new System.Windows.Forms.RadioButton();
            this.radioNavy = new System.Windows.Forms.RadioButton();
            this.radioGold = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Font = new System.Drawing.Font("Product Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(615, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cyan";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Product Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(615, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "Rose";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.Font = new System.Drawing.Font("Product Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(615, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 51);
            this.button3.TabIndex = 2;
            this.button3.Text = "Lime";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Yellow;
            this.button4.Font = new System.Drawing.Font("Product Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(615, 373);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(153, 51);
            this.button4.TabIndex = 3;
            this.button4.Text = "Gold";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Navy;
            this.button5.Font = new System.Drawing.Font("Product Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(615, 291);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(153, 51);
            this.button5.TabIndex = 4;
            this.button5.Text = "Navy";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(49, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "what color?";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Product Sans", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblColor.Location = new System.Drawing.Point(39, 185);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(283, 122);
            this.lblColor.TabIndex = 6;
            this.lblColor.Text = "None";
            // 
            // radioLime
            // 
            this.radioLime.AutoSize = true;
            this.radioLime.Location = new System.Drawing.Point(803, 48);
            this.radioLime.Name = "radioLime";
            this.radioLime.Size = new System.Drawing.Size(74, 29);
            this.radioLime.TabIndex = 7;
            this.radioLime.TabStop = true;
            this.radioLime.Text = "Lime";
            this.radioLime.UseVisualStyleBackColor = true;
            this.radioLime.CheckedChanged += new System.EventHandler(this.radioLime_CheckedChanged);
            // 
            // radioRose
            // 
            this.radioRose.AutoSize = true;
            this.radioRose.Location = new System.Drawing.Point(803, 132);
            this.radioRose.Name = "radioRose";
            this.radioRose.Size = new System.Drawing.Size(75, 29);
            this.radioRose.TabIndex = 8;
            this.radioRose.TabStop = true;
            this.radioRose.Text = "Rose";
            this.radioRose.UseVisualStyleBackColor = true;
            this.radioRose.CheckedChanged += new System.EventHandler(this.radioRose_CheckedChanged);
            // 
            // radioCyan
            // 
            this.radioCyan.AutoSize = true;
            this.radioCyan.Location = new System.Drawing.Point(803, 218);
            this.radioCyan.Name = "radioCyan";
            this.radioCyan.Size = new System.Drawing.Size(76, 29);
            this.radioCyan.TabIndex = 10;
            this.radioCyan.TabStop = true;
            this.radioCyan.Text = "Cyan";
            this.radioCyan.UseVisualStyleBackColor = true;
            this.radioCyan.CheckedChanged += new System.EventHandler(this.radioCyan_CheckedChanged);
            // 
            // radioNavy
            // 
            this.radioNavy.AutoSize = true;
            this.radioNavy.Location = new System.Drawing.Point(803, 300);
            this.radioNavy.Name = "radioNavy";
            this.radioNavy.Size = new System.Drawing.Size(77, 29);
            this.radioNavy.TabIndex = 9;
            this.radioNavy.TabStop = true;
            this.radioNavy.Text = "Navy";
            this.radioNavy.UseVisualStyleBackColor = true;
            this.radioNavy.CheckedChanged += new System.EventHandler(this.radioNavy_CheckedChanged);
            // 
            // radioGold
            // 
            this.radioGold.AutoSize = true;
            this.radioGold.Location = new System.Drawing.Point(803, 382);
            this.radioGold.Name = "radioGold";
            this.radioGold.Size = new System.Drawing.Size(75, 29);
            this.radioGold.TabIndex = 11;
            this.radioGold.TabStop = true;
            this.radioGold.Text = "Gold";
            this.radioGold.UseVisualStyleBackColor = true;
            this.radioGold.CheckedChanged += new System.EventHandler(this.radioGold_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 450);
            this.Controls.Add(this.radioGold);
            this.Controls.Add(this.radioCyan);
            this.Controls.Add(this.radioNavy);
            this.Controls.Add(this.radioRose);
            this.Controls.Add(this.radioLime);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.RadioButton radioLime;
        private System.Windows.Forms.RadioButton radioRose;
        private System.Windows.Forms.RadioButton radioCyan;
        private System.Windows.Forms.RadioButton radioNavy;
        private System.Windows.Forms.RadioButton radioGold;
    }
}

