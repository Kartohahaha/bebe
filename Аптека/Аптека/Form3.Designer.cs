namespace Аптека
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(278, 149);
            button1.Name = "button1";
            button1.Size = new Size(138, 95);
            button1.TabIndex = 0;
            button1.Text = "Лекарства и БАДы";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(558, 149);
            button2.Name = "button2";
            button2.Size = new Size(138, 95);
            button2.TabIndex = 1;
            button2.Text = "Активная косметика";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(844, 149);
            button3.Name = "button3";
            button3.Size = new Size(138, 95);
            button3.TabIndex = 2;
            button3.Text = "Красота и здоровье";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(278, 377);
            button4.Name = "button4";
            button4.Size = new Size(138, 95);
            button4.TabIndex = 3;
            button4.Text = "Мама и малыш";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(558, 377);
            button5.Name = "button5";
            button5.Size = new Size(138, 95);
            button5.TabIndex = 4;
            button5.Text = "Медицинские приборы";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(856, 377);
            button6.Name = "button6";
            button6.Size = new Size(138, 95);
            button6.TabIndex = 5;
            button6.Text = "Ортопедия";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ButtonHighlight;
            button7.Location = new Point(1209, 675);
            button7.Name = "button7";
            button7.Size = new Size(112, 37);
            button7.TabIndex = 6;
            button7.Text = "Назад";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1613463263_11_p_fon_dlya_prezentatsii_pro_apteki_12;
            ClientSize = new Size(1333, 724);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Каталог";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}