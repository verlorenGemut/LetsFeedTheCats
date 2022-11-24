namespace LetsFeedTheCatsProject
{
    partial class Notifications
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
            this.dataNotifications = new System.Windows.Forms.DataGridView();
            this.lblNotifications = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataNotifications)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.Font = new System.Drawing.Font("Snap ITC", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 54);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataNotifications
            // 
            this.dataNotifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNotifications.Location = new System.Drawing.Point(12, 86);
            this.dataNotifications.Name = "dataNotifications";
            this.dataNotifications.RowTemplate.Height = 25;
            this.dataNotifications.Size = new System.Drawing.Size(776, 352);
            this.dataNotifications.TabIndex = 18;
            // 
            // lblNotifications
            // 
            this.lblNotifications.AutoSize = true;
            this.lblNotifications.Font = new System.Drawing.Font("Snap ITC", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNotifications.Location = new System.Drawing.Point(197, 22);
            this.lblNotifications.Name = "lblNotifications";
            this.lblNotifications.Size = new System.Drawing.Size(393, 61);
            this.lblNotifications.TabIndex = 17;
            this.lblNotifications.Text = "Notifications";
            this.lblNotifications.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Notifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataNotifications);
            this.Controls.Add(this.lblNotifications);
            this.Name = "Notifications";
            this.Text = "Notifications";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Notifications_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataNotifications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBack;
        private DataGridView dataNotifications;
        private Label lblNotifications;
    }
}