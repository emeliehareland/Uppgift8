namespace Uppgift8
{
    partial class AnmälDeltagare
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
            this.Avbryt_button = new System.Windows.Forms.Button();
            this.Golfid_textBox = new System.Windows.Forms.TextBox();
            this.Golfid_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Tävlingid_textBox
            // 
            this.Tävlingid_textBox.Location = new System.Drawing.Point(8, 18);
            this.Tävlingid_textBox.Name = "Tävlingid_textBox";
            this.Tävlingid_textBox.Size = new System.Drawing.Size(101, 20);
            this.Tävlingid_textBox.TabIndex = 112;
            // 
            // Tävlingid_label
            // 
            this.Tävlingid_label.AutoSize = true;
            this.Tävlingid_label.Location = new System.Drawing.Point(10, 2);
            this.Tävlingid_label.Name = "Tävlingid_label";
            this.Tävlingid_label.Size = new System.Drawing.Size(56, 13);
            this.Tävlingid_label.TabIndex = 111;
            this.Tävlingid_label.Text = "Tävling-ID";
            // 
            // OK_button
            // 
            this.OK_button.Location = new System.Drawing.Point(8, 141);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(75, 23);
            this.OK_button.TabIndex = 110;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            // 
            // Avbryt_button
            // 
            this.Avbryt_button.Location = new System.Drawing.Point(165, 141);
            this.Avbryt_button.Name = "Avbryt_button";
            this.Avbryt_button.Size = new System.Drawing.Size(75, 23);
            this.Avbryt_button.TabIndex = 109;
            this.Avbryt_button.Text = "Avbryt";
            this.Avbryt_button.UseVisualStyleBackColor = true;
            this.Avbryt_button.Click += new System.EventHandler(this.Avbryt_button_Click);
            // 
            // Golfid_textBox
            // 
            this.Golfid_textBox.Location = new System.Drawing.Point(8, 67);
            this.Golfid_textBox.Name = "Golfid_textBox";
            this.Golfid_textBox.Size = new System.Drawing.Size(101, 20);
            this.Golfid_textBox.TabIndex = 104;
            // 
            // Golfid_label
            // 
            this.Golfid_label.AutoSize = true;
            this.Golfid_label.Location = new System.Drawing.Point(10, 51);
            this.Golfid_label.Name = "Golfid_label";
            this.Golfid_label.Size = new System.Drawing.Size(40, 13);
            this.Golfid_label.TabIndex = 103;
            this.Golfid_label.Text = "Golf-ID";
            // 
            // AnmälDeltagare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 174);
            this.Controls.Add(this.Tävlingid_textBox);
            this.Controls.Add(this.Tävlingid_label);
            this.Controls.Add(this.OK_button);
            this.Controls.Add(this.Avbryt_button);
            this.Controls.Add(this.Golfid_textBox);
            this.Controls.Add(this.Golfid_label);
            this.Name = "AnmälDeltagare";
            this.Text = "AnmälDeltagare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tävlingid_textBox;
        private System.Windows.Forms.Label Tävlingid_label;
        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.Button Avbryt_button;
        private System.Windows.Forms.TextBox Golfid_textBox;
        private System.Windows.Forms.Label Golfid_label;
    }
}