
namespace Cat_Feeder
{
    partial class UserMainPageView
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
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.timetableButton = new System.Windows.Forms.Button();
            this.logButton = new System.Windows.Forms.Button();
            this.createNoteButton = new System.Windows.Forms.Button();
            this.note4 = new System.Windows.Forms.Label();
            this.note3 = new System.Windows.Forms.Label();
            this.note2 = new System.Windows.Forms.Label();
            this.note1 = new System.Windows.Forms.Label();
            this.feeder1 = new System.Windows.Forms.PictureBox();
            this.feeder4 = new System.Windows.Forms.PictureBox();
            this.feeder3 = new System.Windows.Forms.PictureBox();
            this.feeder2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feeder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feeder4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feeder3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feeder2)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList3
            // 
            this.imageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList3.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.timetableButton);
            this.splitContainer1.Panel1.Controls.Add(this.logButton);
            this.splitContainer1.Panel1.Controls.Add(this.createNoteButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.note4);
            this.splitContainer1.Panel2.Controls.Add(this.note3);
            this.splitContainer1.Panel2.Controls.Add(this.note2);
            this.splitContainer1.Panel2.Controls.Add(this.note1);
            this.splitContainer1.Panel2.Controls.Add(this.feeder1);
            this.splitContainer1.Panel2.Controls.Add(this.feeder4);
            this.splitContainer1.Panel2.Controls.Add(this.feeder3);
            this.splitContainer1.Panel2.Controls.Add(this.feeder2);
            this.splitContainer1.Size = new System.Drawing.Size(929, 530);
            this.splitContainer1.SplitterDistance = 193;
            this.splitContainer1.TabIndex = 12;
            // 
            // timetableButton
            // 
            this.timetableButton.Location = new System.Drawing.Point(12, 160);
            this.timetableButton.Name = "timetableButton";
            this.timetableButton.Size = new System.Drawing.Size(171, 68);
            this.timetableButton.TabIndex = 11;
            this.timetableButton.Text = "Расписания";
            this.timetableButton.UseVisualStyleBackColor = true;
            this.timetableButton.Click += new System.EventHandler(this.timetableButton_Click);
            // 
            // logButton
            // 
            this.logButton.Location = new System.Drawing.Point(12, 86);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(171, 68);
            this.logButton.TabIndex = 10;
            this.logButton.Text = "Логи";
            this.logButton.UseVisualStyleBackColor = true;
            this.logButton.Click += new System.EventHandler(this.logButton_Click);
            // 
            // createNoteButton
            // 
            this.createNoteButton.AllowDrop = true;
            this.createNoteButton.Location = new System.Drawing.Point(12, 12);
            this.createNoteButton.Name = "createNoteButton";
            this.createNoteButton.Size = new System.Drawing.Size(171, 68);
            this.createNoteButton.TabIndex = 9;
            this.createNoteButton.Text = "Создать метку";
            this.createNoteButton.UseVisualStyleBackColor = true;
            this.createNoteButton.Click += new System.EventHandler(this.createNoteButton_Click);
            // 
            // note4
            // 
            this.note4.AutoSize = true;
            this.note4.Location = new System.Drawing.Point(148, 385);
            this.note4.Name = "note4";
            this.note4.Size = new System.Drawing.Size(65, 13);
            this.note4.TabIndex = 27;
            this.note4.Text = "Кормушка4";
            // 
            // note3
            // 
            this.note3.AutoSize = true;
            this.note3.Location = new System.Drawing.Point(370, 275);
            this.note3.Name = "note3";
            this.note3.Size = new System.Drawing.Size(65, 13);
            this.note3.TabIndex = 26;
            this.note3.Text = "Кормушка3";
            // 
            // note2
            // 
            this.note2.AutoSize = true;
            this.note2.Location = new System.Drawing.Point(320, 65);
            this.note2.Name = "note2";
            this.note2.Size = new System.Drawing.Size(65, 13);
            this.note2.TabIndex = 25;
            this.note2.Text = "Кормушка2";
            this.note2.Click += new System.EventHandler(this.note2_Click);
            // 
            // note1
            // 
            this.note1.AutoSize = true;
            this.note1.Location = new System.Drawing.Point(164, 160);
            this.note1.Name = "note1";
            this.note1.Size = new System.Drawing.Size(65, 13);
            this.note1.TabIndex = 24;
            this.note1.Text = "Кормушка1";
            this.note1.Click += new System.EventHandler(this.note1_Click);
            // 
            // feeder1
            // 
            this.feeder1.Image = global::Cat_Feeder.Properties.Resources.Feet;
            this.feeder1.Location = new System.Drawing.Point(235, 160);
            this.feeder1.Name = "feeder1";
            this.feeder1.Size = new System.Drawing.Size(73, 68);
            this.feeder1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.feeder1.TabIndex = 23;
            this.feeder1.TabStop = false;
            this.feeder1.Click += new System.EventHandler(this.feeder1_Click);
            // 
            // feeder4
            // 
            this.feeder4.Image = global::Cat_Feeder.Properties.Resources.Feet;
            this.feeder4.Location = new System.Drawing.Point(219, 375);
            this.feeder4.Name = "feeder4";
            this.feeder4.Size = new System.Drawing.Size(73, 68);
            this.feeder4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.feeder4.TabIndex = 22;
            this.feeder4.TabStop = false;
            this.feeder4.Click += new System.EventHandler(this.feeder4_Click);
            // 
            // feeder3
            // 
            this.feeder3.Image = global::Cat_Feeder.Properties.Resources.Feet;
            this.feeder3.Location = new System.Drawing.Point(441, 265);
            this.feeder3.Name = "feeder3";
            this.feeder3.Size = new System.Drawing.Size(73, 68);
            this.feeder3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.feeder3.TabIndex = 21;
            this.feeder3.TabStop = false;
            this.feeder3.Click += new System.EventHandler(this.feeder3_Click);
            // 
            // feeder2
            // 
            this.feeder2.Image = global::Cat_Feeder.Properties.Resources.Feet;
            this.feeder2.Location = new System.Drawing.Point(391, 53);
            this.feeder2.Name = "feeder2";
            this.feeder2.Size = new System.Drawing.Size(73, 68);
            this.feeder2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.feeder2.TabIndex = 20;
            this.feeder2.TabStop = false;
            this.feeder2.Click += new System.EventHandler(this.feeder2_Click);
            // 
            // UserMainPageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 530);
            this.Controls.Add(this.splitContainer1);
            this.Name = "UserMainPageView";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.UserMainPage_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.feeder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feeder4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feeder3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feeder2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button timetableButton;
        private System.Windows.Forms.Button logButton;
        private System.Windows.Forms.Button createNoteButton;
        private System.Windows.Forms.Label note4;
        private System.Windows.Forms.Label note3;
        private System.Windows.Forms.Label note2;
        private System.Windows.Forms.Label note1;
        private System.Windows.Forms.PictureBox feeder1;
        private System.Windows.Forms.PictureBox feeder4;
        private System.Windows.Forms.PictureBox feeder3;
        private System.Windows.Forms.PictureBox feeder2;
    }
}