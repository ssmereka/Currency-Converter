namespace CurrencyConverter
{
    partial class MainForm
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
            this.inputTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OutputTxt = new System.Windows.Forms.TextBox();
            this.ConvertBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputTxt
            // 
            this.inputTxt.Location = new System.Drawing.Point(161, 12);
            this.inputTxt.Name = "inputTxt";
            this.inputTxt.Size = new System.Drawing.Size(240, 22);
            this.inputTxt.TabIndex = 0;
            this.inputTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.inputTxt_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Amount in Euro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Converted Amount";
            // 
            // OutputTxt
            // 
            this.OutputTxt.Enabled = false;
            this.OutputTxt.Location = new System.Drawing.Point(161, 51);
            this.OutputTxt.Name = "OutputTxt";
            this.OutputTxt.Size = new System.Drawing.Size(240, 22);
            this.OutputTxt.TabIndex = 3;
            // 
            // ConvertBtn
            // 
            this.ConvertBtn.Enabled = false;
            this.ConvertBtn.Location = new System.Drawing.Point(15, 96);
            this.ConvertBtn.Name = "ConvertBtn";
            this.ConvertBtn.Size = new System.Drawing.Size(386, 38);
            this.ConvertBtn.TabIndex = 4;
            this.ConvertBtn.Text = "Convert";
            this.ConvertBtn.UseVisualStyleBackColor = true;
            this.ConvertBtn.Click += new System.EventHandler(this.ConvertBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 146);
            this.Controls.Add(this.ConvertBtn);
            this.Controls.Add(this.OutputTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputTxt);
            this.Name = "MainForm";
            this.Text = "Currency Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OutputTxt;
        private System.Windows.Forms.Button ConvertBtn;
    }
}

