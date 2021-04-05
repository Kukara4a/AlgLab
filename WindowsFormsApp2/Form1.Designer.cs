
namespace AlgorithmsLab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_p = new System.Windows.Forms.TextBox();
            this.textBox_q = new System.Windows.Forms.TextBox();
            this.textBox_e = new System.Windows.Forms.TextBox();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_d = new System.Windows.Forms.TextBox();
            this.textBox_n1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEncrypt.Location = new System.Drawing.Point(253, 91);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(262, 62);
            this.buttonEncrypt.TabIndex = 0;
            this.buttonEncrypt.Text = "Зашифровать";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(253, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 62);
            this.button1.TabIndex = 1;
            this.button1.Text = "Расшифровать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox_p
            // 
            this.textBox_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_p.Location = new System.Drawing.Point(114, 34);
            this.textBox_p.Name = "textBox_p";
            this.textBox_p.Size = new System.Drawing.Size(204, 37);
            this.textBox_p.TabIndex = 2;
            // 
            // textBox_q
            // 
            this.textBox_q.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_q.Location = new System.Drawing.Point(498, 34);
            this.textBox_q.Name = "textBox_q";
            this.textBox_q.Size = new System.Drawing.Size(227, 37);
            this.textBox_q.TabIndex = 3;
            // 
            // textBox_e
            // 
            this.textBox_e.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_e.Location = new System.Drawing.Point(294, 186);
            this.textBox_e.Name = "textBox_e";
            this.textBox_e.Size = new System.Drawing.Size(150, 32);
            this.textBox_e.TabIndex = 4;
            // 
            // textBox_n
            // 
            this.textBox_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_n.Location = new System.Drawing.Point(574, 269);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.Size = new System.Drawing.Size(151, 32);
            this.textBox_n.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(44, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 49);
            this.label1.TabIndex = 6;
            this.label1.Text = "p = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(426, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "q = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(221, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "d = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(502, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "n = ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(7, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Открытый ключ: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(221, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 30);
            this.label6.TabIndex = 12;
            this.label6.Text = "e = ";
            // 
            // textBox_d
            // 
            this.textBox_d.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_d.Location = new System.Drawing.Point(294, 269);
            this.textBox_d.Name = "textBox_d";
            this.textBox_d.Size = new System.Drawing.Size(150, 32);
            this.textBox_d.TabIndex = 13;
            // 
            // textBox_n1
            // 
            this.textBox_n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_n1.Location = new System.Drawing.Point(574, 182);
            this.textBox_n1.Name = "textBox_n1";
            this.textBox_n1.Size = new System.Drawing.Size(151, 32);
            this.textBox_n1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(502, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 30);
            this.label7.TabIndex = 15;
            this.label7.Text = "n = ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(7, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 29);
            this.label8.TabIndex = 16;
            this.label8.Text = "Закрытый ключ: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_n1);
            this.Controls.Add(this.textBox_d);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_n);
            this.Controls.Add(this.textBox_e);
            this.Controls.Add(this.textBox_q);
            this.Controls.Add(this.textBox_p);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonEncrypt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_p;
        private System.Windows.Forms.TextBox textBox_q;
        private System.Windows.Forms.TextBox textBox_e;
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_d;
        private System.Windows.Forms.TextBox textBox_n1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

