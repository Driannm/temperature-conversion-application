namespace Aplikasi_Konversi_Suhu
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Poppins", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(250, 54);
            label1.Name = "label1";
            label1.Size = new Size(467, 65);
            label1.TabIndex = 0;
            label1.Text = "Aplikasi Konversi Suhu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Poppins SemiBold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(31, 208);
            label2.Name = "label2";
            label2.Size = new Size(180, 51);
            label2.TabIndex = 1;
            label2.Text = "Dari Suhu :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Poppins SemiBold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(31, 372);
            label3.Name = "label3";
            label3.Size = new Size(156, 51);
            label3.TabIndex = 2;
            label3.Text = "Ke Suhu :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Poppins SemiBold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(31, 650);
            label4.Name = "label4";
            label4.Size = new Size(110, 51);
            label4.TabIndex = 3;
            label4.Text = "Hasil :";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(217, 219);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(309, 30);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Cursor = Cursors.Cross;
            textBox2.Location = new Point(217, 664);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(309, 30);
            textBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "celcius", "reamur ", "fahrenheit ", "kelvin" });
            comboBox1.Location = new Point(601, 219);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(309, 34);
            comboBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "celcius", "reamur ", "fahrenheit ", "kelvin" });
            comboBox2.Location = new Point(217, 383);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(309, 34);
            comboBox2.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Poppins SemiBold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(217, 539);
            button1.Name = "button1";
            button1.Size = new Size(149, 42);
            button1.TabIndex = 8;
            button1.Text = "Prosess";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Font = new Font("Poppins SemiBold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(377, 539);
            button2.Name = "button2";
            button2.Size = new Size(149, 42);
            button2.TabIndex = 9;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1024, 740);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Poppins SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(3, 5, 3, 5);
            Name = "Form1";
            Text = "APLIKASI KONVERSI SUHU";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button1;
        private Button button2;
    }
}