﻿namespace LetsFeedTheCatsProject
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
            this.btnBack.Location = new System.Drawing.Point(12, 13);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(158, 72);
            this.btnBack.TabIndex = 35;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblEditShedule
            // 
            this.lblEditShedule.AutoSize = true;
            this.lblEditShedule.Font = new System.Drawing.Font("Snap ITC", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEditShedule.Location = new System.Drawing.Point(137, 89);
            this.lblEditShedule.Name = "lblEditShedule";
            this.lblEditShedule.Size = new System.Drawing.Size(520, 76);
            this.lblEditShedule.TabIndex = 36;
            this.lblEditShedule.Text = "Edit Shedule 1";
            this.lblEditShedule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWhenToFeed
            // 
            this.lblWhenToFeed.AutoSize = true;
            this.lblWhenToFeed.Font = new System.Drawing.Font("Snap ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWhenToFeed.Location = new System.Drawing.Point(81, 193);
            this.lblWhenToFeed.Name = "lblWhenToFeed";
            this.lblWhenToFeed.Size = new System.Drawing.Size(302, 44);
            this.lblWhenToFeed.TabIndex = 50;
            this.lblWhenToFeed.Text = "When to feed?";
            this.lblWhenToFeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWhenToFeed.Visible = false;
            // 
            // rbtnHours
            // 
            this.rbtnHours.AutoSize = true;
            this.rbtnHours.Font = new System.Drawing.Font("Snap ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnHours.Location = new System.Drawing.Point(137, 250);
            this.rbtnHours.Name = "rbtnHours";
            this.rbtnHours.Size = new System.Drawing.Size(150, 48);
            this.rbtnHours.TabIndex = 51;
            this.rbtnHours.TabStop = true;
            this.rbtnHours.Text = "every";
            this.rbtnHours.UseVisualStyleBackColor = true;
            // 
            // tbHours
            // 
            this.tbHours.Font = new System.Drawing.Font("Snap ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbHours.Location = new System.Drawing.Point(293, 250);
            this.tbHours.Name = "tbHours";
            this.tbHours.Size = new System.Drawing.Size(136, 50);
            this.tbHours.TabIndex = 58;
            this.tbHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHours_KeyPress);
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Snap ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHours.Location = new System.Drawing.Point(435, 252);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(123, 44);
            this.lblHours.TabIndex = 59;
            this.lblHours.Text = "hours";
            this.lblHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHours.Visible = false;
            // 
            // rbtnEveryday
            // 
            this.rbtnEveryday.AutoSize = true;
            this.rbtnEveryday.Font = new System.Drawing.Font("Snap ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnEveryday.Location = new System.Drawing.Point(137, 313);
            this.rbtnEveryday.Name = "rbtnEveryday";
            this.rbtnEveryday.Size = new System.Drawing.Size(272, 48);
            this.rbtnEveryday.TabIndex = 60;
            this.rbtnEveryday.TabStop = true;
            this.rbtnEveryday.Text = "everyday at";
            this.rbtnEveryday.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Snap ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(415, 313);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 50);
            this.textBox1.TabIndex = 61;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // cbAmPm
            // 
            this.cbAmPm.Font = new System.Drawing.Font("Snap ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbAmPm.FormattingEnabled = true;
            this.cbAmPm.Items.AddRange(new object[] {
            "am",
            "pm"});
            this.cbAmPm.Location = new System.Drawing.Point(557, 313);
            this.cbAmPm.Name = "cbAmPm";
            this.cbAmPm.Size = new System.Drawing.Size(100, 51);
            this.cbAmPm.TabIndex = 62;
            // 
            // lblHowMuchFood
            // 
            this.lblHowMuchFood.AutoSize = true;
            this.lblHowMuchFood.Font = new System.Drawing.Font("Snap ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHowMuchFood.Location = new System.Drawing.Point(81, 400);
            this.lblHowMuchFood.Name = "lblHowMuchFood";
            this.lblHowMuchFood.Size = new System.Drawing.Size(339, 44);
            this.lblHowMuchFood.TabIndex = 63;
            this.lblHowMuchFood.Text = "How much Food?";
            this.lblHowMuchFood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHowMuchFood.Visible = false;
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Font = new System.Drawing.Font("Snap ITC", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblG.Location = new System.Drawing.Point(317, 450);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(50, 54);
            this.lblG.TabIndex = 65;
            this.lblG.Text = "g";
            this.lblG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbAddFeed
            // 
            this.tbAddFeed.Font = new System.Drawing.Font("Snap ITC", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAddFeed.Location = new System.Drawing.Point(173, 448);
            this.tbAddFeed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbAddFeed.Name = "tbAddFeed";
            this.tbAddFeed.Size = new System.Drawing.Size(114, 61);
            this.tbAddFeed.TabIndex = 64;
            this.tbAddFeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAddFeed_KeyPress);
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoSize = true;
            this.btnSubmit.Font = new System.Drawing.Font("Snap ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.Location = new System.Drawing.Point(225, 532);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(326, 72);
            this.btnSubmit.TabIndex = 66;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Visible = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // EditShedule1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 617);
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
            this.Name = "EditShedule1";
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