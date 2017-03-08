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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_question
            // 
            this.label_question.AutoSize = true;
            this.label_question.Location = new System.Drawing.Point(383, 67);
            this.label_question.Name = "label_question";
            this.label_question.Size = new System.Drawing.Size(139, 13);
            this.label_question.TabIndex = 0;
            this.label_question.Text = "Choisisez la bonne réponse:";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(47, 57);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(298, 337);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton_choice5);
            this.panel1.Controls.Add(this.radioButton_choice4);
            this.panel1.Controls.Add(this.radioButton_choice3);
            this.panel1.Controls.Add(this.radioButton_choice2);
            this.panel1.Controls.Add(this.radioButton_choice1);
            this.panel1.Location = new System.Drawing.Point(404, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 244);
            this.panel1.TabIndex = 2;
            // 
            // radioButton_choice5
            // 
            this.radioButton_choice5.AutoSize = true;
            this.radioButton_choice5.Location = new System.Drawing.Point(24, 190);
            this.radioButton_choice5.Name = "radioButton_choice5";
            this.radioButton_choice5.Size = new System.Drawing.Size(85, 17);
            this.radioButton_choice5.TabIndex = 4;
            this.radioButton_choice5.TabStop = true;
            this.radioButton_choice5.Text = "radioButton5";
            this.radioButton_choice5.UseVisualStyleBackColor = true;
            // 
            // radioButton_choice4
            // 
            this.radioButton_choice4.AutoSize = true;
            this.radioButton_choice4.Location = new System.Drawing.Point(24, 150);
            this.radioButton_choice4.Name = "radioButton_choice4";
            this.radioButton_choice4.Size = new System.Drawing.Size(85, 17);
            this.radioButton_choice4.TabIndex = 3;
            this.radioButton_choice4.TabStop = true;
            this.radioButton_choice4.Text = "radioButton4";
            this.radioButton_choice4.UseVisualStyleBackColor = true;
            // 
            // radioButton_choice3
            // 
            this.radioButton_choice3.AutoSize = true;
            this.radioButton_choice3.Location = new System.Drawing.Point(24, 107);
            this.radioButton_choice3.Name = "radioButton_choice3";
            this.radioButton_choice3.Size = new System.Drawing.Size(85, 17);
            this.radioButton_choice3.TabIndex = 2;
            this.radioButton_choice3.TabStop = true;
            this.radioButton_choice3.Text = "radioButton3";
            this.radioButton_choice3.UseVisualStyleBackColor = true;
            // 
            // radioButton_choice2
            // 
            this.radioButton_choice2.AutoSize = true;
            this.radioButton_choice2.Location = new System.Drawing.Point(24, 63);
            this.radioButton_choice2.Name = "radioButton_choice2";
            this.radioButton_choice2.Size = new System.Drawing.Size(85, 17);
            this.radioButton_choice2.TabIndex = 1;
            this.radioButton_choice2.TabStop = true;
            this.radioButton_choice2.Text = "radioButton2";
            this.radioButton_choice2.UseVisualStyleBackColor = true;
            // 
            // radioButton_choice1
            // 
            this.radioButton_choice1.AutoSize = true;
            this.radioButton_choice1.Location = new System.Drawing.Point(24, 20);
            this.radioButton_choice1.Name = "radioButton_choice1";
            this.radioButton_choice1.Size = new System.Drawing.Size(85, 17);
            this.radioButton_choice1.TabIndex = 0;
            this.radioButton_choice1.TabStop = true;
            this.radioButton_choice1.Text = "radioButton1";
            this.radioButton_choice1.UseVisualStyleBackColor = true;
            // 
            // button_next
            // 
            this.button_next.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_next.Location = new System.Drawing.Point(591, 399);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(75, 23);
            this.button_next.TabIndex = 3;
            this.button_next.Text = "Next";
            this.button_next.UseVisualStyleBackColor = false;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // score_title
            // 
            this.score_title.AutoSize = true;
            this.score_title.Location = new System.Drawing.Point(689, 13);
            this.score_title.Name = "score_title";
            this.score_title.Size = new System.Drawing.Size(35, 13);
            this.score_title.TabIndex = 4;
            this.score_title.Text = "Score";
            // 
            // score_text
            // 
            this.score_text.AutoSize = true;
            this.score_text.Location = new System.Drawing.Point(742, 13);
            this.score_text.Name = "score_text";
            this.score_text.Size = new System.Drawing.Size(13, 13);
            this.score_text.TabIndex = 5;
            this.score_text.Text = "0";
            // 
            // exercice_mcq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 462);
            this.Controls.Add(this.score_text);
            this.Controls.Add(this.score_title);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label_question);
            this.Name = "exercice_mcq";
            this.Text = "exercice_mcq";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}