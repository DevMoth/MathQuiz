namespace MathQuiz
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
            this.components = new System.ComponentModel.Container();
            this.Equation_text = new System.Windows.Forms.Label();
            this.EquationAnswer_input = new System.Windows.Forms.TextBox();
            this.Answer_button = new System.Windows.Forms.Button();
            this.Lifes_text = new System.Windows.Forms.Label();
            this.Attempts_text = new System.Windows.Forms.Label();
            this.CorrectAnswer_text = new System.Windows.Forms.Label();
            this.Delay = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Equation_text
            // 
            this.Equation_text.AutoSize = true;
            this.Equation_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 56F);
            this.Equation_text.Location = new System.Drawing.Point(12, 29);
            this.Equation_text.Name = "Equation_text";
            this.Equation_text.Size = new System.Drawing.Size(542, 107);
            this.Equation_text.TabIndex = 0;
            this.Equation_text.Text = "100 + 100 =";
            this.Equation_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EquationAnswer_input
            // 
            this.EquationAnswer_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 56F);
            this.EquationAnswer_input.Location = new System.Drawing.Point(560, 27);
            this.EquationAnswer_input.Name = "EquationAnswer_input";
            this.EquationAnswer_input.Size = new System.Drawing.Size(150, 113);
            this.EquationAnswer_input.TabIndex = 1;
            // 
            // Answer_button
            // 
            this.Answer_button.BackColor = System.Drawing.Color.LightGray;
            this.Answer_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 56F);
            this.Answer_button.Location = new System.Drawing.Point(12, 160);
            this.Answer_button.Name = "Answer_button";
            this.Answer_button.Size = new System.Drawing.Size(500, 200);
            this.Answer_button.TabIndex = 2;
            this.Answer_button.Text = "Ответить";
            this.Answer_button.UseVisualStyleBackColor = false;
            this.Answer_button.Click += new System.EventHandler(this.Answer_button_Click);
            // 
            // Lifes_text
            // 
            this.Lifes_text.AutoSize = true;
            this.Lifes_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 56F);
            this.Lifes_text.Location = new System.Drawing.Point(518, 208);
            this.Lifes_text.Name = "Lifes_text";
            this.Lifes_text.Size = new System.Drawing.Size(488, 107);
            this.Lifes_text.TabIndex = 3;
            this.Lifes_text.Text = "3 попытки";
            // 
            // Attempts_text
            // 
            this.Attempts_text.AutoSize = true;
            this.Attempts_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 56F);
            this.Attempts_text.Location = new System.Drawing.Point(12, 624);
            this.Attempts_text.Name = "Attempts_text";
            this.Attempts_text.Size = new System.Drawing.Size(1260, 107);
            this.Attempts_text.TabIndex = 4;
            this.Attempts_text.Text = "0 правильно 0 неправильно";
            // 
            // CorrectAnswer_text
            // 
            this.CorrectAnswer_text.AutoSize = true;
            this.CorrectAnswer_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 56F);
            this.CorrectAnswer_text.Location = new System.Drawing.Point(12, 436);
            this.CorrectAnswer_text.Name = "CorrectAnswer_text";
            this.CorrectAnswer_text.Size = new System.Drawing.Size(937, 107);
            this.CorrectAnswer_text.TabIndex = 5;
            this.CorrectAnswer_text.Text = "Правильный ответ 4";
            // 
            // Delay
            // 
            this.Delay.Interval = 1000;
            this.Delay.Tick += new System.EventHandler(this.Delay_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.CorrectAnswer_text);
            this.Controls.Add(this.Attempts_text);
            this.Controls.Add(this.Lifes_text);
            this.Controls.Add(this.Answer_button);
            this.Controls.Add(this.EquationAnswer_input);
            this.Controls.Add(this.Equation_text);
            this.Name = "Form1";
            this.Text = "Математик 2000";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Equation_text;
        private System.Windows.Forms.TextBox EquationAnswer_input;
        private System.Windows.Forms.Button Answer_button;
        private System.Windows.Forms.Label Lifes_text;
        private System.Windows.Forms.Label Attempts_text;
        private System.Windows.Forms.Label CorrectAnswer_text;
        private System.Windows.Forms.Timer Delay;
    }
}

