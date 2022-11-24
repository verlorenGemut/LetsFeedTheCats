namespace LetsFeedTheCatsProject
{
    partial class Schedule
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
            this.lblHowMuchFood = new System.Windows.Forms.Label();
            this.lblWhenToFeed = new System.Windows.Forms.Label();
            this.lblShedule = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblWhenToFeedText = new System.Windows.Forms.Label();
            this.lblHowMuchFoodText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHowMuchFood
            // 
            this.lblHowMuchFood.AutoSize = true;
            this.lblHowMuchFood.Font = new System.Drawing.Font("Snap ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHowMuchFood.Location = new System.Drawing.Point(81, 317);
            this.lblHowMuchFood.Name = "lblHowMuchFood";
            this.lblHowMuchFood.Size = new System.Drawing.Size(339, 44);
            this.lblHowMuchFood.TabIndex = 67;
            this.lblHowMuchFood.Text = "How much Food?";
            this.lblHowMuchFood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHowMuchFood.Visible = false;
            // 
            // lblWhenToFeed
            // 
            this.lblWhenToFeed.AutoSize = true;
            this.lblWhenToFeed.Font = new System.Drawing.Font("Snap ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWhenToFeed.Location = new System.Drawing.Point(81, 193);
            this.lblWhenToFeed.Name = "lblWhenToFeed";
            this.lblWhenToFeed.Size = new System.Drawing.Size(302, 44);
            this.lblWhenToFeed.TabIndex = 66;
            this.lblWhenToFeed.Text = "When to feed?";
            this.lblWhenToFeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWhenToFeed.Visible = false;
            // 
            // lblShedule
            // 
            this.lblShedule.AutoSize = true;
            this.lblShedule.Font = new System.Drawing.Font("Snap ITC", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblShedule.Location = new System.Drawing.Point(249, 89);
            this.lblShedule.Name = "lblShedule";
            this.lblShedule.Size = new System.Drawing.Size(291, 76);
            this.lblShedule.TabIndex = 65;
            this.lblShedule.Text = "Shedule";
            this.lblShedule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.Font = new System.Drawing.Font("Snap ITC", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(12, 13);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(158, 72);
            this.btnBack.TabIndex = 64;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.Font = new System.Drawing.Font("Snap ITC", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Location = new System.Drawing.Point(176, 13);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(158, 72);
            this.btnEdit.TabIndex = 68;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblWhenToFeedText
            // 
            this.lblWhenToFeedText.AutoSize = true;
            this.lblWhenToFeedText.Font = new System.Drawing.Font("Snap ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWhenToFeedText.Location = new System.Drawing.Point(140, 259);
            this.lblWhenToFeedText.Name = "lblWhenToFeedText";
            this.lblWhenToFeedText.Size = new System.Drawing.Size(430, 44);
            this.lblWhenToFeedText.TabIndex = 69;
            this.lblWhenToFeedText.Text = "every <number> hours";
            this.lblWhenToFeedText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWhenToFeedText.Visible = false;
            // 
            // lblHowMuchFoodText
            // 
            this.lblHowMuchFoodText.AutoSize = true;
            this.lblHowMuchFoodText.Font = new System.Drawing.Font("Snap ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHowMuchFoodText.Location = new System.Drawing.Point(140, 382);
            this.lblHowMuchFoodText.Name = "lblHowMuchFoodText";
            this.lblHowMuchFoodText.Size = new System.Drawing.Size(113, 44);
            this.lblHowMuchFoodText.TabIndex = 70;
            this.lblHowMuchFoodText.Text = "50 g";
            this.lblHowMuchFoodText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHowMuchFoodText.Visible = false;
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHowMuchFoodText);
            this.Controls.Add(this.lblWhenToFeedText);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblHowMuchFood);
            this.Controls.Add(this.lblWhenToFeed);
            this.Controls.Add(this.lblShedule);
            this.Controls.Add(this.btnBack);
            this.Name = "Schedule";
            this.Text = "Schedule";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Schedule_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblHowMuchFood;
        private Label lblWhenToFeed;
        private Label lblShedule;
        private Button btnBack;
        private Button btnEdit;
        private Label lblWhenToFeedText;
        private Label lblHowMuchFoodText;
    }
}