namespace Vezba_3_Zadatak_5
{
    partial class Form1
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
            this.listBox_Numbers = new System.Windows.Forms.ListBox();
            this.comboBox_Digits = new System.Windows.Forms.ComboBox();
            this.checkBox_Even = new System.Windows.Forms.CheckBox();
            this.checkBox_Odd = new System.Windows.Forms.CheckBox();
            this.button_Display = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_Numbers
            // 
            this.listBox_Numbers.FormattingEnabled = true;
            this.listBox_Numbers.Location = new System.Drawing.Point(300, 50);
            this.listBox_Numbers.Name = "listBox_Numbers";
            this.listBox_Numbers.Size = new System.Drawing.Size(120, 355);
            this.listBox_Numbers.TabIndex = 0;
            // 
            // comboBox_Digits
            // 
            this.comboBox_Digits.FormattingEnabled = true;
            this.comboBox_Digits.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBox_Digits.Location = new System.Drawing.Point(75, 50);
            this.comboBox_Digits.Name = "comboBox_Digits";
            this.comboBox_Digits.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Digits.TabIndex = 1;
            // 
            // checkBox_Even
            // 
            this.checkBox_Even.AutoSize = true;
            this.checkBox_Even.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.checkBox_Even.Location = new System.Drawing.Point(75, 170);
            this.checkBox_Even.Name = "checkBox_Even";
            this.checkBox_Even.Size = new System.Drawing.Size(67, 24);
            this.checkBox_Even.TabIndex = 2;
            this.checkBox_Even.Text = "Parni";
            this.checkBox_Even.UseVisualStyleBackColor = true;
            // 
            // checkBox_Odd
            // 
            this.checkBox_Odd.AutoSize = true;
            this.checkBox_Odd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.checkBox_Odd.Location = new System.Drawing.Point(75, 200);
            this.checkBox_Odd.Name = "checkBox_Odd";
            this.checkBox_Odd.Size = new System.Drawing.Size(86, 24);
            this.checkBox_Odd.TabIndex = 3;
            this.checkBox_Odd.Text = "Neparni";
            this.checkBox_Odd.UseVisualStyleBackColor = true;
            // 
            // button_Display
            // 
            this.button_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.button_Display.Location = new System.Drawing.Point(75, 355);
            this.button_Display.Name = "button_Display";
            this.button_Display.Size = new System.Drawing.Size(100, 50);
            this.button_Display.TabIndex = 4;
            this.button_Display.Text = "Ispisi";
            this.button_Display.UseVisualStyleBackColor = true;
            this.button_Display.Click += new System.EventHandler(this.button_Display_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.button_Display);
            this.Controls.Add(this.checkBox_Odd);
            this.Controls.Add(this.checkBox_Even);
            this.Controls.Add(this.comboBox_Digits);
            this.Controls.Add(this.listBox_Numbers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Numbers;
        private System.Windows.Forms.ComboBox comboBox_Digits;
        private System.Windows.Forms.CheckBox checkBox_Even;
        private System.Windows.Forms.CheckBox checkBox_Odd;
        private System.Windows.Forms.Button button_Display;
    }
}

