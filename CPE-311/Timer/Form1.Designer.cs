
namespace Timer
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Parameter1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Parameter2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Parameter3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Label_Result = new System.Windows.Forms.Label();
            this.button_cal = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox_delay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "CK_CNT",
            "TIM_CLK",
            "PSC",
            "ARR"});
            this.comboBox1.Location = new System.Drawing.Point(133, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ต้องการหา";
            // 
            // Parameter1
            // 
            this.Parameter1.AutoSize = true;
            this.Parameter1.Location = new System.Drawing.Point(43, 90);
            this.Parameter1.Name = "Parameter1";
            this.Parameter1.Size = new System.Drawing.Size(61, 13);
            this.Parameter1.TabIndex = 3;
            this.Parameter1.Text = "Parameter1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(133, 129);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // Parameter2
            // 
            this.Parameter2.AutoSize = true;
            this.Parameter2.Location = new System.Drawing.Point(43, 136);
            this.Parameter2.Name = "Parameter2";
            this.Parameter2.Size = new System.Drawing.Size(61, 13);
            this.Parameter2.TabIndex = 5;
            this.Parameter2.Text = "Parameter2";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(133, 172);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // Parameter3
            // 
            this.Parameter3.AutoSize = true;
            this.Parameter3.Location = new System.Drawing.Point(43, 179);
            this.Parameter3.Name = "Parameter3";
            this.Parameter3.Size = new System.Drawing.Size(61, 13);
            this.Parameter3.TabIndex = 7;
            this.Parameter3.Text = "Parameter3";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(133, 207);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 10;
            // 
            // Label_Result
            // 
            this.Label_Result.AutoSize = true;
            this.Label_Result.Location = new System.Drawing.Point(43, 214);
            this.Label_Result.Name = "Label_Result";
            this.Label_Result.Size = new System.Drawing.Size(37, 13);
            this.Label_Result.TabIndex = 9;
            this.Label_Result.Text = "Result";
            // 
            // button_cal
            // 
            this.button_cal.Location = new System.Drawing.Point(281, 209);
            this.button_cal.Name = "button_cal";
            this.button_cal.Size = new System.Drawing.Size(75, 23);
            this.button_cal.TabIndex = 11;
            this.button_cal.Text = "Calculate";
            this.button_cal.UseVisualStyleBackColor = true;
            this.button_cal.Click += new System.EventHandler(this.button_cal_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Mhz",
            "hz"});
            this.comboBox2.Location = new System.Drawing.Point(257, 83);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(41, 21);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // textBox_delay
            // 
            this.textBox_delay.Location = new System.Drawing.Point(133, 251);
            this.textBox_delay.Name = "textBox_delay";
            this.textBox_delay.Size = new System.Drawing.Size(100, 20);
            this.textBox_delay.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Delay";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 309);
            this.Controls.Add(this.textBox_delay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button_cal);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Label_Result);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Parameter3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Parameter2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Parameter1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = " Timer Base Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Parameter1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Parameter2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label Parameter3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label Label_Result;
        private System.Windows.Forms.Button button_cal;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox_delay;
        private System.Windows.Forms.Label label3;
    }
}

