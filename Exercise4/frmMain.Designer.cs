namespace Exercise4
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.arsenal = new System.Windows.Forms.RadioButton();
            this.real = new System.Windows.Forms.RadioButton();
            this.mu = new System.Windows.Forms.RadioButton();
            this.barcelona = new System.Windows.Forms.RadioButton();
            this.juve = new System.Windows.Forms.RadioButton();
            this.psg = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bayern = new System.Windows.Forms.RadioButton();
            this.exitButton = new System.Windows.Forms.Button();
            this.lunarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(257, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Logo các câu lạc bộ bóng đá";
            // 
            // arsenal
            // 
            this.arsenal.AutoSize = true;
            this.arsenal.BackColor = System.Drawing.Color.Silver;
            this.arsenal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.arsenal.Location = new System.Drawing.Point(139, 108);
            this.arsenal.Name = "arsenal";
            this.arsenal.Size = new System.Drawing.Size(82, 25);
            this.arsenal.TabIndex = 1;
            this.arsenal.Text = "Arsenal";
            this.arsenal.UseVisualStyleBackColor = false;
            this.arsenal.CheckedChanged += new System.EventHandler(this.arsenal_CheckedChanged);
            // 
            // real
            // 
            this.real.AutoSize = true;
            this.real.BackColor = System.Drawing.Color.Silver;
            this.real.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.real.Location = new System.Drawing.Point(139, 160);
            this.real.Name = "real";
            this.real.Size = new System.Drawing.Size(116, 25);
            this.real.TabIndex = 2;
            this.real.Text = "Real Madrid";
            this.real.UseVisualStyleBackColor = false;
            this.real.CheckedChanged += new System.EventHandler(this.real_CheckedChanged);
            // 
            // mu
            // 
            this.mu.AutoSize = true;
            this.mu.BackColor = System.Drawing.Color.Silver;
            this.mu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mu.Location = new System.Drawing.Point(139, 211);
            this.mu.Name = "mu";
            this.mu.Size = new System.Drawing.Size(167, 25);
            this.mu.TabIndex = 3;
            this.mu.Text = "Manchester United";
            this.mu.UseVisualStyleBackColor = false;
            this.mu.CheckedChanged += new System.EventHandler(this.mu_CheckedChanged);
            // 
            // barcelona
            // 
            this.barcelona.AutoSize = true;
            this.barcelona.BackColor = System.Drawing.Color.Silver;
            this.barcelona.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.barcelona.Location = new System.Drawing.Point(491, 327);
            this.barcelona.Name = "barcelona";
            this.barcelona.Size = new System.Drawing.Size(100, 25);
            this.barcelona.TabIndex = 4;
            this.barcelona.Text = "Barcelona";
            this.barcelona.UseVisualStyleBackColor = false;
            this.barcelona.CheckedChanged += new System.EventHandler(this.barcelona_CheckedChanged);
            // 
            // juve
            // 
            this.juve.AutoSize = true;
            this.juve.BackColor = System.Drawing.Color.Silver;
            this.juve.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.juve.Location = new System.Drawing.Point(491, 369);
            this.juve.Name = "juve";
            this.juve.Size = new System.Drawing.Size(91, 25);
            this.juve.TabIndex = 5;
            this.juve.Text = "Juventus";
            this.juve.UseVisualStyleBackColor = false;
            this.juve.CheckedChanged += new System.EventHandler(this.juve_CheckedChanged);
            // 
            // psg
            // 
            this.psg.AutoSize = true;
            this.psg.BackColor = System.Drawing.Color.Silver;
            this.psg.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.psg.Location = new System.Drawing.Point(491, 413);
            this.psg.Name = "psg";
            this.psg.Size = new System.Drawing.Size(57, 25);
            this.psg.TabIndex = 6;
            this.psg.Text = "PSG";
            this.psg.UseVisualStyleBackColor = false;
            this.psg.CheckedChanged += new System.EventHandler(this.psg_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(491, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // bayern
            // 
            this.bayern.AutoSize = true;
            this.bayern.BackColor = System.Drawing.Color.Silver;
            this.bayern.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bayern.Location = new System.Drawing.Point(139, 259);
            this.bayern.Name = "bayern";
            this.bayern.Size = new System.Drawing.Size(136, 25);
            this.bayern.TabIndex = 8;
            this.bayern.Text = "Bayern Munich";
            this.bayern.UseVisualStyleBackColor = false;
            this.bayern.CheckedChanged += new System.EventHandler(this.bayern_CheckedChanged);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(139, 330);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(104, 34);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // lunarButton
            // 
            this.lunarButton.Location = new System.Drawing.Point(139, 392);
            this.lunarButton.Name = "lunarButton";
            this.lunarButton.Size = new System.Drawing.Size(104, 34);
            this.lunarButton.TabIndex = 10;
            this.lunarButton.Text = "Change Lunar";
            this.lunarButton.UseVisualStyleBackColor = true;
            this.lunarButton.Click += new System.EventHandler(this.lunarButton_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lunarButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.bayern);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.psg);
            this.Controls.Add(this.juve);
            this.Controls.Add(this.barcelona);
            this.Controls.Add(this.mu);
            this.Controls.Add(this.real);
            this.Controls.Add(this.arsenal);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton arsenal;
        private System.Windows.Forms.RadioButton real;
        private System.Windows.Forms.RadioButton mu;
        private System.Windows.Forms.RadioButton barcelona;
        private System.Windows.Forms.RadioButton juve;
        private System.Windows.Forms.RadioButton psg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton bayern;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button lunarButton;
    }
}