namespace WindowsFormsApplication1
{
    partial class exerciceInputSign
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageSign = new System.Windows.Forms.PictureBox();
            this.inputSign = new System.Windows.Forms.TextBox();
            this.labelSign = new System.Windows.Forms.Label();
            this.buttonValidate = new System.Windows.Forms.Button();
            this.textSignName = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.textProgress = new System.Windows.Forms.Label();
            this.textScore = new System.Windows.Forms.Label();
            this.textFinalScore = new System.Windows.Forms.Label();
            this.labelCorrectAnswers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSign)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-23, -45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // imageSign
            // 
            this.imageSign.Location = new System.Drawing.Point(40, 89);
            this.imageSign.Name = "imageSign";
            this.imageSign.Size = new System.Drawing.Size(486, 466);
            this.imageSign.TabIndex = 1;
            this.imageSign.TabStop = false;
            // 
            // inputSign
            // 
            this.inputSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.inputSign.Location = new System.Drawing.Point(104, 579);
            this.inputSign.Name = "inputSign";
            this.inputSign.Size = new System.Drawing.Size(306, 29);
            this.inputSign.TabIndex = 2;
            this.inputSign.TextChanged += new System.EventHandler(this.inputSign_TextChanged);
            // 
            // labelSign
            // 
            this.labelSign.AutoSize = true;
            this.labelSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelSign.Location = new System.Drawing.Point(35, 579);
            this.labelSign.Name = "labelSign";
            this.labelSign.Size = new System.Drawing.Size(63, 25);
            this.labelSign.TabIndex = 3;
            this.labelSign.Text = "Sign: ";
            // 
            // buttonValidate
            // 
            this.buttonValidate.Location = new System.Drawing.Point(426, 579);
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.Size = new System.Drawing.Size(100, 29);
            this.buttonValidate.TabIndex = 4;
            this.buttonValidate.Text = "Validate";
            this.buttonValidate.UseVisualStyleBackColor = true;
            this.buttonValidate.Click += new System.EventHandler(this.buttonValidate_Click);
            // 
            // textSignName
            // 
            this.textSignName.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textSignName.Location = new System.Drawing.Point(62, 25);
            this.textSignName.Name = "textSignName";
            this.textSignName.Size = new System.Drawing.Size(444, 61);
            this.textSignName.TabIndex = 5;
            this.textSignName.Text = "sign name";
            this.textSignName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonNext.Location = new System.Drawing.Point(578, 560);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(143, 67);
            this.buttonNext.TabIndex = 6;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // textProgress
            // 
            this.textProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textProgress.Location = new System.Drawing.Point(564, 113);
            this.textProgress.Name = "textProgress";
            this.textProgress.Size = new System.Drawing.Size(157, 63);
            this.textProgress.TabIndex = 7;
            this.textProgress.Text = "x/y";
            this.textProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textScore
            // 
            this.textScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textScore.Location = new System.Drawing.Point(570, 336);
            this.textScore.Name = "textScore";
            this.textScore.Size = new System.Drawing.Size(151, 39);
            this.textScore.TabIndex = 8;
            this.textScore.Text = "x/y";
            this.textScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textFinalScore
            // 
            this.textFinalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textFinalScore.Location = new System.Drawing.Point(546, 467);
            this.textFinalScore.Name = "textFinalScore";
            this.textFinalScore.Size = new System.Drawing.Size(198, 63);
            this.textFinalScore.TabIndex = 9;
            this.textFinalScore.Text = "x%";
            this.textFinalScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCorrectAnswers
            // 
            this.labelCorrectAnswers.AutoSize = true;
            this.labelCorrectAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelCorrectAnswers.Location = new System.Drawing.Point(582, 301);
            this.labelCorrectAnswers.Name = "labelCorrectAnswers";
            this.labelCorrectAnswers.Size = new System.Drawing.Size(124, 20);
            this.labelCorrectAnswers.TabIndex = 10;
            this.labelCorrectAnswers.Text = "Correct answers";
            // 
            // exerciceInputSign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 643);
            this.Controls.Add(this.labelCorrectAnswers);
            this.Controls.Add(this.textFinalScore);
            this.Controls.Add(this.textScore);
            this.Controls.Add(this.textProgress);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.textSignName);
            this.Controls.Add(this.buttonValidate);
            this.Controls.Add(this.labelSign);
            this.Controls.Add(this.inputSign);
            this.Controls.Add(this.imageSign);
            this.Controls.Add(this.pictureBox1);
            this.Name = "exerciceInputSign";
            this.Text = "exerciceInputSign";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSign)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox imageSign;
        private System.Windows.Forms.TextBox inputSign;
        private System.Windows.Forms.Label labelSign;
        private System.Windows.Forms.Button buttonValidate;
        private System.Windows.Forms.Label textSignName;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label textProgress;
        private System.Windows.Forms.Label textScore;
        private System.Windows.Forms.Label textFinalScore;
        private System.Windows.Forms.Label labelCorrectAnswers;
    }
}