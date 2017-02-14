namespace WindowsFormsApplication1
{
    partial class ecranprincipal
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
            this.buttonLessons = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExercices = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLessons
            // 
            this.buttonLessons.Location = new System.Drawing.Point(324, 184);
            this.buttonLessons.Name = "buttonLessons";
            this.buttonLessons.Size = new System.Drawing.Size(205, 65);
            this.buttonLessons.TabIndex = 0;
            this.buttonLessons.Text = "Lessons";
            this.buttonLessons.UseVisualStyleBackColor = true;
            this.buttonLessons.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "SignLearning";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonExercices
            // 
            this.buttonExercices.Location = new System.Drawing.Point(324, 255);
            this.buttonExercices.Name = "buttonExercices";
            this.buttonExercices.Size = new System.Drawing.Size(205, 65);
            this.buttonExercices.TabIndex = 2;
            this.buttonExercices.Text = "Exercices";
            this.buttonExercices.UseVisualStyleBackColor = true;
            this.buttonExercices.Click += new System.EventHandler(this.buttonExercices_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.Location = new System.Drawing.Point(324, 326);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(205, 65);
            this.buttonQuit.TabIndex = 3;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // ecranprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 470);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.buttonExercices);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLessons);
            this.Name = "ecranprincipal";
            this.Text = "SignLearning";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLessons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExercices;
        private System.Windows.Forms.Button buttonQuit;
    }
}

