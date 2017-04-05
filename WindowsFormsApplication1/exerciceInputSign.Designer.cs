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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(exerciceInputSign));
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
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.imageSign.BackColor = System.Drawing.Color.White;
            this.imageSign.Location = new System.Drawing.Point(208, 338);
            this.imageSign.Name = "imageSign";
            this.imageSign.Size = new System.Drawing.Size(153, 147);
            this.imageSign.TabIndex = 1;
            this.imageSign.TabStop = false;
            // 
            // inputSign
            // 
            this.inputSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.inputSign.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.inputSign.Location = new System.Drawing.Point(117, 622);
            this.inputSign.Name = "inputSign";
            this.inputSign.Size = new System.Drawing.Size(306, 29);
            this.inputSign.TabIndex = 2;
            this.inputSign.TextChanged += new System.EventHandler(this.inputSign_TextChanged);
            // 
            // labelSign
            // 
            this.labelSign.AutoSize = true;
            this.labelSign.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelSign.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSign.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelSign.Image = ((System.Drawing.Image)(resources.GetObject("labelSign.Image")));
            this.labelSign.Location = new System.Drawing.Point(35, 621);
            this.labelSign.Name = "labelSign";
            this.labelSign.Size = new System.Drawing.Size(76, 25);
            this.labelSign.TabIndex = 3;
            this.labelSign.Text = "Sign: ";
            // 
            // buttonValidate
            // 
            this.buttonValidate.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonValidate.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.buttonValidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonValidate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValidate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonValidate.Location = new System.Drawing.Point(439, 622);
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.Size = new System.Drawing.Size(100, 29);
            this.buttonValidate.TabIndex = 4;
            this.buttonValidate.Text = "Validate";
            this.buttonValidate.UseVisualStyleBackColor = true;
            this.buttonValidate.Click += new System.EventHandler(this.buttonValidate_Click);
            // 
            // textSignName
            // 
            this.textSignName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textSignName.Font = new System.Drawing.Font("Verdana", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSignName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textSignName.Image = ((System.Drawing.Image)(resources.GetObject("textSignName.Image")));
            this.textSignName.Location = new System.Drawing.Point(26, 134);
            this.textSignName.Name = "textSignName";
            this.textSignName.Size = new System.Drawing.Size(444, 77);
            this.textSignName.TabIndex = 5;
            this.textSignName.Text = "sign name";
            this.textSignName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.textSignName.Click += new System.EventHandler(this.textSignName_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonNext.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonNext.Location = new System.Drawing.Point(679, 602);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(143, 67);
            this.buttonNext.TabIndex = 6;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // textProgress
            // 
            this.textProgress.BackColor = System.Drawing.Color.White;
            this.textProgress.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textProgress.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textProgress.Location = new System.Drawing.Point(492, 64);
            this.textProgress.Name = "textProgress";
            this.textProgress.Size = new System.Drawing.Size(157, 63);
            this.textProgress.TabIndex = 7;
            this.textProgress.Text = "x/y";
            this.textProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textScore
            // 
            this.textScore.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textScore.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textScore.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textScore.Location = new System.Drawing.Point(642, 366);
            this.textScore.Name = "textScore";
            this.textScore.Size = new System.Drawing.Size(151, 39);
            this.textScore.TabIndex = 8;
            this.textScore.Text = "x/y";
            this.textScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textFinalScore
            // 
            this.textFinalScore.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textFinalScore.Font = new System.Drawing.Font("Verdana", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFinalScore.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textFinalScore.Location = new System.Drawing.Point(624, 480);
            this.textFinalScore.Name = "textFinalScore";
            this.textFinalScore.Size = new System.Drawing.Size(198, 63);
            this.textFinalScore.TabIndex = 9;
            this.textFinalScore.Text = "x%";
            this.textFinalScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCorrectAnswers
            // 
            this.labelCorrectAnswers.AutoSize = true;
            this.labelCorrectAnswers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelCorrectAnswers.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorrectAnswers.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelCorrectAnswers.Location = new System.Drawing.Point(607, 324);
            this.labelCorrectAnswers.Name = "labelCorrectAnswers";
            this.labelCorrectAnswers.Size = new System.Drawing.Size(232, 29);
            this.labelCorrectAnswers.TabIndex = 10;
            this.labelCorrectAnswers.Text = "Correct answers";
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.Color.White;
            this.rectangleShape1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rectangleShape1.BackgroundImage")));
            this.rectangleShape1.Location = new System.Drawing.Point(1, 134);
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
            this.shapeContainer1.TabIndex = 11;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape3
            // 
            this.rectangleShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape3.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.rectangleShape3.BorderWidth = 5;
            this.rectangleShape3.Location = new System.Drawing.Point(55, 221);
            this.rectangleShape3.Name = "rectangleShape3";
            this.rectangleShape3.Size = new System.Drawing.Size(357, 364);
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape2.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.rectangleShape2.Location = new System.Drawing.Point(581, 181);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(282, 405);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(667, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(126, 124);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(55, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 79);
            this.label1.TabIndex = 15;
            this.label1.Text = "What sign is it?";
            // 
            // exerciceInputSign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
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
            this.Controls.Add(this.shapeContainer1);
            this.MaximizeBox = false;
            this.Name = "exerciceInputSign";
            this.Text = "exerciceInputSign";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape3;
        private System.Windows.Forms.Label label1;
    }
}