namespace LetsFeedTheCatsProject
{
    partial class EditShedule
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
            this.lblEditShedule = new System.Windows.Forms.Label();
            this.lblWhenToFeed = new System.Windows.Forms.Label();
            this.rbtnHours = new System.Windows.Forms.RadioButton();
            this.tbHours = new System.Windows.Forms.TextBox();
            this.lblHours = new System.Windows.Forms.Label();
            this.rbtnEveryday = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbAmPm = new System.Windows.Forms.ComboBox();
            this.lblHowMuchFood = new System.Windows.Forms.Label();
            this.lblG = new System.Windows.Forms.Label();
            this.tbAddFeed = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
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
            this.btnBack.TabIndex = 35;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblEditShedule
            // 
            this.lblEditShedule.AutoSize = true;
            this.lblEditShedule.Font = new System.Drawing.Font("Snap ITC", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEditShedule.Location = new System.Drawing.Point(171, 111);
            this.lblEditShedule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditShedule.Name = "lblEditShedule";
            this.lblEditShedule.Size = new System.Drawing.Size(616, 90);
            this.lblEditShedule.TabIndex = 36;
            this.lblEditShedule.Text = "Edit Shedule 1";
            this.lblEditShedule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWhenToFeed
            // 
            this.lblWhenToFeed.AutoSize = true;
            this.lblWhenToFeed.Font = new System.Drawing.Font("Snap ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWhenToFeed.Location = new System.Drawing.Point(101, 241);
            this.lblWhenToFeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWhenToFeed.Name = "lblWhenToFeed";
            this.lblWhenToFeed.Size = new System.Drawing.Size(355, 51);
            this.lblWhenToFeed.TabIndex = 50;
            this.lblWhenToFeed.Text = "When to feed?";
            this.lblWhenToFeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWhenToFeed.Visible = false;
            // 
            // rbtnHours
            // 
            this.rbtnHours.AutoSize = true;
            this.rbtnHours.Font = new System.Drawing.Font("Snap ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnHours.Location = new System.Drawing.Point(171, 312);
            this.rbtnHours.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnHours.Name = "rbtnHours";
            this.rbtnHours.Size = new System.Drawing.Size(177, 55);
            this.rbtnHours.TabIndex = 51;
            this.rbtnHours.TabStop = true;
            this.rbtnHours.Text = "every";
            this.rbtnHours.UseVisualStyleBackColor = true;
            // 
            // tbHours
            // 
            this.tbHours.Font = new System.Drawing.Font("Snap ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbHours.Location = new System.Drawing.Point(366, 312);
            this.tbHours.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbHours.Name = "tbHours";
            this.tbHours.Size = new System.Drawing.Size(169, 59);
            this.tbHours.TabIndex = 58;
            this.tbHours.Text = "3";
            this.tbHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHours_KeyPress);
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Snap ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHours.Location = new System.Drawing.Point(544, 315);
            this.lblHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(145, 51);
            this.lblHours.TabIndex = 59;
            this.lblHours.Text = "hours";
            this.lblHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHours.Visible = false;
            // 
            // rbtnEveryday
            // 
            this.rbtnEveryday.AutoSize = true;
            this.rbtnEveryday.Font = new System.Drawing.Font("Snap ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnEveryday.Location = new System.Drawing.Point(171, 391);
            this.rbtnEveryday.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnEveryday.Name = "rbtnEveryday";
            this.rbtnEveryday.Size = new System.Drawing.Size(321, 55);
            this.rbtnEveryday.TabIndex = 60;
            this.rbtnEveryday.TabStop = true;
            this.rbtnEveryday.Text = "everyday at";
            this.rbtnEveryday.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Snap ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(519, 391);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 59);
            this.textBox1.TabIndex = 61;
            this.textBox1.Text = "11";
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // cbAmPm
            // 
            this.cbAmPm.Font = new System.Drawing.Font("Snap ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbAmPm.FormattingEnabled = true;
            this.cbAmPm.Items.AddRange(new object[] {
            "am",
            "pm"});
            this.cbAmPm.Location = new System.Drawing.Point(696, 391);
            this.cbAmPm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbAmPm.Name = "cbAmPm";
            this.cbAmPm.Size = new System.Drawing.Size(124, 59);
            this.cbAmPm.TabIndex = 62;
            this.cbAmPm.Text = "am";
            // 
            // lblHowMuchFood
            // 
            this.lblHowMuchFood.AutoSize = true;
            this.lblHowMuchFood.Font = new System.Drawing.Font("Snap ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHowMuchFood.Location = new System.Drawing.Point(101, 500);
            this.lblHowMuchFood.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHowMuchFood.Name = "lblHowMuchFood";
            this.lblHowMuchFood.Size = new System.Drawing.Size(398, 51);
            this.lblHowMuchFood.TabIndex = 63;
            this.lblHowMuchFood.Text = "How much Food?";
            this.lblHowMuchFood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHowMuchFood.Visible = false;
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Font = new System.Drawing.Font("Snap ITC", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblG.Location = new System.Drawing.Point(396, 562);
            this.lblG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(60, 64);
            this.lblG.TabIndex = 65;
            this.lblG.Text = "g";
            this.lblG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbAddFeed
            // 
            this.tbAddFeed.Font = new System.Drawing.Font("Snap ITC", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAddFeed.Location = new System.Drawing.Point(216, 560);
            this.tbAddFeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAddFeed.Name = "tbAddFeed";
            this.tbAddFeed.Size = new System.Drawing.Size(142, 72);
            this.tbAddFeed.TabIndex = 64;
            this.tbAddFeed.Text = "50";
            this.tbAddFeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAddFeed_KeyPress);
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoSize = true;
            this.btnSubmit.Font = new System.Drawing.Font("Snap ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.Location = new System.Drawing.Point(281, 665);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(408, 90);
            this.btnSubmit.TabIndex = 66;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Visible = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // EditShedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 771);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.tbAddFeed);
            this.Controls.Add(this.lblHowMuchFood);
            this.Controls.Add(this.cbAmPm);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rbtnEveryday);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.tbHours);
            this.Controls.Add(this.rbtnHours);
            this.Controls.Add(this.lblWhenToFeed);
            this.Controls.Add(this.lblEditShedule);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditShedule";
            this.Text = "EditShedule1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBack;
        private Label lblEditShedule;
        private Label lblWhenToFeed;
        private RadioButton rbtnHours;
        private TextBox tbHours;
        private Label lblHours;
        private RadioButton rbtnEveryday;
        private TextBox textBox1;
        private ComboBox cbAmPm;
        private Label lblHowMuchFood;
        private Label lblG;
        private TextBox tbAddFeed;
        private Button btnSubmit;
    }
}