namespace project_Cybersecurity_Mikita
{
    partial class Vigenere
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
            this.buttonBackVigenere = new System.Windows.Forms.Button();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.KeyBox = new System.Windows.Forms.TextBox();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBackVigenere
            // 
            this.buttonBackVigenere.Location = new System.Drawing.Point(12, 415);
            this.buttonBackVigenere.Name = "buttonBackVigenere";
            this.buttonBackVigenere.Size = new System.Drawing.Size(75, 23);
            this.buttonBackVigenere.TabIndex = 0;
            this.buttonBackVigenere.Text = "Powrót";
            this.buttonBackVigenere.UseVisualStyleBackColor = true;
            this.buttonBackVigenere.Click += new System.EventHandler(this.buttonBackVigenere_Click);
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(12, 34);
            this.InputBox.Multiline = true;
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(311, 84);
            this.InputBox.TabIndex = 1;
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(419, 44);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(151, 74);
            this.EncryptButton.TabIndex = 2;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // KeyBox
            // 
            this.KeyBox.Location = new System.Drawing.Point(12, 162);
            this.KeyBox.Multiline = true;
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.Size = new System.Drawing.Size(313, 84);
            this.KeyBox.TabIndex = 3;
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(12, 294);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.Size = new System.Drawing.Size(313, 84);
            this.OutputBox.TabIndex = 4;
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(623, 44);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(151, 74);
            this.DecryptButton.TabIndex = 5;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Podaj tekst dla szyfrowania lub deszyfrowania";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Podaj klucz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Zaszyfrowany/odszyfrowany tekst";
            // 
            // Vigenere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.KeyBox);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.buttonBackVigenere);
            this.Name = "Vigenere";
            this.Text = "Vigenere";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBackVigenere;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.TextBox KeyBox;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}