namespace EchoMessenger
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
            label1 = new Label();
            Echowindow = new ListBox();
            textBox1 = new TextBox();
            전송 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(217, 66);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(319, 51);
            label1.TabIndex = 0;
            label1.Text = "Echo Messsenger";
            // 
            // Echowindow
            // 
            Echowindow.FormattingEnabled = true;
            Echowindow.Location = new Point(243, 162);
            Echowindow.Margin = new Padding(4, 5, 4, 5);
            Echowindow.Name = "Echowindow";
            Echowindow.Size = new Size(1018, 654);
            Echowindow.TabIndex = 1;
            Echowindow.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(319, 859);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(830, 57);
            textBox1.TabIndex = 2;
            textBox1.Text = " (여기에 입력하시오)";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // 전송
            // 
            전송.Location = new Point(1277, 824);
            전송.Margin = new Padding(4, 5, 4, 5);
            전송.Name = "전송";
            전송.Size = new Size(190, 127);
            전송.TabIndex = 3;
            전송.Text = "전송";
            전송.UseVisualStyleBackColor = true;
            전송.Click += 전송_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(21F, 50F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2124, 1308);
            Controls.Add(전송);
            Controls.Add(textBox1);
            Controls.Add(Echowindow);
            Controls.Add(label1);
            Font = new Font("맑은 고딕", 14F);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox Echowindow;
        private TextBox textBox1;
        private Button 전송;
    }
}
