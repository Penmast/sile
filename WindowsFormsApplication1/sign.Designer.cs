namespace WindowsFormsApplication1
{
    partial class sign
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
            this.image_sign = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.explanation = new System.Windows.Forms.TextBox();
            this.button_next = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.progress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.image_sign)).BeginInit();
            this.SuspendLayout();
            // 
            // image_sign
            // 
            this.image_sign.BackColor = System.Drawing.SystemColors.Control;
            this.image_sign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.image_sign.Location = new System.Drawing.Point(24, -3);
            this.image_sign.Name = "image_sign";
            this.image_sign.Size = new System.Drawing.Size(393, 466);
            this.image_sign.TabIndex = 0;
            this.image_sign.TabStop = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(440, 78);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(101, 25);
            this.title.TabIndex = 1;
            this.title.Text = "A (Letter)";
            // 
            // explanation
            // 
            this.explanation.Location = new System.Drawing.Point(445, 153);
            this.explanation.Multiline = true;
            this.explanation.Name = "explanation";
            this.explanation.Size = new System.Drawing.Size(363, 227);
            this.explanation.TabIndex = 2;
            this.explanation.Text = "Texte explicatif";
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(565, 409);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(75, 23);
            this.button_next.TabIndex = 4;
            this.button_next.Text = "Back";
            this.button_next.UseVisualStyleBackColor = true;
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(763, 409);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 23);
            this.button_back.TabIndex = 3;
            this.button_back.Text = "Suivant";
            this.button_back.UseVisualStyleBackColor = true;
            // 
            // progress
            // 
            this.progress.AutoSize = true;
            this.progress.Location = new System.Drawing.Point(683, 414);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(30, 13);
            this.progress.TabIndex = 5;
            this.progress.Text = "1/10";
            // 
            // sign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 459);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.explanation);
            this.Controls.Add(this.title);
            this.Controls.Add(this.image_sign);
            this.Name = "sign";
            this.Text = "SignLearning";
            ((System.ComponentModel.ISupportInitialize)(this.image_sign)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox image_sign;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox explanation;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Label progress;
    }
}