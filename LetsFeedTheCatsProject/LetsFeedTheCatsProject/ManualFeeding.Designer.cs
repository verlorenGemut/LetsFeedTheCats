namespace LetsFeedTheCatsProject
{
    partial class ManualFeeding
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblManualFeeding = new System.Windows.Forms.Label();
            this.lblAddFeed = new System.Windows.Forms.Label();
            this.tbAddFeed = new System.Windows.Forms.TextBox();
            this.lblG = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.Font = new System.Drawing.Font("Snap ITC", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(130, 54);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblManualFeeding
            // 
            this.lblManualFeeding.AutoSize = true;
            this.lblManualFeeding.Font = new System.Drawing.Font("Snap ITC", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblManualFeeding.Location = new System.Drawing.Point(171, 77);
            this.lblManualFeeding.Name = "lblManualFeeding";
            this.lblManualFeeding.Size = new System.Drawing.Size(445, 61);
            this.lblManualFeeding.TabIndex = 33;
            this.lblManualFeeding.Text = "Manual Feeding";
            this.lblManualFeeding.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAddFeed
            // 
            this.lblAddFeed.AutoSize = true;
            this.lblAddFeed.Font = new System.Drawing.Font("Snap ITC", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAddFeed.Location = new System.Drawing.Point(63, 181);
            this.lblAddFeed.Name = "lblAddFeed";
            this.lblAddFeed.Size = new System.Drawing.Size(208, 44);
            this.lblAddFeed.TabIndex = 34;
            this.lblAddFeed.Text = "Add Feed:";
            this.lblAddFeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbAddFeed
            // 
            this.tbAddFeed.Font = new System.Drawing.Font("Snap ITC", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAddFeed.Location = new System.Drawing.Point(491, 179);
            this.tbAddFeed.Name = "tbAddFeed";
            this.tbAddFeed.Size = new System.Drawing.Size(100, 50);
            this.tbAddFeed.TabIndex = 35;
            this.tbAddFeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAddFeed_KeyPress);
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Font = new System.Drawing.Font("Snap ITC", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblG.Location = new System.Drawing.Point(617, 181);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(41, 44);
            this.lblG.TabIndex = 36;
            this.lblG.Text = "g";
            this.lblG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoSize = true;
            this.btnSubmit.Font = new System.Drawing.Font("Snap ITC", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.Location = new System.Drawing.Point(320, 274);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(164, 54);
            this.btnSubmit.TabIndex = 37;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // ManualFeeding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 361);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.tbAddFeed);
            this.Controls.Add(this.lblAddFeed);
            this.Controls.Add(this.lblManualFeeding);
            this.Controls.Add(this.btnBack);
            this.Name = "ManualFeeding";
            this.Text = "Manual Feeding";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManualFeeding_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBack;
        private Label lblManualFeeding;
        private Label lblAddFeed;
        private TextBox tbAddFeed;
        private Label lblG;
        private Button btnSubmit;
    }
}