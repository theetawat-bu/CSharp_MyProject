namespace RSA
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
            this.components = new System.ComponentModel.Container();
            this.BT_Calculate = new System.Windows.Forms.Button();
            this.richTextBox_showResult = new System.Windows.Forms.RichTextBox();
            this.First_Text_Prime = new System.Windows.Forms.TextBox();
            this.Second_Text_Prime = new System.Windows.Forms.TextBox();
            this.charecter = new System.Windows.Forms.TextBox();
            this.Random1 = new System.Windows.Forms.Button();
            this.Random2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_Calculate
            // 
            this.BT_Calculate.Location = new System.Drawing.Point(308, 23);
            this.BT_Calculate.Name = "BT_Calculate";
            this.BT_Calculate.Size = new System.Drawing.Size(110, 93);
            this.BT_Calculate.TabIndex = 0;
            this.BT_Calculate.Text = "Calculate";
            this.BT_Calculate.UseVisualStyleBackColor = true;
            this.BT_Calculate.Click += new System.EventHandler(this.BT_Calculate_Click);
            // 
            // richTextBox_showResult
            // 
            this.richTextBox_showResult.Location = new System.Drawing.Point(23, 143);
            this.richTextBox_showResult.Name = "richTextBox_showResult";
            this.richTextBox_showResult.ReadOnly = true;
            this.richTextBox_showResult.Size = new System.Drawing.Size(395, 197);
            this.richTextBox_showResult.TabIndex = 1;
            this.richTextBox_showResult.Text = "";
            // 
            // First_Text_Prime
            // 
            this.First_Text_Prime.Location = new System.Drawing.Point(50, 23);
            this.First_Text_Prime.Name = "First_Text_Prime";
            this.First_Text_Prime.Size = new System.Drawing.Size(100, 20);
            this.First_Text_Prime.TabIndex = 2;
            // 
            // Second_Text_Prime
            // 
            this.Second_Text_Prime.Location = new System.Drawing.Point(50, 60);
            this.Second_Text_Prime.Name = "Second_Text_Prime";
            this.Second_Text_Prime.Size = new System.Drawing.Size(100, 20);
            this.Second_Text_Prime.TabIndex = 3;
            // 
            // charecter
            // 
            this.charecter.Location = new System.Drawing.Point(50, 96);
            this.charecter.Name = "charecter";
            this.charecter.Size = new System.Drawing.Size(100, 20);
            this.charecter.TabIndex = 4;
            // 
            // Random1
            // 
            this.Random1.Location = new System.Drawing.Point(181, 23);
            this.Random1.Name = "Random1";
            this.Random1.Size = new System.Drawing.Size(75, 23);
            this.Random1.TabIndex = 5;
            this.Random1.Text = "Random";
            this.Random1.UseVisualStyleBackColor = true;
            this.Random1.Click += new System.EventHandler(this.Random1_Click);
            // 
            // Random2
            // 
            this.Random2.Location = new System.Drawing.Point(181, 58);
            this.Random2.Name = "Random2";
            this.Random2.Size = new System.Drawing.Size(75, 23);
            this.Random2.TabIndex = 6;
            this.Random2.Text = "Random";
            this.Random2.UseVisualStyleBackColor = true;
            this.Random2.Click += new System.EventHandler(this.Random2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 361);
            this.Controls.Add(this.Random2);
            this.Controls.Add(this.Random1);
            this.Controls.Add(this.charecter);
            this.Controls.Add(this.Second_Text_Prime);
            this.Controls.Add(this.First_Text_Prime);
            this.Controls.Add(this.richTextBox_showResult);
            this.Controls.Add(this.BT_Calculate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "RSA Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Calculate;
        private System.Windows.Forms.RichTextBox richTextBox_showResult;
        private System.Windows.Forms.TextBox First_Text_Prime;
        private System.Windows.Forms.TextBox Second_Text_Prime;
        private System.Windows.Forms.TextBox charecter;
        private System.Windows.Forms.Button Random1;
        private System.Windows.Forms.Button Random2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

