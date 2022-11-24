namespace LetsFeedTheCatsProject
{
    partial class Logs
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
            this.lblLogs = new System.Windows.Forms.Label();
            this.dataLogs = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogs
            // 
            this.lblLogs.AutoSize = true;
            this.lblLogs.Font = new System.Drawing.Font("Snap ITC", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLogs.Location = new System.Drawing.Point(240, 22);
            this.lblLogs.Name = "lblLogs";
            this.lblLogs.Size = new System.Drawing.Size(309, 61);
            this.lblLogs.TabIndex = 4;
            this.lblLogs.Text = "Total Logs";
            this.lblLogs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataLogs
            // 
            this.dataLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLogs.Location = new System.Drawing.Point(12, 86);
            this.dataLogs.Name = "dataLogs";
            this.dataLogs.RowTemplate.Height = 25;
            this.dataLogs.Size = new System.Drawing.Size(776, 352);
            this.dataLogs.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.Font = new System.Drawing.Font("Snap ITC", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 54);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Logs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataLogs);
            this.Controls.Add(this.lblLogs);
            this.Name = "Logs";
            this.Text = "Total Logs";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Logs_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataLogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblLogs;
        private DataGridView dataLogs;
        private Button btnBack;
    }
}