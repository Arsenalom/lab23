namespace lab23
{
    partial class MForm
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
            zadanie1_button1 = new Button();
            zadanie1_button2 = new Button();
            zadanie1_button3 = new Button();
            SuspendLayout();
            // 
            // zadanie1_button1
            // 
            zadanie1_button1.Location = new Point(30, 45);
            zadanie1_button1.Name = "zadanie1_button1";
            zadanie1_button1.Size = new Size(94, 29);
            zadanie1_button1.TabIndex = 0;
            zadanie1_button1.Text = "задание 2";
            zadanie1_button1.UseVisualStyleBackColor = true;
            zadanie1_button1.Click += zadanie1_button1_Click;
            // 
            // zadanie1_button2
            // 
            zadanie1_button2.Location = new Point(32, 104);
            zadanie1_button2.Name = "zadanie1_button2";
            zadanie1_button2.Size = new Size(94, 29);
            zadanie1_button2.TabIndex = 1;
            zadanie1_button2.Text = "задание 3";
            zadanie1_button2.UseVisualStyleBackColor = true;
            zadanie1_button2.Click += zadanie1_button2_Click;
            // 
            // zadanie1_button3
            // 
            zadanie1_button3.Location = new Point(36, 150);
            zadanie1_button3.Name = "zadanie1_button3";
            zadanie1_button3.Size = new Size(94, 29);
            zadanie1_button3.TabIndex = 2;
            zadanie1_button3.Text = "задание 4";
            zadanie1_button3.UseVisualStyleBackColor = true;
            zadanie1_button3.Click += this.zadanie1_button3_Click_1;
            // 
            // MForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(232, 303);
            Controls.Add(zadanie1_button3);
            Controls.Add(zadanie1_button2);
            Controls.Add(zadanie1_button1);
            Name = "MForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "главная форма";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button zadanie1_button1;
        private Button zadanie1_button2;
        private Button zadanie1_button3;
    }
}
