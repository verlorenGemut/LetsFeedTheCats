namespace LetsFeedTheCatsProject
{
    partial class WelcomeScreen
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
            this.lblCatFeeder = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.pbWelcomeCat = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbWelcomeCat)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCatFeeder
            // 
            this.lblCatFeeder.AutoSize = true;
            this.lblCatFeeder.Font = new System.Drawing.Font("Snap ITC", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCatFeeder.Location = new System.Drawing.Point(233, 206);
            this.lblCatFeeder.Name = "lblCatFeeder";
            this.lblCatFeeder.Size = new System.Drawing.Size(326, 61);
            this.lblCatFeeder.TabIndex = 0;
            this.lblCatFeeder.Text = "Cat Feeder";
            this.lblCatFeeder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSignIn
            // 
            this.btnSignIn.AutoSize = true;
            this.btnSignIn.Font = new System.Drawing.Font("Snap ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSignIn.Location = new System.Drawing.Point(304, 283);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(183, 44);
            this.btnSignIn.TabIndex = 1;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            // 
            // btnSignUp
            // 
            this.btnSignUp.AutoSize = true;
            this.btnSignUp.Font = new System.Drawing.Font("Snap ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSignUp.Location = new System.Drawing.Point(304, 354);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(183, 44);
            this.btnSignUp.TabIndex = 2;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            // 
            // pbWelcomeCat
            // 
            this.pbWelcomeCat.Location = new System.Drawing.Point(282, 32);
            this.pbWelcomeCat.Name = "pbWelcomeCat";
            this.pbWelcomeCat.Size = new System.Drawing.Size(235, 157);
            this.pbWelcomeCat.TabIndex = 3;
            this.pbWelcomeCat.TabStop = false;
            // 
            // WelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbWelcomeCat);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.lblCatFeeder);
            this.Name = "WelcomeScreen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.WelcomeScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbWelcomeCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCatFeeder;
        private Button btnSignIn;
        private Button btnSignUp;
        private PictureBox pbWelcomeCat;
    }
}