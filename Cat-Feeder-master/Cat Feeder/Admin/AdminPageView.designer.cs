
namespace Cat_Feeder
{
    partial class AdminPageView
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
            this.timtableButton = new System.Windows.Forms.Button();
            this.monitorFeederButton = new System.Windows.Forms.Button();
            this.logButton = new System.Windows.Forms.Button();
            this.regButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timtableButton
            // 
            this.timtableButton.Location = new System.Drawing.Point(8, 222);
            this.timtableButton.Name = "timtableButton";
            this.timtableButton.Size = new System.Drawing.Size(580, 63);
            this.timtableButton.TabIndex = 12;
            this.timtableButton.Text = "Расписания";
            this.timtableButton.UseVisualStyleBackColor = true;
            this.timtableButton.Click += new System.EventHandler(this.timtableButton_Click);
            // 
            // monitorFeederButton
            // 
            this.monitorFeederButton.Location = new System.Drawing.Point(8, 84);
            this.monitorFeederButton.Name = "monitorFeederButton";
            this.monitorFeederButton.Size = new System.Drawing.Size(580, 63);
            this.monitorFeederButton.TabIndex = 13;
            this.monitorFeederButton.Text = "Мониторинг кормушек";
            this.monitorFeederButton.UseVisualStyleBackColor = true;
            this.monitorFeederButton.Click += new System.EventHandler(this.monitorFeederButton_Click);
            // 
            // logButton
            // 
            this.logButton.Location = new System.Drawing.Point(8, 153);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(580, 63);
            this.logButton.TabIndex = 14;
            this.logButton.Text = "Логи";
            this.logButton.UseVisualStyleBackColor = true;
            this.logButton.Click += new System.EventHandler(this.logButton_Click);
            // 
            // regButton
            // 
            this.regButton.Location = new System.Drawing.Point(8, 15);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(580, 63);
            this.regButton.TabIndex = 15;
            this.regButton.Text = "Зарегистрировать пользователя";
            this.regButton.UseVisualStyleBackColor = true;
            this.regButton.Click += new System.EventHandler(this.regButton_Click_1);
            // 
            // AdminPageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 301);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.logButton);
            this.Controls.Add(this.monitorFeederButton);
            this.Controls.Add(this.timtableButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "AdminPageView";
            this.Text = "AdminPage";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button timtableButton;
        private System.Windows.Forms.Button monitorFeederButton;
        private System.Windows.Forms.Button logButton;
        private System.Windows.Forms.Button regButton;
    }
}