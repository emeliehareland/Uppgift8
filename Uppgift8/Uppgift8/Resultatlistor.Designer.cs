namespace Uppgift8
{
    partial class Resultatlistor
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
            this.Tävlingid_label = new System.Windows.Forms.Label();
            this.Tävlingid_textBox = new System.Windows.Forms.TextBox();
            this.VisaResultat_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Avbryt_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.C_radioButton = new System.Windows.Forms.RadioButton();
            this.B_radioButton = new System.Windows.Forms.RadioButton();
            this.A_radioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Tävlingid_label
            // 
            this.Tävlingid_label.AutoSize = true;
            this.Tävlingid_label.Location = new System.Drawing.Point(9, 11);
            this.Tävlingid_label.Name = "Tävlingid_label";
            this.Tävlingid_label.Size = new System.Drawing.Size(56, 13);
            this.Tävlingid_label.TabIndex = 109;
            this.Tävlingid_label.Text = "Tävling-ID";
            // 
            // Tävlingid_textBox
            // 
            this.Tävlingid_textBox.Location = new System.Drawing.Point(71, 8);
            this.Tävlingid_textBox.Name = "Tävlingid_textBox";
            this.Tävlingid_textBox.Size = new System.Drawing.Size(57, 20);
            this.Tävlingid_textBox.TabIndex = 1;
            // 
            // VisaResultat_button
            // 
            this.VisaResultat_button.Location = new System.Drawing.Point(12, 34);
            this.VisaResultat_button.Name = "VisaResultat_button";
            this.VisaResultat_button.Size = new System.Drawing.Size(75, 23);
            this.VisaResultat_button.TabIndex = 5;
            this.VisaResultat_button.Text = "Visa resultat";
            this.VisaResultat_button.UseVisualStyleBackColor = true;
            this.VisaResultat_button.Click += new System.EventHandler(this.VisaResultat_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(231, 203);
            this.dataGridView1.TabIndex = 108;
            // 
            // Avbryt_button
            // 
            this.Avbryt_button.Location = new System.Drawing.Point(253, 281);
            this.Avbryt_button.Name = "Avbryt_button";
            this.Avbryt_button.Size = new System.Drawing.Size(75, 23);
            this.Avbryt_button.TabIndex = 6;
            this.Avbryt_button.Text = "Avbryt";
            this.Avbryt_button.UseVisualStyleBackColor = true;
            this.Avbryt_button.Click += new System.EventHandler(this.Avbryt_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 113;
            this.label1.Text = "Visa klass";
            // 
            // C_radioButton
            // 
            this.C_radioButton.AutoSize = true;
            this.C_radioButton.Location = new System.Drawing.Point(287, 7);
            this.C_radioButton.Name = "C_radioButton";
            this.C_radioButton.Size = new System.Drawing.Size(32, 17);
            this.C_radioButton.TabIndex = 4;
            this.C_radioButton.TabStop = true;
            this.C_radioButton.Text = "C";
            this.C_radioButton.UseVisualStyleBackColor = true;
            // 
            // B_radioButton
            // 
            this.B_radioButton.AutoSize = true;
            this.B_radioButton.Location = new System.Drawing.Point(249, 7);
            this.B_radioButton.Name = "B_radioButton";
            this.B_radioButton.Size = new System.Drawing.Size(32, 17);
            this.B_radioButton.TabIndex = 3;
            this.B_radioButton.TabStop = true;
            this.B_radioButton.Text = "B";
            this.B_radioButton.UseVisualStyleBackColor = true;
            // 
            // A_radioButton
            // 
            this.A_radioButton.AutoSize = true;
            this.A_radioButton.Location = new System.Drawing.Point(211, 7);
            this.A_radioButton.Name = "A_radioButton";
            this.A_radioButton.Size = new System.Drawing.Size(32, 17);
            this.A_radioButton.TabIndex = 2;
            this.A_radioButton.TabStop = true;
            this.A_radioButton.Text = "A";
            this.A_radioButton.UseVisualStyleBackColor = true;
            // 
            // Resultatlistor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 316);
            this.Controls.Add(this.C_radioButton);
            this.Controls.Add(this.B_radioButton);
            this.Controls.Add(this.A_radioButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tävlingid_label);
            this.Controls.Add(this.Tävlingid_textBox);
            this.Controls.Add(this.VisaResultat_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Avbryt_button);
            this.Name = "Resultatlistor";
            this.Text = "Resultatlistor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Tävlingid_label;
        private System.Windows.Forms.TextBox Tävlingid_textBox;
        private System.Windows.Forms.Button VisaResultat_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Avbryt_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton C_radioButton;
        private System.Windows.Forms.RadioButton B_radioButton;
        private System.Windows.Forms.RadioButton A_radioButton;
    }
}