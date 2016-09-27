namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxNumber177 = new System.Windows.Forms.TextBox();
            this.textBoxNumber1 = new System.Windows.Forms.TextBox();
            this.textBoxNumber2 = new System.Windows.Forms.TextBox();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.comboBoxOp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNumber177
            // 
            this.textBoxNumber177.Location = new System.Drawing.Point(145, 98);
            this.textBoxNumber177.Name = "textBoxNumber177";
            this.textBoxNumber177.Size = new System.Drawing.Size(74, 22);
            this.textBoxNumber177.TabIndex = 6;
            this.textBoxNumber177.Text = "uuuu";
            // 
            // textBoxNumber1
            // 
            this.textBoxNumber1.Location = new System.Drawing.Point(12, 59);
            this.textBoxNumber1.Name = "textBoxNumber1";
            this.textBoxNumber1.Size = new System.Drawing.Size(78, 22);
            this.textBoxNumber1.TabIndex = 0;
            this.textBoxNumber1.Text = "0";
            // 
            // textBoxNumber2
            // 
            this.textBoxNumber2.Location = new System.Drawing.Point(145, 58);
            this.textBoxNumber2.Name = "textBoxNumber2";
            this.textBoxNumber2.Size = new System.Drawing.Size(74, 22);
            this.textBoxNumber2.TabIndex = 2;
            this.textBoxNumber2.Text = "0";
            // 
            // buttonEqual
            // 
            this.buttonEqual.Location = new System.Drawing.Point(225, 56);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(32, 25);
            this.buttonEqual.TabIndex = 3;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = true;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(263, 58);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(69, 22);
            this.textBoxResult.TabIndex = 4;
            this.textBoxResult.Text = "0";
            // 
            // comboBoxOp
            // 
            this.comboBoxOp.FormattingEnabled = true;
            this.comboBoxOp.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.comboBoxOp.Location = new System.Drawing.Point(96, 61);
            this.comboBoxOp.Name = "comboBoxOp";
            this.comboBoxOp.Size = new System.Drawing.Size(43, 20);
            this.comboBoxOp.TabIndex = 5;
            this.comboBoxOp.Text = "+";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "DDD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 230);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxOp);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.textBoxNumber2);
            this.Controls.Add(this.textBoxNumber1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxNumber177;
        private System.Windows.Forms.TextBox textBoxNumber1;
        private System.Windows.Forms.TextBox textBoxNumber2;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.ComboBox comboBoxOp;
        private System.Windows.Forms.Label label1;
    }
}

