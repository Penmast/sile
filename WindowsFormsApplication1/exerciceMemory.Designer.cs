using Microsoft.VisualBasic.PowerPacks;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(exerciceMemory));
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
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.shapeContainer3 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageSign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.shapeContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageSign
            // 
            this.imageSign.BackColor = System.Drawing.Color.White;
            this.imageSign.Location = new System.Drawing.Point(214, 311);
            this.imageSign.Name = "imageSign";
            this.imageSign.Size = new System.Drawing.Size(161, 171);
            this.imageSign.TabIndex = 0;
            this.imageSign.TabStop = false;
            // 
            // textTitle
            // 
            this.textTitle.Font = new System.Drawing.Font("Segoe Print", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textTitle.Location = new System.Drawing.Point(100, 177);
            this.textTitle.MaximumSize = new System.Drawing.Size(500, 500);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(338, 82);
            this.textTitle.TabIndex = 1;
            this.textTitle.Text = "signName";
            this.textTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonShow
            // 
            this.buttonShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShow.Font = new System.Drawing.Font("Verdana", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShow.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonShow.Location = new System.Drawing.Point(75, 597);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(393, 64);
            this.buttonShow.TabIndex = 2;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonEasy
            // 
            this.buttonEasy.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.buttonEasy.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonEasy.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.buttonEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEasy.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEasy.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonEasy.Location = new System.Drawing.Point(738, 227);
            this.buttonEasy.Name = "buttonEasy";
            this.buttonEasy.Size = new System.Drawing.Size(168, 52);
            this.buttonEasy.TabIndex = 3;
            this.buttonEasy.Text = "Easy";
            this.buttonEasy.UseVisualStyleBackColor = true;
            this.buttonEasy.Click += new System.EventHandler(this.add_to_score);
            // 
            // buttonMedium
            // 
            this.buttonMedium.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.buttonMedium.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonMedium.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.buttonMedium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMedium.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMedium.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonMedium.Location = new System.Drawing.Point(738, 285);
            this.buttonMedium.Name = "buttonMedium";
            this.buttonMedium.Size = new System.Drawing.Size(168, 52);
            this.buttonMedium.TabIndex = 4;
            this.buttonMedium.Text = "Medium";
            this.buttonMedium.UseVisualStyleBackColor = true;
            this.buttonMedium.Click += new System.EventHandler(this.add_to_score);
            // 
            // buttonHard
            // 
            this.buttonHard.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonHard.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.buttonHard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHard.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHard.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonHard.Location = new System.Drawing.Point(738, 343);
            this.buttonHard.Name = "buttonHard";
            this.buttonHard.Size = new System.Drawing.Size(168, 52);
            this.buttonHard.TabIndex = 5;
            this.buttonHard.Text = "Hard";
            this.buttonHard.UseVisualStyleBackColor = true;
            this.buttonHard.Click += new System.EventHandler(this.add_to_score);
            // 
            // textProgress
            // 
            this.textProgress.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textProgress.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textProgress.Location = new System.Drawing.Point(547, 71);
            this.textProgress.Name = "textProgress";
            this.textProgress.Size = new System.Drawing.Size(168, 45);
            this.textProgress.TabIndex = 6;
            this.textProgress.Text = "label2";
            // 
            // buttonEnd
            // 
            this.buttonEnd.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonEnd.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.buttonEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnd.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonEnd.Location = new System.Drawing.Point(741, 581);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(167, 63);
            this.buttonEnd.TabIndex = 7;
            this.buttonEnd.Text = "End";
            this.buttonEnd.UseVisualStyleBackColor = true;
            this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
            // 
            // textAsk
            // 
            this.textAsk.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAsk.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textAsk.Image = ((System.Drawing.Image)(resources.GetObject("textAsk.Image")));
            this.textAsk.Location = new System.Drawing.Point(733, 148);
            this.textAsk.Name = "textAsk";
            this.textAsk.Size = new System.Drawing.Size(168, 64);
            this.textAsk.TabIndex = 8;
            this.textAsk.Text = "Did you find it...";
            this.textAsk.Click += new System.EventHandler(this.textAsk_Click);
            // 
            // textScore
            // 
            this.textScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textScore.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textScore.Location = new System.Drawing.Point(738, 504);
            this.textScore.Name = "textScore";
            this.textScore.Size = new System.Drawing.Size(171, 64);
            this.textScore.TabIndex = 9;
            this.textScore.Text = "score";
            this.textScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonNotFound
            // 
            this.buttonNotFound.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonNotFound.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.buttonNotFound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNotFound.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNotFound.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonNotFound.Location = new System.Drawing.Point(738, 401);
            this.buttonNotFound.Name = "buttonNotFound";
            this.buttonNotFound.Size = new System.Drawing.Size(168, 52);
            this.buttonNotFound.TabIndex = 10;
            this.buttonNotFound.Text = "Not Found";
            this.buttonNotFound.UseVisualStyleBackColor = true;
            this.buttonNotFound.Click += new System.EventHandler(this.add_to_score);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.Color.White;
            this.rectangleShape1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rectangleShape1.BackgroundImage")));
            this.rectangleShape1.Location = new System.Drawing.Point(1, 132);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(1009, 554);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(667, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 124);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(430, 708);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Copyright 2017\r\n";
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape2.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.rectangleShape2.BorderWidth = 5;
            this.rectangleShape2.Location = new System.Drawing.Point(41, 149);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(467, 418);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Controls.Add(this.label1);
            this.shapeContainer1.Controls.Add(this.textTitle);
            this.shapeContainer1.Controls.Add(this.textAsk);
            this.shapeContainer1.Controls.Add(this.buttonEnd);
            this.shapeContainer1.Controls.Add(this.textScore);
            this.shapeContainer1.Controls.Add(this.buttonNotFound);
            this.shapeContainer1.Controls.Add(this.buttonHard);
            this.shapeContainer1.Controls.Add(this.buttonMedium);
            this.shapeContainer1.Controls.Add(this.buttonEasy);
            this.shapeContainer1.Controls.Add(this.imageSign);
            this.shapeContainer1.Controls.Add(this.shapeContainer3);
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1008, 730);
            this.shapeContainer1.TabIndex = 11;
            this.shapeContainer1.TabStop = false;
            // 
            // shapeContainer3
            // 
            this.shapeContainer3.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer3.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer3.Name = "shapeContainer3";
            this.shapeContainer3.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape3});
            this.shapeContainer3.Size = new System.Drawing.Size(1008, 730);
            this.shapeContainer3.TabIndex = 0;
            this.shapeContainer3.TabStop = false;
            // 
            // rectangleShape3
            // 
            this.rectangleShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape3.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.rectangleShape3.BorderWidth = 5;
            this.rectangleShape3.Location = new System.Drawing.Point(76, 163);
            this.rectangleShape3.Name = "rectangleShape3";
            this.rectangleShape3.Size = new System.Drawing.Size(388, 384);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(84, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 79);
            this.label1.TabIndex = 11;
            this.label1.Text = "What is the sign?";
            // 
            // exerciceMemory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textProgress);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.shapeContainer1);
            this.MaximizeBox = false;
            this.Name = "exerciceMemory";
            this.Text = "Memory exercice";
            ((System.ComponentModel.ISupportInitialize)(this.imageSign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.shapeContainer1.ResumeLayout(false);
            this.shapeContainer1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private RectangleShape rectangleShape2;
        private ShapeContainer shapeContainer1;
        private ShapeContainer shapeContainer3;
        private RectangleShape rectangleShape3;
        private System.Windows.Forms.Label label1;
    }
}