namespace PasswordMaker
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.chk_low = new System.Windows.Forms.CheckBox();
            this.chk_num = new System.Windows.Forms.CheckBox();
            this.chk_hi = new System.Windows.Forms.CheckBox();
            this.chk_symb = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Karakterek száma (8-18)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(153, 20);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(61, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // chk_low
            // 
            this.chk_low.AutoSize = true;
            this.chk_low.Location = new System.Drawing.Point(28, 49);
            this.chk_low.Name = "chk_low";
            this.chk_low.Size = new System.Drawing.Size(67, 17);
            this.chk_low.TabIndex = 4;
            this.chk_low.Text = "Kisbetűk";
            this.chk_low.UseVisualStyleBackColor = true;
            this.chk_low.CheckedChanged += new System.EventHandler(this.chk_low_CheckedChanged);
            // 
            // chk_num
            // 
            this.chk_num.AutoSize = true;
            this.chk_num.Location = new System.Drawing.Point(28, 95);
            this.chk_num.Name = "chk_num";
            this.chk_num.Size = new System.Drawing.Size(64, 17);
            this.chk_num.TabIndex = 5;
            this.chk_num.Text = "Számok";
            this.chk_num.UseVisualStyleBackColor = true;
            this.chk_num.CheckedChanged += new System.EventHandler(this.chk_num_CheckedChanged);
            // 
            // chk_hi
            // 
            this.chk_hi.AutoSize = true;
            this.chk_hi.Location = new System.Drawing.Point(28, 72);
            this.chk_hi.Name = "chk_hi";
            this.chk_hi.Size = new System.Drawing.Size(78, 17);
            this.chk_hi.TabIndex = 6;
            this.chk_hi.Text = "Nagybetűk";
            this.chk_hi.UseVisualStyleBackColor = true;
            this.chk_hi.CheckedChanged += new System.EventHandler(this.chk_hi_CheckedChanged);
            // 
            // chk_symb
            // 
            this.chk_symb.AutoSize = true;
            this.chk_symb.Location = new System.Drawing.Point(28, 118);
            this.chk_symb.Name = "chk_symb";
            this.chk_symb.Size = new System.Drawing.Size(88, 17);
            this.chk_symb.TabIndex = 7;
            this.chk_symb.Text = "Szimbólumok";
            this.chk_symb.UseVisualStyleBackColor = true;
            this.chk_symb.CheckedChanged += new System.EventHandler(this.chk_symb_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 86);
            this.button1.TabIndex = 8;
            this.button1.Text = "Létrehoz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(28, 141);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(186, 134);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(39, 280);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(164, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://www.passwordmeter.com/";
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(31, 300);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(183, 13);
            this.linkLabel2.TabIndex = 11;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "https://howsecureismypassword.net/";
            this.linkLabel2.Click += new System.EventHandler(this.linkLabel2_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(0, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 19);
            this.label2.TabIndex = 12;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 341);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chk_symb);
            this.Controls.Add(this.chk_hi);
            this.Controls.Add(this.chk_num);
            this.Controls.Add(this.chk_low);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(257, 380);
            this.MinimumSize = new System.Drawing.Size(257, 380);
            this.Name = "Form1";
            this.Text = "Password Maker";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox chk_low;
        private System.Windows.Forms.CheckBox chk_num;
        private System.Windows.Forms.CheckBox chk_hi;
        private System.Windows.Forms.CheckBox chk_symb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label2;
    }
}

