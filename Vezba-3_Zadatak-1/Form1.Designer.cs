namespace Vezba_3_Zadatak_1
{
    partial class Čekiranje
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
            this.checkBox_Ime = new System.Windows.Forms.CheckBox();
            this.checkBox_Prezime = new System.Windows.Forms.CheckBox();
            this.checkBox_Adresa = new System.Windows.Forms.CheckBox();
            this.checkBox_MestoStanovanja = new System.Windows.Forms.CheckBox();
            this.button_Prikazi = new System.Windows.Forms.Button();
            this.richTextBox_Result = new System.Windows.Forms.RichTextBox();
            this.textBox_Ime = new System.Windows.Forms.TextBox();
            this.textBox_Prezime = new System.Windows.Forms.TextBox();
            this.textBox_Adresa = new System.Windows.Forms.TextBox();
            this.textBox_MestoStanovanja = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkBox_Ime
            // 
            this.checkBox_Ime.AutoSize = true;
            this.checkBox_Ime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.checkBox_Ime.Location = new System.Drawing.Point(12, 12);
            this.checkBox_Ime.Name = "checkBox_Ime";
            this.checkBox_Ime.Size = new System.Drawing.Size(55, 24);
            this.checkBox_Ime.TabIndex = 0;
            this.checkBox_Ime.Text = "Ime";
            this.checkBox_Ime.UseVisualStyleBackColor = true;
            this.checkBox_Ime.CheckedChanged += new System.EventHandler(this.checkBox_Ime_CheckedChanged);
            // 
            // checkBox_Prezime
            // 
            this.checkBox_Prezime.AutoSize = true;
            this.checkBox_Prezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.checkBox_Prezime.Location = new System.Drawing.Point(12, 42);
            this.checkBox_Prezime.Name = "checkBox_Prezime";
            this.checkBox_Prezime.Size = new System.Drawing.Size(90, 24);
            this.checkBox_Prezime.TabIndex = 1;
            this.checkBox_Prezime.Text = "Prezime";
            this.checkBox_Prezime.UseVisualStyleBackColor = true;
            this.checkBox_Prezime.CheckedChanged += new System.EventHandler(this.checkBox_Prezime_CheckedChanged);
            // 
            // checkBox_Adresa
            // 
            this.checkBox_Adresa.AutoSize = true;
            this.checkBox_Adresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.checkBox_Adresa.Location = new System.Drawing.Point(12, 72);
            this.checkBox_Adresa.Name = "checkBox_Adresa";
            this.checkBox_Adresa.Size = new System.Drawing.Size(81, 24);
            this.checkBox_Adresa.TabIndex = 2;
            this.checkBox_Adresa.Text = "Adresa";
            this.checkBox_Adresa.UseVisualStyleBackColor = true;
            this.checkBox_Adresa.CheckedChanged += new System.EventHandler(this.checkBox_Adresa_CheckedChanged);
            // 
            // checkBox_MestoStanovanja
            // 
            this.checkBox_MestoStanovanja.AutoSize = true;
            this.checkBox_MestoStanovanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.checkBox_MestoStanovanja.Location = new System.Drawing.Point(12, 102);
            this.checkBox_MestoStanovanja.Name = "checkBox_MestoStanovanja";
            this.checkBox_MestoStanovanja.Size = new System.Drawing.Size(159, 24);
            this.checkBox_MestoStanovanja.TabIndex = 3;
            this.checkBox_MestoStanovanja.Text = "Mesto stanovanja";
            this.checkBox_MestoStanovanja.UseVisualStyleBackColor = true;
            this.checkBox_MestoStanovanja.CheckedChanged += new System.EventHandler(this.checkBox_MestoStanovanja_CheckedChanged);
            // 
            // button_Prikazi
            // 
            this.button_Prikazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.button_Prikazi.Location = new System.Drawing.Point(184, 140);
            this.button_Prikazi.Name = "button_Prikazi";
            this.button_Prikazi.Size = new System.Drawing.Size(100, 50);
            this.button_Prikazi.TabIndex = 8;
            this.button_Prikazi.Text = "Prikazi";
            this.button_Prikazi.UseVisualStyleBackColor = true;
            this.button_Prikazi.Click += new System.EventHandler(this.button_Prikazi_Click);
            // 
            // richTextBox_Result
            // 
            this.richTextBox_Result.Location = new System.Drawing.Point(12, 200);
            this.richTextBox_Result.Name = "richTextBox_Result";
            this.richTextBox_Result.ReadOnly = true;
            this.richTextBox_Result.Size = new System.Drawing.Size(460, 150);
            this.richTextBox_Result.TabIndex = 9;
            this.richTextBox_Result.Text = "";
            // 
            // textBox_Ime
            // 
            this.textBox_Ime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.textBox_Ime.Location = new System.Drawing.Point(184, 10);
            this.textBox_Ime.Name = "textBox_Ime";
            this.textBox_Ime.ReadOnly = true;
            this.textBox_Ime.Size = new System.Drawing.Size(200, 26);
            this.textBox_Ime.TabIndex = 10;
            // 
            // textBox_Prezime
            // 
            this.textBox_Prezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.textBox_Prezime.Location = new System.Drawing.Point(184, 38);
            this.textBox_Prezime.Name = "textBox_Prezime";
            this.textBox_Prezime.ReadOnly = true;
            this.textBox_Prezime.Size = new System.Drawing.Size(200, 26);
            this.textBox_Prezime.TabIndex = 11;
            // 
            // textBox_Adresa
            // 
            this.textBox_Adresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.textBox_Adresa.Location = new System.Drawing.Point(184, 70);
            this.textBox_Adresa.Name = "textBox_Adresa";
            this.textBox_Adresa.ReadOnly = true;
            this.textBox_Adresa.Size = new System.Drawing.Size(200, 26);
            this.textBox_Adresa.TabIndex = 12;
            // 
            // textBox_MestoStanovanja
            // 
            this.textBox_MestoStanovanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.textBox_MestoStanovanja.Location = new System.Drawing.Point(184, 100);
            this.textBox_MestoStanovanja.Name = "textBox_MestoStanovanja";
            this.textBox_MestoStanovanja.ReadOnly = true;
            this.textBox_MestoStanovanja.Size = new System.Drawing.Size(200, 26);
            this.textBox_MestoStanovanja.TabIndex = 13;
            // 
            // Čekiranje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.textBox_MestoStanovanja);
            this.Controls.Add(this.textBox_Adresa);
            this.Controls.Add(this.textBox_Prezime);
            this.Controls.Add(this.textBox_Ime);
            this.Controls.Add(this.richTextBox_Result);
            this.Controls.Add(this.button_Prikazi);
            this.Controls.Add(this.checkBox_MestoStanovanja);
            this.Controls.Add(this.checkBox_Adresa);
            this.Controls.Add(this.checkBox_Prezime);
            this.Controls.Add(this.checkBox_Ime);
            this.Name = "Čekiranje";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_Ime;
        private System.Windows.Forms.CheckBox checkBox_Prezime;
        private System.Windows.Forms.CheckBox checkBox_Adresa;
        private System.Windows.Forms.CheckBox checkBox_MestoStanovanja;
        private System.Windows.Forms.Button button_Prikazi;
        private System.Windows.Forms.RichTextBox richTextBox_Result;
        private System.Windows.Forms.TextBox textBox_Ime;
        private System.Windows.Forms.TextBox textBox_Prezime;
        private System.Windows.Forms.TextBox textBox_Adresa;
        private System.Windows.Forms.TextBox textBox_MestoStanovanja;
    }
}

