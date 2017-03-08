namespace WindowsFormsApplication1
{
    partial class exercices
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
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.listLessons = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listExercices = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(620, 411);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(726, 411);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(442, 98);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.ReadOnly = true;
            this.descriptionBox.Size = new System.Drawing.Size(374, 264);
            this.descriptionBox.TabIndex = 4;
            // 
            // listLessons
            // 
            this.listLessons.FormattingEnabled = true;
            this.listLessons.Location = new System.Drawing.Point(76, 98);
            this.listLessons.Name = "listLessons";
            this.listLessons.Size = new System.Drawing.Size(130, 264);
            this.listLessons.TabIndex = 3;
            this.listLessons.SelectedIndexChanged += new System.EventHandler(this.listLessons_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 52);
            this.label1.TabIndex = 5;
            this.label1.Text = "Exercices";
            // 
            // listExercices
            // 
            this.listExercices.FormattingEnabled = true;
            this.listExercices.Location = new System.Drawing.Point(232, 98);
            this.listExercices.Name = "listExercices";
            this.listExercices.Size = new System.Drawing.Size(184, 264);
            this.listExercices.TabIndex = 6;
            this.listExercices.SelectedIndexChanged += new System.EventHandler(this.listExercices_SelectedIndexChanged);
            // 
            // exercices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 460);
            this.Controls.Add(this.listExercices);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.listLessons);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonOk);
            this.Name = "exercices";
            this.Text = "SignLearning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.ListBox listLessons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listExercices;
    }
}