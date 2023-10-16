namespace triugol_niki
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
            this.button1 = new System.Windows.Forms.Button();
            this.third = new System.Windows.Forms.TextBox();
            this.second = new System.Windows.Forms.TextBox();
            this.first = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(149, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 67);
            this.button1.TabIndex = 0;
            this.button1.Text = "Проверка";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // third
            // 
            this.third.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.third.Location = new System.Drawing.Point(357, 143);
            this.third.Name = "third";
            this.third.Size = new System.Drawing.Size(100, 34);
            this.third.TabIndex = 4;
            this.third.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.first_KeyPress);
            // 
            // second
            // 
            this.second.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.second.Location = new System.Drawing.Point(191, 143);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(100, 34);
            this.second.TabIndex = 5;
            this.second.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.first_KeyPress);
            // 
            // first
            // 
            this.first.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.first.Location = new System.Drawing.Point(28, 143);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(100, 34);
            this.first.TabIndex = 6;
            this.first.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.first_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(34, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(398, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Введите стороны треугольника";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(482, 330);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.first);
            this.Controls.Add(this.second);
            this.Controls.Add(this.third);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form2";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox third;
        private System.Windows.Forms.TextBox second;
        private System.Windows.Forms.TextBox first;
        private System.Windows.Forms.Label label4;
    }
}

