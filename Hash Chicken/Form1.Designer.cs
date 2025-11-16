namespace Hash_Chicken
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            txtFilePath = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ForeColor = Color.FromArgb(255, 128, 0);
            button1.Location = new Point(12, 330);
            button1.Name = "button1";
            button1.Size = new Size(155, 69);
            button1.TabIndex = 0;
            button1.Text = "Hash";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(173, 368);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1092, 31);
            textBox1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(112, 76);
            button2.TabIndex = 2;
            button2.Text = "File";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(151, 35);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(480, 31);
            txtFilePath.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 302);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 4;
            label1.Text = "Sha256";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1277, 411);
            Controls.Add(label1);
            Controls.Add(txtFilePath);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private TextBox txtFilePath;
        private Label label1;
    }
}
