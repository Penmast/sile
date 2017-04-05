namespace WindowsFormsApplication1
{
    partial class exerciceImageMultipleChoices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(exerciceImageMultipleChoices));
            this.image3 = new System.Windows.Forms.PictureBox();
            this.image4 = new System.Windows.Forms.PictureBox();
            this.image1 = new System.Windows.Forms.PictureBox();
            this.image2 = new System.Windows.Forms.PictureBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.textProgress = new System.Windows.Forms.Label();
            this.textCorrectAnswers = new System.Windows.Forms.Label();
            this.textFinalScore = new System.Windows.Forms.Label();
            this.labelCorrectAnswers = new System.Windows.Forms.Label();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textSignName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.image3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // image3
            // 
            this.image3.Location = new System.Drawing.Point(76, 451);
            this.image3.Name = "image3";
            this.image3.Size = new System.Drawing.Size(200, 176);
            this.image3.TabIndex = 0;
            this.image3.TabStop = false;
            this.image3.Click += new System.EventHandler(this.check_answer);
            // 
            // image4
            // 
            this.image4.Location = new System.Drawing.Point(76, 195);
            this.image4.Name = "image4";
            this.image4.Size = new System.Drawing.Size(200, 176);
            this.image4.TabIndex = 1;
            this.image4.TabStop = false;
            this.image4.Click += new System.EventHandler(this.check_answer);
            // 
            // image1
            // 
            this.image1.Location = new System.Drawing.Point(319, 451);
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(189, 176);
            this.image1.TabIndex = 2;
            this.image1.TabStop = false;
            this.image1.Click += new System.EventHandler(this.check_answer);
            // 
            // image2
            // 
            this.image2.Location = new System.Drawing.Point(319, 195);
            this.image2.Name = "image2";
            this.image2.Size = new System.Drawing.Size(189, 176);
            this.image2.TabIndex = 3;
            this.image2.TabStop = false;
            this.image2.Click += new System.EventHandler(this.check_answer);
            // 
            // buttonNext
            // 
            this.buttonNext.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonNext.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonNext.Location = new System.Drawing.Point(676, 601);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(144, 70);
            this.buttonNext.TabIndex = 5;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // textProgress
            // 
            this.textProgress.BackColor = System.Drawing.Color.White;
            this.textProgress.Font = new System.Drawing.Font("Segoe Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textProgress.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textProgress.Location = new System.Drawing.Point(482, 61);
            this.textProgress.Name = "textProgress";
            this.textProgress.Size = new System.Drawing.Size(179, 66);
            this.textProgress.TabIndex = 6;
            this.textProgress.Text = "x/y";
            this.textProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.textProgress.Click += new System.EventHandler(this.textProgress_Click);
            // 
            // textCorrectAnswers
            // 
            this.textCorrectAnswers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textCorrectAnswers.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCorrectAnswers.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textCorrectAnswers.Location = new System.Drawing.Point(694, 362);
            this.textCorrectAnswers.Name = "textCorrectAnswers";
            this.textCorrectAnswers.Size = new System.Drawing.Size(179, 66);
            this.textCorrectAnswers.TabIndex = 7;
            this.textCorrectAnswers.Text = "x/y";
            this.textCorrectAnswers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textFinalScore
            // 
            this.textFinalScore.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textFinalScore.Font = new System.Drawing.Font("Verdana", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFinalScore.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textFinalScore.Location = new System.Drawing.Point(656, 475);
            this.textFinalScore.Name = "textFinalScore";
            this.textFinalScore.Size = new System.Drawing.Size(246, 66);
            this.textFinalScore.TabIndex = 8;
            this.textFinalScore.Text = "xxx%";
            this.textFinalScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCorrectAnswers
            // 
            this.labelCorrectAnswers.AutoSize = true;
            this.labelCorrectAnswers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelCorrectAnswers.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorrectAnswers.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelCorrectAnswers.Location = new System.Drawing.Point(662, 320);
            this.labelCorrectAnswers.Name = "labelCorrectAnswers";
            this.labelCorrectAnswers.Size = new System.Drawing.Size(232, 29);
            this.labelCorrectAnswers.TabIndex = 9;
            this.labelCorrectAnswers.Text = "Correct answers";
            this.labelCorrectAnswers.Click += new System.EventHandler(this.labelCorrectAnswers_Click);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.Color.White;
            this.rectangleShape1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rectangleShape1.BackgroundImage")));
            this.rectangleShape1.Location = new System.Drawing.Point(1, 132);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(1009, 554);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape3,
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1008, 730);
            this.shapeContainer1.TabIndex = 10;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape3
            // 
            this.rectangleShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape3.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.rectangleShape3.BorderWidth = 5;
            this.rectangleShape3.FillColor = System.Drawing.SystemColors.HotTrack;
            this.rectangleShape3.Location = new System.Drawing.Point(12, 163);
            this.rectangleShape3.Name = "rectangleShape3";
            this.rectangleShape3.Size = new System.Drawing.Size(504, 493);
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape2.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.rectangleShape2.Location = new System.Drawing.Point(640, 159);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(282, 405);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(667, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 124);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(430, 708);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Copyright 2017\r\n";
            // 
            // textSignName
            // 
            this.textSignName.Font = new System.Drawing.Font("Segoe Print", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSignName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textSignName.Location = new System.Drawing.Point(62, 20);
            this.textSignName.Name = "textSignName";
            this.textSignName.Size = new System.Drawing.Size(435, 64);
            this.textSignName.TabIndex = 4;
            this.textSignName.Text = "SIGN NAME";
            this.textSignName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exerciceImageMultipleChoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelCorrectAnswers);
            this.Controls.Add(this.textFinalScore);
            this.Controls.Add(this.textCorrectAnswers);
            this.Controls.Add(this.textProgress);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.textSignName);
            this.Controls.Add(this.image2);
            this.Controls.Add(this.image1);
            this.Controls.Add(this.image4);
            this.Controls.Add(this.image3);
            this.Controls.Add(this.shapeContainer1);
            this.MaximizeBox = false;
            this.Name = "exerciceImageMultipleChoices";
            this.Text = "exerciceImageMultipleChoices";
            ((System.ComponentModel.ISupportInitialize)(this.image3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox image3;
        private System.Windows.Forms.PictureBox image4;
        private System.Windows.Forms.PictureBox image1;
        private System.Windows.Forms.PictureBox image2;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label textProgress;
        private System.Windows.Forms.Label textCorrectAnswers;
        private System.Windows.Forms.Label textFinalScore;
        private System.Windows.Forms.Label labelCorrectAnswers;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape3;
        private System.Windows.Forms.Label textSignName;
    }
}