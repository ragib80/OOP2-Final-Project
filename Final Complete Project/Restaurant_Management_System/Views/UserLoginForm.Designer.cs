namespace Restaurant_Management_System.Controllers
{
    partial class UserLoginForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.lable4 = new System.Windows.Forms.Label();
            this.tboxUsername = new System.Windows.Forms.TextBox();
            this.lable5 = new System.Windows.Forms.Label();
            this.tboxPassword = new System.Windows.Forms.TextBox();
            this.butLogin = new System.Windows.Forms.Button();
            this.butRegister = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Matura MT Script Capitals", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(400, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 34);
            this.label3.TabIndex = 0;
            this.label3.Text = "Login";
            // 
            // lable4
            // 
            this.lable4.AutoSize = true;
            this.lable4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lable4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lable4.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable4.ForeColor = System.Drawing.Color.Blue;
            this.lable4.Location = new System.Drawing.Point(230, 152);
            this.lable4.Name = "lable4";
            this.lable4.Size = new System.Drawing.Size(107, 30);
            this.lable4.TabIndex = 1;
            this.lable4.Text = "Username";
            // 
            // tboxUsername
            // 
            this.tboxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tboxUsername.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxUsername.Location = new System.Drawing.Point(363, 152);
            this.tboxUsername.Name = "tboxUsername";
            this.tboxUsername.Size = new System.Drawing.Size(246, 33);
            this.tboxUsername.TabIndex = 2;
            // 
            // lable5
            // 
            this.lable5.AutoSize = true;
            this.lable5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lable5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lable5.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable5.ForeColor = System.Drawing.Color.Blue;
            this.lable5.Location = new System.Drawing.Point(230, 207);
            this.lable5.Name = "lable5";
            this.lable5.Size = new System.Drawing.Size(107, 30);
            this.lable5.TabIndex = 3;
            this.lable5.Text = "Password";
            // 
            // tboxPassword
            // 
            this.tboxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tboxPassword.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxPassword.Location = new System.Drawing.Point(363, 207);
            this.tboxPassword.Name = "tboxPassword";
            this.tboxPassword.Size = new System.Drawing.Size(246, 33);
            this.tboxPassword.TabIndex = 4;
            this.tboxPassword.UseSystemPasswordChar = true;
            // 
            // butLogin
            // 
            this.butLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.butLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butLogin.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLogin.Location = new System.Drawing.Point(655, 288);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(101, 33);
            this.butLogin.TabIndex = 5;
            this.butLogin.Text = "Login";
            this.butLogin.UseVisualStyleBackColor = false;
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click_1);
            // 
            // butRegister
            // 
            this.butRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.butRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butRegister.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butRegister.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butRegister.Location = new System.Drawing.Point(317, 341);
            this.butRegister.Name = "butRegister";
            this.butRegister.Size = new System.Drawing.Size(204, 30);
            this.butRegister.TabIndex = 6;
            this.butRegister.Text = "Not Registered??";
            this.butRegister.UseVisualStyleBackColor = false;
            this.butRegister.Click += new System.EventHandler(this.butRegister_Click);
            // 
            // butExit
            // 
            this.butExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.butExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butExit.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butExit.Location = new System.Drawing.Point(762, 288);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(101, 33);
            this.butExit.TabIndex = 7;
            this.butExit.Text = "Exit";
            this.butExit.UseVisualStyleBackColor = false;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // UserLoginForm
            // 
            this.BackgroundImage = global::Restaurant_Management_System.Properties.Resources.pngtree_elemental_background_of_fast_food_hamburg_hot_dog_chips_coke_image_90631;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(871, 383);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butRegister);
            this.Controls.Add(this.butLogin);
            this.Controls.Add(this.tboxPassword);
            this.Controls.Add(this.lable5);
            this.Controls.Add(this.tboxUsername);
            this.Controls.Add(this.lable4);
            this.Controls.Add(this.label3);
            this.Name = "UserLoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lable4;
        private System.Windows.Forms.TextBox tboxUsername;
        private System.Windows.Forms.Label lable5;
        private System.Windows.Forms.TextBox tboxPassword;
        private System.Windows.Forms.Button butLogin;
        private System.Windows.Forms.Button butRegister;
        private System.Windows.Forms.Button butExit;
    }
}