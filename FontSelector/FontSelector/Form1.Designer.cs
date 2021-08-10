
namespace FontSelector
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
            this.lbFontFamily = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbFontSize = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.helloLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbFontFamily
            // 
            this.lbFontFamily.BackColor = System.Drawing.Color.Gainsboro;
            this.lbFontFamily.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbFontFamily.FormattingEnabled = true;
            this.lbFontFamily.ItemHeight = 25;
            this.lbFontFamily.Items.AddRange(new object[] {
            "Poppins",
            "Montserrat",
            "Oswald",
            "Product Sans",
            "Bahnschrift"});
            this.lbFontFamily.Location = new System.Drawing.Point(85, 258);
            this.lbFontFamily.Name = "lbFontFamily";
            this.lbFontFamily.Size = new System.Drawing.Size(180, 50);
            this.lbFontFamily.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Product Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(85, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pick a font family";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbFontSize
            // 
            this.lbFontSize.BackColor = System.Drawing.Color.Gainsboro;
            this.lbFontSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbFontSize.FormattingEnabled = true;
            this.lbFontSize.ItemHeight = 25;
            this.lbFontSize.Items.AddRange(new object[] {
            "16",
            "20",
            "24",
            "26",
            "30"});
            this.lbFontSize.Location = new System.Drawing.Point(497, 258);
            this.lbFontSize.Name = "lbFontSize";
            this.lbFontSize.Size = new System.Drawing.Size(180, 50);
            this.lbFontSize.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Product Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(497, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pick a font size";
            // 
            // helloLbl
            // 
            this.helloLbl.AutoSize = true;
            this.helloLbl.Location = new System.Drawing.Point(331, 77);
            this.helloLbl.Name = "helloLbl";
            this.helloLbl.Size = new System.Drawing.Size(24, 25);
            this.helloLbl.TabIndex = 4;
            this.helloLbl.Text = "...";
            this.helloLbl.Click += new System.EventHandler(this.helloLbl_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Product Sans", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(325, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "Say Hello";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.helloLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbFontSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbFontFamily);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbFontFamily;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbFontSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label helloLbl;
        private System.Windows.Forms.Button button1;
    }
}

