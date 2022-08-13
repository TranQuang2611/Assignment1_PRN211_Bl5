namespace Exercise3
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
            this.loginLabel = new System.Windows.Forms.Label();
            this.viButton = new System.Windows.Forms.RadioButton();
            this.engButton = new System.Windows.Forms.RadioButton();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.checkNameLabel = new System.Windows.Forms.Label();
            this.checkPassLabel = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.forgetButton = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginLabel.ForeColor = System.Drawing.Color.Red;
            this.loginLabel.Location = new System.Drawing.Point(231, 52);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(181, 37);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "ĐĂNG NHẬP";
            // 
            // viButton
            // 
            this.viButton.AutoSize = true;
            this.viButton.Location = new System.Drawing.Point(503, 12);
            this.viButton.Name = "viButton";
            this.viButton.Size = new System.Drawing.Size(45, 19);
            this.viButton.TabIndex = 1;
            this.viButton.Text = "Việt";
            this.viButton.UseVisualStyleBackColor = true;
            this.viButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // engButton
            // 
            this.engButton.AutoSize = true;
            this.engButton.Location = new System.Drawing.Point(567, 12);
            this.engButton.Name = "engButton";
            this.engButton.Size = new System.Drawing.Size(47, 19);
            this.engButton.TabIndex = 2;
            this.engButton.Text = "Anh";
            this.engButton.UseVisualStyleBackColor = true;
            this.engButton.CheckedChanged += new System.EventHandler(this.engButton_CheckedChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(60, 115);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(137, 25);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Tên đăng nhập";
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.White;
            this.nameBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameBox.Location = new System.Drawing.Point(231, 115);
            this.nameBox.Multiline = true;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(251, 30);
            this.nameBox.TabIndex = 4;
            this.nameBox.CursorChanged += new System.EventHandler(this.nameBox_CursorChanged);
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            this.nameBox.MouseLeave += new System.EventHandler(this.nameBox_MouseLeave);
            this.nameBox.MouseHover += new System.EventHandler(this.nameBox_MouseHover);
            // 
            // checkNameLabel
            // 
            this.checkNameLabel.AutoSize = true;
            this.checkNameLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkNameLabel.Location = new System.Drawing.Point(503, 115);
            this.checkNameLabel.Name = "checkNameLabel";
            this.checkNameLabel.Size = new System.Drawing.Size(28, 37);
            this.checkNameLabel.TabIndex = 5;
            this.checkNameLabel.Text = "*";
            // 
            // checkPassLabel
            // 
            this.checkPassLabel.AutoSize = true;
            this.checkPassLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkPassLabel.Location = new System.Drawing.Point(503, 173);
            this.checkPassLabel.Name = "checkPassLabel";
            this.checkPassLabel.Size = new System.Drawing.Size(28, 37);
            this.checkPassLabel.TabIndex = 8;
            this.checkPassLabel.Text = "*";
            // 
            // passBox
            // 
            this.passBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passBox.Location = new System.Drawing.Point(231, 173);
            this.passBox.Multiline = true;
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(251, 30);
            this.passBox.TabIndex = 7;
            this.passBox.TextChanged += new System.EventHandler(this.passBox_TextChanged);
            this.passBox.MouseLeave += new System.EventHandler(this.passBox_MouseLeave);
            this.passBox.MouseHover += new System.EventHandler(this.passBox_MouseHover);
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passLabel.Location = new System.Drawing.Point(60, 173);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(96, 25);
            this.passLabel.TabIndex = 6;
            this.passLabel.Text = "Mật khẩu ";
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginButton.Location = new System.Drawing.Point(60, 273);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(137, 29);
            this.loginButton.TabIndex = 9;
            this.loginButton.Text = "ĐĂNG NHẬP";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resetButton.Location = new System.Drawing.Point(246, 273);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(137, 29);
            this.resetButton.TabIndex = 10;
            this.resetButton.Text = "LÀM MỚI";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(421, 273);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(137, 29);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "THOÁT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // forgetButton
            // 
            this.forgetButton.AutoSize = true;
            this.forgetButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.forgetButton.Location = new System.Drawing.Point(246, 335);
            this.forgetButton.Name = "forgetButton";
            this.forgetButton.Size = new System.Drawing.Size(131, 21);
            this.forgetButton.TabIndex = 12;
            this.forgetButton.TabStop = true;
            this.forgetButton.Text = "Quên mật khẩu ?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 391);
            this.Controls.Add(this.forgetButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.checkPassLabel);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.checkNameLabel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.engButton);
            this.Controls.Add(this.viButton);
            this.Controls.Add(this.loginLabel);
            this.Name = "Form1";
            this.Text = "DANG NHAP HE THONG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.RadioButton viButton;
        private System.Windows.Forms.RadioButton engButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label checkNameLabel;
        private System.Windows.Forms.Label checkPassLabel;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.LinkLabel forgetButton;
    }
}
