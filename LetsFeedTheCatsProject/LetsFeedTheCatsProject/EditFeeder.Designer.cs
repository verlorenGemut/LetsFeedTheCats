namespace LetsFeedTheCatsProject
{
    partial class EditFeeder
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
            this.lblEditFeeder = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblLabels = new System.Windows.Forms.Label();
            this.lblFeedType = new System.Windows.Forms.Label();
            this.btnImportSchedule = new System.Windows.Forms.Button();
            this.lblSchedule = new System.Windows.Forms.Label();
            this.lblFeederType = new System.Windows.Forms.Label();
            this.cbFeederType = new System.Windows.Forms.ComboBox();
            this.cbFeedType = new System.Windows.Forms.ComboBox();
            this.tbLabels = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.Font = new System.Drawing.Font("Snap ITC", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(15, 16);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(198, 90);
            this.btnBack.TabIndex = 34;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblEditFeeder
            // 
            this.lblEditFeeder.AutoSize = true;
            this.lblEditFeeder.Font = new System.Drawing.Font("Snap ITC", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEditFeeder.Location = new System.Drawing.Point(219, 108);
            this.lblEditFeeder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditFeeder.Name = "lblEditFeeder";
            this.lblEditFeeder.Size = new System.Drawing.Size(514, 90);
            this.lblEditFeeder.TabIndex = 35;
            this.lblEditFeeder.Text = "Edit Feeder";
            this.lblEditFeeder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoSize = true;
            this.btnSubmit.Font = new System.Drawing.Font("Snap ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.Location = new System.Drawing.Point(279, 615);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(408, 90);
            this.btnSubmit.TabIndex = 54;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Visible = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblLabels
            // 
            this.lblLabels.AutoSize = true;
            this.lblLabels.Font = new System.Drawing.Font("Snap ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLabels.Location = new System.Drawing.Point(248, 519);
            this.lblLabels.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLabels.Name = "lblLabels";
            this.lblLabels.Size = new System.Drawing.Size(181, 51);
            this.lblLabels.TabIndex = 53;
            this.lblLabels.Text = "Labels:";
            this.lblLabels.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLabels.Visible = false;
            // 
            // lblFeedType
            // 
            this.lblFeedType.AutoSize = true;
            this.lblFeedType.Font = new System.Drawing.Font("Snap ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFeedType.Location = new System.Drawing.Point(166, 429);
            this.lblFeedType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFeedType.Name = "lblFeedType";
            this.lblFeedType.Size = new System.Drawing.Size(267, 51);
            this.lblFeedType.TabIndex = 52;
            this.lblFeedType.Text = "Feed Type:";
            this.lblFeedType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFeedType.Visible = false;
            // 
            // btnImportSchedule
            // 
            this.btnImportSchedule.AutoSize = true;
            this.btnImportSchedule.Font = new System.Drawing.Font("Snap ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnImportSchedule.Location = new System.Drawing.Point(508, 315);
            this.btnImportSchedule.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnImportSchedule.Name = "btnImportSchedule";
            this.btnImportSchedule.Size = new System.Drawing.Size(212, 90);
            this.btnImportSchedule.TabIndex = 51;
            this.btnImportSchedule.Text = "Import";
            this.btnImportSchedule.UseVisualStyleBackColor = true;
            this.btnImportSchedule.Visible = false;
            this.btnImportSchedule.Click += new System.EventHandler(this.btnImportSchedule_Click);
            // 
            // lblSchedule
            // 
            this.lblSchedule.AutoSize = true;
            this.lblSchedule.Font = new System.Drawing.Font("Snap ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSchedule.Location = new System.Drawing.Point(219, 331);
            this.lblSchedule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSchedule.Name = "lblSchedule";
            this.lblSchedule.Size = new System.Drawing.Size(212, 51);
            this.lblSchedule.TabIndex = 50;
            this.lblSchedule.Text = "Shedule:";
            this.lblSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSchedule.Visible = false;
            // 
            // lblFeederType
            // 
            this.lblFeederType.AutoSize = true;
            this.lblFeederType.Font = new System.Drawing.Font("Snap ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFeederType.Location = new System.Drawing.Point(119, 231);
            this.lblFeederType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFeederType.Name = "lblFeederType";
            this.lblFeederType.Size = new System.Drawing.Size(316, 51);
            this.lblFeederType.TabIndex = 49;
            this.lblFeederType.Text = "Feeder Type:";
            this.lblFeederType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFeederType.Visible = false;
            // 
            // cbFeederType
            // 
            this.cbFeederType.Font = new System.Drawing.Font("Snap ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbFeederType.FormattingEnabled = true;
            this.cbFeederType.Location = new System.Drawing.Point(508, 229);
            this.cbFeederType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFeederType.Name = "cbFeederType";
            this.cbFeederType.Size = new System.Drawing.Size(382, 59);
            this.cbFeederType.TabIndex = 55;
            this.cbFeederType.Text = "With dispenser";
            this.cbFeederType.Visible = false;
            // 
            // cbFeedType
            // 
            this.cbFeedType.Font = new System.Drawing.Font("Snap ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbFeedType.FormattingEnabled = true;
            this.cbFeedType.Location = new System.Drawing.Point(508, 441);
            this.cbFeedType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFeedType.Name = "cbFeedType";
            this.cbFeedType.Size = new System.Drawing.Size(250, 59);
            this.cbFeedType.TabIndex = 56;
            this.cbFeedType.Text = "Wet feed";
            this.cbFeedType.Visible = false;
            // 
            // tbLabels
            // 
            this.tbLabels.Font = new System.Drawing.Font("Snap ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbLabels.Location = new System.Drawing.Point(508, 519);
            this.tbLabels.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLabels.Name = "tbLabels";
            this.tbLabels.Size = new System.Drawing.Size(410, 59);
            this.tbLabels.TabIndex = 57;
            this.tbLabels.Text = "#kittens";
            this.tbLabels.Visible = false;
            // 
            // EditFeeder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 752);
            this.Controls.Add(this.tbLabels);
            this.Controls.Add(this.cbFeedType);
            this.Controls.Add(this.cbFeederType);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblLabels);
            this.Controls.Add(this.lblFeedType);
            this.Controls.Add(this.btnImportSchedule);
            this.Controls.Add(this.lblSchedule);
            this.Controls.Add(this.lblFeederType);
            this.Controls.Add(this.lblEditFeeder);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditFeeder";
            this.Text = "Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBack;
        private Label lblEditFeeder;
        private Button btnSubmit;
        private Label lblLabels;
        private Label lblFeedType;
        private Button btnImportSchedule;
        private Label lblSchedule;
        private Label lblFeederType;
        private ComboBox cbFeederType;
        private ComboBox cbFeedType;
        private TextBox tbLabels;
    }
}