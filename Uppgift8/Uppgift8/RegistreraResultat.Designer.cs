namespace Uppgift8
{
    partial class RegistreraResultat
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
            this.Tävlingid_textBox = new System.Windows.Forms.TextBox();
            this.Tävlingid_label = new System.Windows.Forms.Label();
            this.OK_button = new System.Windows.Forms.Button();
            this.Golfid_textBox = new System.Windows.Forms.TextBox();
            this.Golfid_label = new System.Windows.Forms.Label();
            this.Resultat_textBox = new System.Windows.Forms.TextBox();
            this.Resultat_label = new System.Windows.Forms.Label();
            this.Avbryt_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tävlingid_textBox
            // 
            this.Tävlingid_textBox.Location = new System.Drawing.Point(8, 25);
            this.Tävlingid_textBox.Name = "Tävlingid_textBox";
            this.Tävlingid_textBox.Size = new System.Drawing.Size(85, 20);
            this.Tävlingid_textBox.TabIndex = 1;
            // 
            // Tävlingid_label
            // 
            this.Tävlingid_label.AutoSize = true;
            this.Tävlingid_label.Location = new System.Drawing.Point(5, 9);
            this.Tävlingid_label.Name = "Tävlingid_label";
            this.Tävlingid_label.Size = new System.Drawing.Size(56, 13);
            this.Tävlingid_label.TabIndex = 117;
            this.Tävlingid_label.Text = "Tävling-ID";
            // 
            // OK_button
            // 
            this.OK_button.Location = new System.Drawing.Point(8, 197);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(75, 23);
            this.OK_button.TabIndex = 4;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // Golfid_textBox
            // 
            this.Golfid_textBox.Location = new System.Drawing.Point(8, 74);
            this.Golfid_textBox.Name = "Golfid_textBox";
            this.Golfid_textBox.Size = new System.Drawing.Size(85, 20);
            this.Golfid_textBox.TabIndex = 2;
            // 
            // Golfid_label
            // 
            this.Golfid_label.AutoSize = true;
            this.Golfid_label.Location = new System.Drawing.Point(5, 58);
            this.Golfid_label.Name = "Golfid_label";
            this.Golfid_label.Size = new System.Drawing.Size(40, 13);
            this.Golfid_label.TabIndex = 113;
            this.Golfid_label.Text = "Golf-ID";
            // 
            // Resultat_textBox
            // 
            this.Resultat_textBox.Location = new System.Drawing.Point(8, 149);
            this.Resultat_textBox.Name = "Resultat_textBox";
            this.Resultat_textBox.Size = new System.Drawing.Size(48, 20);
            this.Resultat_textBox.TabIndex = 3;
            // 
            // Resultat_label
            // 
            this.Resultat_label.AutoSize = true;
            this.Resultat_label.Location = new System.Drawing.Point(5, 133);
            this.Resultat_label.Name = "Resultat_label";
            this.Resultat_label.Size = new System.Drawing.Size(46, 13);
            this.Resultat_label.TabIndex = 119;
            this.Resultat_label.Text = "Resultat";
            // 
            // Avbryt_button
            // 
            this.Avbryt_button.Location = new System.Drawing.Point(210, 197);
            this.Avbryt_button.Name = "Avbryt_button";
            this.Avbryt_button.Size = new System.Drawing.Size(75, 23);
            this.Avbryt_button.TabIndex = 5;
            this.Avbryt_button.Text = "Avbryt";
            this.Avbryt_button.UseVisualStyleBackColor = true;
            this.Avbryt_button.Click += new System.EventHandler(this.Avbryt_button_Click);
            // 
            // RegistreraResultat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 226);
            this.Controls.Add(this.Avbryt_button);
            this.Controls.Add(this.Resultat_textBox);
            this.Controls.Add(this.Resultat_label);
            this.Controls.Add(this.Tävlingid_textBox);
            this.Controls.Add(this.Tävlingid_label);
            this.Controls.Add(this.OK_button);
            this.Controls.Add(this.Golfid_textBox);
            this.Controls.Add(this.Golfid_label);
            this.Name = "RegistreraResultat";
            this.Text = "RegistreraResultat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tävlingid_textBox;
        private System.Windows.Forms.Label Tävlingid_label;
        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.TextBox Golfid_textBox;
        private System.Windows.Forms.Label Golfid_label;
        private System.Windows.Forms.TextBox Resultat_textBox;
        private System.Windows.Forms.Label Resultat_label;
        private System.Windows.Forms.Button Avbryt_button;

    }
}