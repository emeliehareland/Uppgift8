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
            this.Tävlingsklass_label = new System.Windows.Forms.Label();
            this.C_radioButton = new System.Windows.Forms.RadioButton();
            this.B_radioButton = new System.Windows.Forms.RadioButton();
            this.A_radioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Tävlingid_textBox
            // 
            this.Tävlingid_textBox.Location = new System.Drawing.Point(12, 25);
            this.Tävlingid_textBox.Name = "Tävlingid_textBox";
            this.Tävlingid_textBox.Size = new System.Drawing.Size(74, 20);
            this.Tävlingid_textBox.TabIndex = 1;
            // 
            // Tävlingid_label
            // 
            this.Tävlingid_label.AutoSize = true;
            this.Tävlingid_label.Location = new System.Drawing.Point(9, 9);
            this.Tävlingid_label.Name = "Tävlingid_label";
            this.Tävlingid_label.Size = new System.Drawing.Size(56, 13);
            this.Tävlingid_label.TabIndex = 111;
            this.Tävlingid_label.Text = "Tävling-ID";
            // 
            // OK_button
            // 
            this.OK_button.Location = new System.Drawing.Point(12, 237);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(75, 23);
            this.OK_button.TabIndex = 6;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // Avbryt_button
            // 
            this.Avbryt_button.Location = new System.Drawing.Point(203, 237);
            this.Avbryt_button.Name = "Avbryt_button";
            this.Avbryt_button.Size = new System.Drawing.Size(75, 23);
            this.Avbryt_button.TabIndex = 7;
            this.Avbryt_button.Text = "Avbryt";
            this.Avbryt_button.UseVisualStyleBackColor = true;
            this.Avbryt_button.Click += new System.EventHandler(this.Avbryt_button_Click);
            // 
            // Golfid_textBox
            // 
            this.Golfid_textBox.Location = new System.Drawing.Point(11, 74);
            this.Golfid_textBox.Name = "Golfid_textBox";
            this.Golfid_textBox.Size = new System.Drawing.Size(75, 20);
            this.Golfid_textBox.TabIndex = 2;
            // 
            // Golfid_label
            // 
            this.Golfid_label.AutoSize = true;
            this.Golfid_label.Location = new System.Drawing.Point(9, 58);
            this.Golfid_label.Name = "Golfid_label";
            this.Golfid_label.Size = new System.Drawing.Size(40, 13);
            this.Golfid_label.TabIndex = 103;
            this.Golfid_label.Text = "Golf-ID";
            // 
            // Tävlingsklass_label
            // 
            this.Tävlingsklass_label.AutoSize = true;
            this.Tävlingsklass_label.Location = new System.Drawing.Point(9, 115);
            this.Tävlingsklass_label.Name = "Tävlingsklass_label";
            this.Tävlingsklass_label.Size = new System.Drawing.Size(71, 13);
            this.Tävlingsklass_label.TabIndex = 129;
            this.Tävlingsklass_label.Text = "Tävlingsklass";
            // 
            // C_radioButton
            // 
            this.C_radioButton.AutoSize = true;
            this.C_radioButton.Location = new System.Drawing.Point(12, 177);
            this.C_radioButton.Name = "C_radioButton";
            this.C_radioButton.Size = new System.Drawing.Size(32, 17);
            this.C_radioButton.TabIndex = 5;
            this.C_radioButton.TabStop = true;
            this.C_radioButton.Text = "C";
            this.C_radioButton.UseVisualStyleBackColor = true;
            // 
            // B_radioButton
            // 
            this.B_radioButton.AutoSize = true;
            this.B_radioButton.Location = new System.Drawing.Point(12, 154);
            this.B_radioButton.Name = "B_radioButton";
            this.B_radioButton.Size = new System.Drawing.Size(32, 17);
            this.B_radioButton.TabIndex = 4;
            this.B_radioButton.TabStop = true;
            this.B_radioButton.Text = "B";
            this.B_radioButton.UseVisualStyleBackColor = true;
            // 
            // A_radioButton
            // 
            this.A_radioButton.AutoSize = true;
            this.A_radioButton.Location = new System.Drawing.Point(12, 131);
            this.A_radioButton.Name = "A_radioButton";
            this.A_radioButton.Size = new System.Drawing.Size(32, 17);
            this.A_radioButton.TabIndex = 3;
            this.A_radioButton.TabStop = true;
            this.A_radioButton.Text = "A";
            this.A_radioButton.UseVisualStyleBackColor = true;
            // 
            // AnmälDeltagare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 272);
            this.Controls.Add(this.Tävlingsklass_label);
            this.Controls.Add(this.C_radioButton);
            this.Controls.Add(this.B_radioButton);
            this.Controls.Add(this.A_radioButton);
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
        private System.Windows.Forms.Label Tävlingsklass_label;
        private System.Windows.Forms.RadioButton C_radioButton;
        private System.Windows.Forms.RadioButton B_radioButton;
        private System.Windows.Forms.RadioButton A_radioButton;
    }
}