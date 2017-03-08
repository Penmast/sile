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
            this.image3 = new System.Windows.Forms.PictureBox();
            this.image4 = new System.Windows.Forms.PictureBox();
            this.image1 = new System.Windows.Forms.PictureBox();
            this.image2 = new System.Windows.Forms.PictureBox();
            this.textSignName = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.textProgress = new System.Windows.Forms.Label();
            this.textCorrectAnswers = new System.Windows.Forms.Label();
            this.textFinalScore = new System.Windows.Forms.Label();
            this.labelCorrectAnswers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.image3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image2)).BeginInit();
            this.SuspendLayout();
            // 
            // image3
            // 
            this.image3.Location = new System.Drawing.Point(12, 376);
            this.image3.Name = "image3";
            this.image3.Size = new System.Drawing.Size(256, 257);
            this.image3.TabIndex = 0;
            this.image3.TabStop = false;
            this.image3.Click += new System.EventHandler(this.check_answer);
            // 
            // image4
            // 
            this.image4.Location = new System.Drawing.Point(288, 376);
            this.image4.Name = "image4";
            this.image4.Size = new System.Drawing.Size(256, 257);
            this.image4.TabIndex = 1;
            this.image4.TabStop = false;
            this.image4.Click += new System.EventHandler(this.check_answer);
            // 
            // image1
            // 
            this.image1.Location = new System.Drawing.Point(12, 100);
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(256, 257);
            this.image1.TabIndex = 2;
            this.image1.TabStop = false;
            this.image1.Click += new System.EventHandler(this.check_answer);
            // 
            // image2
            // 
            this.image2.Location = new System.Drawing.Point(288, 100);
            this.image2.Name = "image2";
            this.image2.Size = new System.Drawing.Size(256, 257);
            this.image2.TabIndex = 3;
            this.image2.TabStop = false;
            this.image2.Click += new System.EventHandler(this.check_answer);
            // 
            // textSignName
            // 
            this.textSignName.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textSignName.Location = new System.Drawing.Point(62, 20);
            this.textSignName.Name = "textSignName";
            this.textSignName.Size = new System.Drawing.Size(435, 64);
            this.textSignName.TabIndex = 4;
            this.textSignName.Text = "SIGN NAME";
            this.textSignName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonNext.Location = new System.Drawing.Point(565, 520);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(179, 113);
            this.buttonNext.TabIndex = 5;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // textProgress
            // 
            this.textProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textProgress.Location = new System.Drawing.Point(565, 100);
            this.textProgress.Name = "textProgress";
            this.textProgress.Size = new System.Drawing.Size(179, 66);
            this.textProgress.TabIndex = 6;
            this.textProgress.Text = "x/y";
            this.textProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textCorrectAnswers
            // 
            this.textCorrectAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textCorrectAnswers.Location = new System.Drawing.Point(565, 291);
            this.textCorrectAnswers.Name = "textCorrectAnswers";
            this.textCorrectAnswers.Size = new System.Drawing.Size(179, 66);
            this.textCorrectAnswers.TabIndex = 7;
            this.textCorrectAnswers.Text = "x/y";
            this.textCorrectAnswers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textFinalScore
            // 
            this.textFinalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textFinalScore.Location = new System.Drawing.Point(565, 451);
            this.textFinalScore.Name = "textFinalScore";
            this.textFinalScore.Size = new System.Drawing.Size(179, 66);
            this.textFinalScore.TabIndex = 8;
            this.textFinalScore.Text = "xxx%";
            this.textFinalScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCorrectAnswers
            // 
            this.labelCorrectAnswers.AutoSize = true;
            this.labelCorrectAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelCorrectAnswers.Location = new System.Drawing.Point(596, 291);
            this.labelCorrectAnswers.Name = "labelCorrectAnswers";
            this.labelCorrectAnswers.Size = new System.Drawing.Size(110, 17);
            this.labelCorrectAnswers.TabIndex = 9;
            this.labelCorrectAnswers.Text = "Correct answers";
            // 
            // exerciceImageMultipleChoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 645);
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
            this.Name = "exerciceImageMultipleChoices";
            this.Text = "exerciceImageMultipleChoices";
            ((System.ComponentModel.ISupportInitialize)(this.image3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox image3;
        private System.Windows.Forms.PictureBox image4;
        private System.Windows.Forms.PictureBox image1;
        private System.Windows.Forms.PictureBox image2;
        private System.Windows.Forms.Label textSignName;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label textProgress;
        private System.Windows.Forms.Label textCorrectAnswers;
        private System.Windows.Forms.Label textFinalScore;
        private System.Windows.Forms.Label labelCorrectAnswers;
    }
}