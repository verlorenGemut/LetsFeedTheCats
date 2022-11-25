namespace LetsFeedTheCatsProject
{
    partial class SignUp
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
            this.lblSignUp = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbPasswordConfirm = new System.Windows.Forms.TextBox();
            this.lblPasswordConfirm = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.linkSignIn = new System.Windows.Forms.LinkLabel();
            this.pbPassword = new System.Windows.Forms.PictureBox();
            this.pbPasswordConfirm = new System.Windows.Forms.PictureBox();
            this.pbCheck = new System.Windows.Forms.PictureBox();
            this.lblExistsError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPasswordConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Font = new System.Drawing.Font("Snap ITC", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSignUp.Location = new System.Drawing.Point(351, 12);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(297, 76);
            this.lblSignUp.TabIndex = 2;
            this.lblSignUp.Text = "Sign Up";
            this.lblSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Snap ITC", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPassword.Location = new System.Drawing.Point(581, 379);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(244, 61);
            this.tbPassword.TabIndex = 9;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Snap ITC", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEmail.Location = new System.Drawing.Point(581, 148);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(244, 61);
            this.tbEmail.TabIndex = 8;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Snap ITC", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(90, 387);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(270, 54);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Snap ITC", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(90, 156);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(187, 54);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "E-mail:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Snap ITC", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbUsername.Location = new System.Drawing.Point(581, 271);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(244, 61);
            this.tbUsername.TabIndex = 11;
            this.tbUsername.TextChanged += new System.EventHandler(this.tbUsername_TextChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Snap ITC", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.Location = new System.Drawing.Point(90, 279);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(268, 54);
            this.lblUsername.TabIndex = 10;
            this.lblUsername.Text = "Username:";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPasswordConfirm
            // 
            this.tbPasswordConfirm.Font = new System.Drawing.Font("Snap ITC", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPasswordConfirm.Location = new System.Drawing.Point(581, 481);
            this.tbPasswordConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPasswordConfirm.Name = "tbPasswordConfirm";
            this.tbPasswordConfirm.Size = new System.Drawing.Size(244, 61);
            this.tbPasswordConfirm.TabIndex = 13;
            this.tbPasswordConfirm.UseSystemPasswordChar = true;
            this.tbPasswordConfirm.TextChanged += new System.EventHandler(this.tbPasswordConfirm_Changed);
            // 
            // lblPasswordConfirm
            // 
            this.lblPasswordConfirm.AutoSize = true;
            this.lblPasswordConfirm.Font = new System.Drawing.Font("Snap ITC", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPasswordConfirm.Location = new System.Drawing.Point(90, 489);
            this.lblPasswordConfirm.Name = "lblPasswordConfirm";
            this.lblPasswordConfirm.Size = new System.Drawing.Size(476, 54);
            this.lblPasswordConfirm.TabIndex = 12;
            this.lblPasswordConfirm.Text = "Confirm Password:";
            this.lblPasswordConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoSize = true;
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Font = new System.Drawing.Font("Snap ITC", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.Location = new System.Drawing.Point(312, 593);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(310, 72);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // linkSignIn
            // 
            this.linkSignIn.AutoSize = true;
            this.linkSignIn.Font = new System.Drawing.Font("Snap ITC", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkSignIn.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.linkSignIn.Location = new System.Drawing.Point(312, 669);
            this.linkSignIn.Name = "linkSignIn";
            this.linkSignIn.Size = new System.Drawing.Size(341, 29);
            this.linkSignIn.TabIndex = 15;
            this.linkSignIn.TabStop = true;
            this.linkSignIn.Text = "Already have an account?";
            this.linkSignIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSignIp_LinkClicked);
            // 
            // pbPassword
            // 
            this.pbPassword.Location = new System.Drawing.Point(832, 379);
            this.pbPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbPassword.Name = "pbPassword";
            this.pbPassword.Size = new System.Drawing.Size(57, 67);
            this.pbPassword.TabIndex = 16;
            this.pbPassword.TabStop = false;
            this.pbPassword.Click += new System.EventHandler(this.pbPassword_Click);
            // 
            // pbPasswordConfirm
            // 
            this.pbPasswordConfirm.Location = new System.Drawing.Point(832, 481);
            this.pbPasswordConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbPasswordConfirm.Name = "pbPasswordConfirm";
            this.pbPasswordConfirm.Size = new System.Drawing.Size(57, 67);
            this.pbPasswordConfirm.TabIndex = 17;
            this.pbPasswordConfirm.TabStop = false;
            this.pbPasswordConfirm.Click += new System.EventHandler(this.pbPasswordConfirm_Click);
            // 
            // pbCheck
            // 
            this.pbCheck.Location = new System.Drawing.Point(914, 429);
            this.pbCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbCheck.Name = "pbCheck";
            this.pbCheck.Size = new System.Drawing.Size(57, 67);
            this.pbCheck.TabIndex = 18;
            this.pbCheck.TabStop = false;
            // 
            // lblExistsError
            // 
            this.lblExistsError.AutoSize = true;
            this.lblExistsError.Font = new System.Drawing.Font("Snap ITC", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExistsError.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblExistsError.Location = new System.Drawing.Point(618, 219);
            this.lblExistsError.MaximumSize = new System.Drawing.Size(229, 0);
            this.lblExistsError.Name = "lblExistsError";
            this.lblExistsError.Size = new System.Drawing.Size(217, 46);
            this.lblExistsError.TabIndex = 19;
            this.lblExistsError.Text = "User with this e-mail already exists!";
            this.lblExistsError.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblExistsError.Visible = false;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 747);
            this.Controls.Add(this.lblExistsError);
            this.Controls.Add(this.pbCheck);
            this.Controls.Add(this.pbPasswordConfirm);
            this.Controls.Add(this.pbPassword);
            this.Controls.Add(this.linkSignIn);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbPasswordConfirm);
            this.Controls.Add(this.lblPasswordConfirm);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSignUp);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SignUp";
            this.Text = "Sign Up";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SignUp_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPasswordConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSignUp;
        private TextBox tbPassword;
        private TextBox tbEmail;
        private Label lblPassword;
        private Label lblEmail;
        private TextBox tbUsername;
        private Label lblUsername;
        private TextBox tbPasswordConfirm;
        private Label lblPasswordConfirm;
        private Button btnSubmit;
        private LinkLabel linkSignIn;
        private PictureBox pbPassword;
        private PictureBox pbPasswordConfirm;
        private PictureBox pbCheck;
        private Label lblExistsError;
    }
}