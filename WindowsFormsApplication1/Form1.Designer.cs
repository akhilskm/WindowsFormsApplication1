namespace WindowsFormsApplication1
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
            this.button1 = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.answer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.op = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // num1
            // 
            this.num1.AccessibleName = "num1";
            this.num1.Location = new System.Drawing.Point(72, 64);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(50, 20);
            this.num1.TabIndex = 1;
            this.num1.Text = "Num1";
            this.num1.Enter += new System.EventHandler(this.num1_Enter);
            // 
            // num2
            // 
            this.num2.AccessibleName = "num2";
            this.num2.Location = new System.Drawing.Point(173, 64);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(50, 20);
            this.num2.TabIndex = 2;
            this.num2.Text = "Num2";
            this.num2.Enter += new System.EventHandler(this.num2_Enter);
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.answer.Location = new System.Drawing.Point(135, 169);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(0, 13);
            this.answer.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Answer : ";
            // 
            // op
            // 
            this.op.FormattingEnabled = true;
            this.op.Items.AddRange(new object[] {
            "+",
            "-",
            "x",
            "/"});
            this.op.Location = new System.Drawing.Point(128, 64);
            this.op.Name = "op";
            this.op.Size = new System.Drawing.Size(39, 21);
            this.op.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.op);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Label answer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox op;
    }
}

