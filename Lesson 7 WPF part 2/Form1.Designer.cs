
namespace Lesson_7_WPF_part_2
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
            this.FiguresComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Width = new System.Windows.Forms.TextBox();
            this.Height = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Fill_Btn = new System.Windows.Forms.RadioButton();
            this.Empty_Btn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // FiguresComboBox
            // 
            this.FiguresComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FiguresComboBox.FormattingEnabled = true;
            this.FiguresComboBox.Location = new System.Drawing.Point(14, 35);
            this.FiguresComboBox.Margin = new System.Windows.Forms.Padding(25);
            this.FiguresComboBox.Name = "FiguresComboBox";
            this.FiguresComboBox.Size = new System.Drawing.Size(204, 39);
            this.FiguresComboBox.TabIndex = 0;
            this.FiguresComboBox.SelectedIndexChanged += new System.EventHandler(this.FiguresComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(251, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Width";
            // 
            // Width
            // 
            this.Width.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Width.Location = new System.Drawing.Point(350, 36);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(100, 38);
            this.Width.TabIndex = 3;
            this.Width.Text = "100";
            // 
            // Height
            // 
            this.Height.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Height.Location = new System.Drawing.Point(597, 36);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(100, 38);
            this.Height.TabIndex = 5;
            this.Height.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(481, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(723, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Colours";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(842, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "SELECT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Fill_Btn
            // 
            this.Fill_Btn.AutoSize = true;
            this.Fill_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Fill_Btn.Location = new System.Drawing.Point(974, 35);
            this.Fill_Btn.Name = "Fill_Btn";
            this.Fill_Btn.Size = new System.Drawing.Size(67, 33);
            this.Fill_Btn.TabIndex = 8;
            this.Fill_Btn.TabStop = true;
            this.Fill_Btn.Text = "Fill";
            this.Fill_Btn.UseVisualStyleBackColor = true;
            // 
            // Empty_Btn
            // 
            this.Empty_Btn.AutoSize = true;
            this.Empty_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Empty_Btn.Location = new System.Drawing.Point(1066, 35);
            this.Empty_Btn.Name = "Empty_Btn";
            this.Empty_Btn.Size = new System.Drawing.Size(101, 33);
            this.Empty_Btn.TabIndex = 9;
            this.Empty_Btn.TabStop = true;
            this.Empty_Btn.Text = "Empty";
            this.Empty_Btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 661);
            this.Controls.Add(this.Empty_Btn);
            this.Controls.Add(this.Fill_Btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Width);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FiguresComboBox);
            this.MaximumSize = new System.Drawing.Size(1240, 708);
            this.MinimumSize = new System.Drawing.Size(1240, 708);
            this.Name = "Form1";
            this.Text = "Paint";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FiguresComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Width;
        private System.Windows.Forms.TextBox Height;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton Fill_Btn;
        private System.Windows.Forms.RadioButton Empty_Btn;
    }
}

