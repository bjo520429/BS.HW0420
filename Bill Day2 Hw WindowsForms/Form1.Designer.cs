namespace Bill_Day2_Hw_WindowsForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("微軟正黑體", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button1.Location = new Point(116, 180);
            button1.Name = "button1";
            button1.Size = new Size(250, 50);
            button1.TabIndex = 0;
            button1.Text = "查詢 (非迴圈計算)";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(116, 334);
            label1.Name = "label1";
            label1.Size = new Size(401, 40);
            label1.TabIndex = 1;
            label1.Text = "==請於輸入後點選查詢==";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(353, 118);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(270, 38);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("微軟正黑體", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(116, 120);
            label2.Name = "label2";
            label2.Size = new Size(231, 34);
            label2.TabIndex = 3;
            label2.Text = "請輸入西元年份：";
            // 
            // button2
            // 
            button2.Font = new Font("微軟正黑體", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button2.Location = new Point(116, 250);
            button2.Name = "button2";
            button2.Size = new Size(250, 50);
            button2.TabIndex = 4;
            button2.Text = "查詢 (迴圈計算)";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(436, 183);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 5;
            button3.Text = "新方法";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 523);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Button button2;
        private Button button3;
    }
}
