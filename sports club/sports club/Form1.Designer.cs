
namespace sports_club
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAskName = new System.Windows.Forms.Label();
            this.lblAskAge = new System.Windows.Forms.Label();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.lblAskSport = new System.Windows.Forms.Label();
            this.listSport = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblSports = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.ListBox();
            this.lblAskGender = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(220, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 213);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(284, 399);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "Name";
            this.txtName.Size = new System.Drawing.Size(150, 31);
            this.txtName.TabIndex = 1;
            // 
            // lblAskName
            // 
            this.lblAskName.AutoSize = true;
            this.lblAskName.Location = new System.Drawing.Point(136, 402);
            this.lblAskName.Name = "lblAskName";
            this.lblAskName.Size = new System.Drawing.Size(142, 25);
            this.lblAskName.TabIndex = 2;
            this.lblAskName.Text = "Enter your name";
            // 
            // lblAskAge
            // 
            this.lblAskAge.AutoSize = true;
            this.lblAskAge.Location = new System.Drawing.Point(136, 460);
            this.lblAskAge.Name = "lblAskAge";
            this.lblAskAge.Size = new System.Drawing.Size(127, 25);
            this.lblAskAge.TabIndex = 4;
            this.lblAskAge.Text = "Enter your age";
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(284, 460);
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(180, 31);
            this.numAge.TabIndex = 5;
            // 
            // lblAskSport
            // 
            this.lblAskSport.AutoSize = true;
            this.lblAskSport.Location = new System.Drawing.Point(136, 728);
            this.lblAskSport.Name = "lblAskSport";
            this.lblAskSport.Size = new System.Drawing.Size(367, 25);
            this.lblAskSport.TabIndex = 7;
            this.lblAskSport.Text = "Which sports would you like to paricipate in?";
            // 
            // listSport
            // 
            this.listSport.FormattingEnabled = true;
            this.listSport.ItemHeight = 25;
            this.listSport.Items.AddRange(new object[] {
            "Netball",
            "Hockey",
            "Soccer",
            "Rugby"});
            this.listSport.Location = new System.Drawing.Point(136, 780);
            this.listSport.Name = "listSport";
            this.listSport.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listSport.Size = new System.Drawing.Size(188, 129);
            this.listSport.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(486, 911);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 957);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(775, 105);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(104, 25);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "your details";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(775, 160);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(104, 25);
            this.lblAge.TabIndex = 12;
            this.lblAge.Text = "your details";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(775, 218);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(104, 25);
            this.lblGender.TabIndex = 13;
            this.lblGender.Text = "your details";
            // 
            // lblSports
            // 
            this.lblSports.AutoSize = true;
            this.lblSports.Location = new System.Drawing.Point(775, 275);
            this.lblSports.Name = "lblSports";
            this.lblSports.Size = new System.Drawing.Size(104, 25);
            this.lblSports.TabIndex = 14;
            this.lblSports.Text = "your details";
            // 
            // lbGender
            // 
            this.lbGender.FormattingEnabled = true;
            this.lbGender.ItemHeight = 25;
            this.lbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.lbGender.Location = new System.Drawing.Point(136, 589);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(180, 79);
            this.lbGender.TabIndex = 15;
            // 
            // lblAskGender
            // 
            this.lblAskGender.AutoSize = true;
            this.lblAskGender.Location = new System.Drawing.Point(136, 552);
            this.lblAskGender.Name = "lblAskGender";
            this.lblAskGender.Size = new System.Drawing.Size(161, 25);
            this.lblAskGender.TabIndex = 16;
            this.lblAskGender.Text = "Select your Gender";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1327, 1050);
            this.Controls.Add(this.lblAskGender);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.lblSports);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listSport);
            this.Controls.Add(this.lblAskSport);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.lblAskAge);
            this.Controls.Add(this.lblAskName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAskName;
        private System.Windows.Forms.Label lblAskAge;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.Label lblAskSport;
        private System.Windows.Forms.ListBox listSport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton o;
        private System.Windows.Forms.RadioButton radio;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblSports;
        private System.Windows.Forms.ListBox lbGender;
        private System.Windows.Forms.Label lblAskGender;
    }
}

