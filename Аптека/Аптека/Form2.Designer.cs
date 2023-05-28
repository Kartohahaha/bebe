namespace Аптека
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            menuStrip1 = new MenuStrip();
            авторToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.DialogResult = DialogResult.Continue;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(1215, 672);
            button1.Name = "button1";
            button1.Size = new Size(106, 40);
            button1.TabIndex = 0;
            button1.Text = "Выход";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(12, 131);
            button2.Name = "button2";
            button2.Size = new Size(231, 76);
            button2.TabIndex = 1;
            button2.Text = "Каталог";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(12, 253);
            button3.Name = "button3";
            button3.Size = new Size(231, 75);
            button3.TabIndex = 2;
            button3.Text = "Покупатели";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(12, 379);
            button4.Name = "button4";
            button4.Size = new Size(231, 75);
            button4.TabIndex = 3;
            button4.Text = "Поставщики";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { авторToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1333, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // авторToolStripMenuItem
            // 
            авторToolStripMenuItem.Name = "авторToolStripMenuItem";
            авторToolStripMenuItem.Size = new Size(65, 24);
            авторToolStripMenuItem.Text = "Автор";
            авторToolStripMenuItem.Click += авторToolStripMenuItem_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1613463263_11_p_fon_dlya_prezentatsii_pro_apteki_12;
            ClientSize = new Size(1333, 724);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Аптека";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem авторToolStripMenuItem;
    }
}