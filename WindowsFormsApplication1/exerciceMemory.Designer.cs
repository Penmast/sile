namespace WindowsFormsApplication1
{
    partial class exerciceMemory
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
            this.imageSign = new System.Windows.Forms.PictureBox();
            this.textTitle = new System.Windows.Forms.Label();
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonEasy = new System.Windows.Forms.Button();
            this.buttonMedium = new System.Windows.Forms.Button();
            this.buttonHard = new System.Windows.Forms.Button();
            this.textProgress = new System.Windows.Forms.Label();
            this.buttonEnd = new System.Windows.Forms.Button();
            this.textAsk = new System.Windows.Forms.Label();
            this.textScore = new System.Windows.Forms.Label();
            this.buttonNotFound = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageSign)).BeginInit();
            this.SuspendLayout();
            // 
            // imageSign
            // 
            this.imageSign.Location = new System.Drawing.Point(70, 133);
            this.imageSign.Name = "imageSign";
            this.imageSign.Size = new System.Drawing.Size(434, 405);
            this.imageSign.TabIndex = 0;
            this.imageSign.TabStop = false;
            // 
            // textTitle
            // 
            this.textTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textTitle.Location = new System.Drawing.Point(95, 34);
            this.textTitle.MaximumSize = new System.Drawing.Size(500, 500);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(393, 82);
            this.textTitle.TabIndex = 1;
            this.textTitle.Text = "signName";
            this.textTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonShow
            // 
            this.buttonShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonShow.Location = new System.Drawing.Point(95, 554);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(393, 64);
            this.buttonShow.TabIndex = 2;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonEasy
            // 
            this.buttonEasy.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonEasy.Location = new System.Drawing.Point(544, 219);
            this.buttonEasy.Name = "buttonEasy";
            this.buttonEasy.Size = new System.Drawing.Size(168, 52);
            this.buttonEasy.TabIndex = 3;
            this.buttonEasy.Text = "Easy";
            this.buttonEasy.UseVisualStyleBackColor = true;
            this.buttonEasy.Click += new System.EventHandler(this.add_to_score);
            // 
            // buttonMedium
            // 
            this.buttonMedium.Location = new System.Drawing.Point(544, 277);
            this.buttonMedium.Name = "buttonMedium";
            this.buttonMedium.Size = new System.Drawing.Size(168, 49);
            this.buttonMedium.TabIndex = 4;
            this.buttonMedium.Text = "Medium";
            this.buttonMedium.UseVisualStyleBackColor = true;
            this.buttonMedium.Click += new System.EventHandler(this.add_to_score);
            // 
            // buttonHard
            // 
            this.buttonHard.Location = new System.Drawing.Point(544, 332);
            this.buttonHard.Name = "buttonHard";
            this.buttonHard.Size = new System.Drawing.Size(168, 47);
            this.buttonHard.TabIndex = 5;
            this.buttonHard.Text = "Hard";
            this.buttonHard.UseVisualStyleBackColor = true;
            this.buttonHard.Click += new System.EventHandler(this.add_to_score);
            // 
            // textProgress
            // 
            this.textProgress.Location = new System.Drawing.Point(547, 71);
            this.textProgress.Name = "textProgress";
            this.textProgress.Size = new System.Drawing.Size(168, 45);
            this.textProgress.TabIndex = 6;
            this.textProgress.Text = "label2";
            // 
            // buttonEnd
            // 
            this.buttonEnd.Location = new System.Drawing.Point(547, 554);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(167, 63);
            this.buttonEnd.TabIndex = 7;
            this.buttonEnd.Text = "End";
            this.buttonEnd.UseVisualStyleBackColor = true;
            this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
            // 
            // textAsk
            // 
            this.textAsk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textAsk.Location = new System.Drawing.Point(544, 152);
            this.textAsk.Name = "textAsk";
            this.textAsk.Size = new System.Drawing.Size(168, 64);
            this.textAsk.TabIndex = 8;
            this.textAsk.Text = "Did you find it...";
            // 
            // textScore
            // 
            this.textScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textScore.Location = new System.Drawing.Point(544, 474);
            this.textScore.Name = "textScore";
            this.textScore.Size = new System.Drawing.Size(171, 64);
            this.textScore.TabIndex = 9;
            this.textScore.Text = "score";
            this.textScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonNotFound
            // 
            this.buttonNotFound.Location = new System.Drawing.Point(544, 385);
            this.buttonNotFound.Name = "buttonNotFound";
            this.buttonNotFound.Size = new System.Drawing.Size(168, 45);
            this.buttonNotFound.TabIndex = 10;
            this.buttonNotFound.Text = "Not Found";
            this.buttonNotFound.UseVisualStyleBackColor = true;
            this.buttonNotFound.Click += new System.EventHandler(this.add_to_score);
            // 
            // exerciceMemory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 643);
            this.Controls.Add(this.buttonNotFound);
            this.Controls.Add(this.textScore);
            this.Controls.Add(this.textAsk);
            this.Controls.Add(this.buttonEnd);
            this.Controls.Add(this.textProgress);
            this.Controls.Add(this.buttonHard);
            this.Controls.Add(this.buttonMedium);
            this.Controls.Add(this.buttonEasy);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.textTitle);
            this.Controls.Add(this.imageSign);
            this.Name = "exerciceMemory";
            this.Text = "Memory exercice";
            ((System.ComponentModel.ISupportInitialize)(this.imageSign)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imageSign;
        private System.Windows.Forms.Label textTitle;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button buttonEasy;
        private System.Windows.Forms.Button buttonMedium;
        private System.Windows.Forms.Button buttonHard;
        private System.Windows.Forms.Label textProgress;
        private System.Windows.Forms.Button buttonEnd;
        private System.Windows.Forms.Label textAsk;
        private System.Windows.Forms.Label textScore;
        private System.Windows.Forms.Button buttonNotFound;
    }
}