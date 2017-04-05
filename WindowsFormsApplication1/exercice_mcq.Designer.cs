namespace WindowsFormsApplication1
{
    partial class exercice_mcq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(exercice_mcq));
            this.label_question = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton_choice5 = new System.Windows.Forms.RadioButton();
            this.radioButton_choice4 = new System.Windows.Forms.RadioButton();
            this.radioButton_choice3 = new System.Windows.Forms.RadioButton();
            this.radioButton_choice2 = new System.Windows.Forms.RadioButton();
            this.radioButton_choice1 = new System.Windows.Forms.RadioButton();
            this.button_next = new System.Windows.Forms.Button();
            this.score_title = new System.Windows.Forms.Label();
            this.score_text = new System.Windows.Forms.Label();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_question
            // 
            this.label_question.AutoSize = true;
            this.label_question.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_question.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_question.Image = ((System.Drawing.Image)(resources.GetObject("label_question.Image")));
            this.label_question.Location = new System.Drawing.Point(626, 220);
            this.label_question.Name = "label_question";
            this.label_question.Size = new System.Drawing.Size(299, 25);
            this.label_question.TabIndex = 0;
            this.label_question.Text = "Choose the right answer";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(190, 289);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(162, 158);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.radioButton_choice5);
            this.panel1.Controls.Add(this.radioButton_choice4);
            this.panel1.Controls.Add(this.radioButton_choice3);
            this.panel1.Controls.Add(this.radioButton_choice2);
            this.panel1.Controls.Add(this.radioButton_choice1);
            this.panel1.Location = new System.Drawing.Point(648, 269);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 244);
            this.panel1.TabIndex = 2;
            // 
            // radioButton_choice5
            // 
            this.radioButton_choice5.AutoSize = true;
            this.radioButton_choice5.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.HotTrack;
            this.radioButton_choice5.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.radioButton_choice5.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.radioButton_choice5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton_choice5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_choice5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.radioButton_choice5.Location = new System.Drawing.Point(24, 190);
            this.radioButton_choice5.Name = "radioButton_choice5";
            this.radioButton_choice5.Size = new System.Drawing.Size(120, 20);
            this.radioButton_choice5.TabIndex = 4;
            this.radioButton_choice5.TabStop = true;
            this.radioButton_choice5.Text = "radioButton5";
            this.radioButton_choice5.UseVisualStyleBackColor = true;
            // 
            // radioButton_choice4
            // 
            this.radioButton_choice4.AutoSize = true;
            this.radioButton_choice4.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.HotTrack;
            this.radioButton_choice4.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.radioButton_choice4.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.radioButton_choice4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton_choice4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_choice4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.radioButton_choice4.Location = new System.Drawing.Point(24, 150);
            this.radioButton_choice4.Name = "radioButton_choice4";
            this.radioButton_choice4.Size = new System.Drawing.Size(120, 20);
            this.radioButton_choice4.TabIndex = 3;
            this.radioButton_choice4.TabStop = true;
            this.radioButton_choice4.Text = "radioButton4";
            this.radioButton_choice4.UseVisualStyleBackColor = true;
            // 
            // radioButton_choice3
            // 
            this.radioButton_choice3.AutoSize = true;
            this.radioButton_choice3.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.HotTrack;
            this.radioButton_choice3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.radioButton_choice3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.radioButton_choice3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton_choice3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_choice3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.radioButton_choice3.Location = new System.Drawing.Point(24, 107);
            this.radioButton_choice3.Name = "radioButton_choice3";
            this.radioButton_choice3.Size = new System.Drawing.Size(120, 20);
            this.radioButton_choice3.TabIndex = 2;
            this.radioButton_choice3.TabStop = true;
            this.radioButton_choice3.Text = "radioButton3";
            this.radioButton_choice3.UseVisualStyleBackColor = true;
            // 
            // radioButton_choice2
            // 
            this.radioButton_choice2.AutoSize = true;
            this.radioButton_choice2.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.HotTrack;
            this.radioButton_choice2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.radioButton_choice2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.radioButton_choice2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton_choice2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_choice2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.radioButton_choice2.Location = new System.Drawing.Point(24, 63);
            this.radioButton_choice2.Name = "radioButton_choice2";
            this.radioButton_choice2.Size = new System.Drawing.Size(120, 20);
            this.radioButton_choice2.TabIndex = 1;
            this.radioButton_choice2.TabStop = true;
            this.radioButton_choice2.Text = "radioButton2";
            this.radioButton_choice2.UseVisualStyleBackColor = true;
            // 
            // radioButton_choice1
            // 
            this.radioButton_choice1.AutoSize = true;
            this.radioButton_choice1.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.HotTrack;
            this.radioButton_choice1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.radioButton_choice1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.radioButton_choice1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton_choice1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_choice1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.radioButton_choice1.Location = new System.Drawing.Point(24, 20);
            this.radioButton_choice1.Name = "radioButton_choice1";
            this.radioButton_choice1.Size = new System.Drawing.Size(120, 20);
            this.radioButton_choice1.TabIndex = 0;
            this.radioButton_choice1.TabStop = true;
            this.radioButton_choice1.Text = "radioButton1";
            this.radioButton_choice1.UseVisualStyleBackColor = true;
            // 
            // button_next
            // 
            this.button_next.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_next.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.button_next.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_next.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_next.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_next.Location = new System.Drawing.Point(695, 530);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(167, 63);
            this.button_next.TabIndex = 3;
            this.button_next.Text = "Next";
            this.button_next.UseVisualStyleBackColor = false;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // score_title
            // 
            this.score_title.AutoSize = true;
            this.score_title.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_title.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.score_title.Image = ((System.Drawing.Image)(resources.GetObject("score_title.Image")));
            this.score_title.Location = new System.Drawing.Point(373, 629);
            this.score_title.Name = "score_title";
            this.score_title.Size = new System.Drawing.Size(77, 25);
            this.score_title.TabIndex = 4;
            this.score_title.Text = "Score";
            // 
            // score_text
            // 
            this.score_text.AutoSize = true;
            this.score_text.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_text.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.score_text.Image = ((System.Drawing.Image)(resources.GetObject("score_text.Image")));
            this.score_text.Location = new System.Drawing.Point(486, 629);
            this.score_text.Name = "score_text";
            this.score_text.Size = new System.Drawing.Size(27, 25);
            this.score_text.TabIndex = 5;
            this.score_text.Text = "0";
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
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1008, 730);
            this.shapeContainer1.TabIndex = 6;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BackColor = System.Drawing.Color.White;
            this.rectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape2.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.rectangleShape2.BorderWidth = 5;
            this.rectangleShape2.Location = new System.Drawing.Point(62, 161);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(341, 430);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(48, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 79);
            this.label1.TabIndex = 15;
            this.label1.Text = "What sign is it?";
            // 
            // exercice_mcq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.score_text);
            this.Controls.Add(this.score_title);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label_question);
            this.Controls.Add(this.shapeContainer1);
            this.MaximizeBox = false;
            this.Name = "exercice_mcq";
            this.Text = "exercice_mcq";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_question;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton_choice5;
        private System.Windows.Forms.RadioButton radioButton_choice4;
        private System.Windows.Forms.RadioButton radioButton_choice3;
        private System.Windows.Forms.RadioButton radioButton_choice2;
        private System.Windows.Forms.RadioButton radioButton_choice1;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Label score_title;
        private System.Windows.Forms.Label score_text;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private System.Windows.Forms.Label label1;
    }
}