
namespace Figures
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
            this.ChooseFigure = new System.Windows.Forms.ComboBox();
            this.WidthValue = new System.Windows.Forms.TextBox();
            this.HeightValue = new System.Windows.Forms.TextBox();
            this.ChooseFill = new System.Windows.Forms.ComboBox();
            this.ChooseColor = new System.Windows.Forms.ComboBox();
            this.ChooseFillColor = new System.Windows.Forms.ComboBox();
            this.Info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChooseFigure
            // 
            this.ChooseFigure.FormattingEnabled = true;
            this.ChooseFigure.Location = new System.Drawing.Point(12, 10);
            this.ChooseFigure.Name = "ChooseFigure";
            this.ChooseFigure.Size = new System.Drawing.Size(205, 21);
            this.ChooseFigure.TabIndex = 2;
            // 
            // WidthValue
            // 
            this.WidthValue.Location = new System.Drawing.Point(350, 11);
            this.WidthValue.Name = "WidthValue";
            this.WidthValue.Size = new System.Drawing.Size(89, 20);
            this.WidthValue.TabIndex = 3;
            this.WidthValue.Text = "50";
            // 
            // HeightValue
            // 
            this.HeightValue.Location = new System.Drawing.Point(445, 11);
            this.HeightValue.Name = "HeightValue";
            this.HeightValue.Size = new System.Drawing.Size(89, 20);
            this.HeightValue.TabIndex = 4;
            this.HeightValue.Text = "50";
            // 
            // ChooseFill
            // 
            this.ChooseFill.FormattingEnabled = true;
            this.ChooseFill.Location = new System.Drawing.Point(223, 10);
            this.ChooseFill.Name = "ChooseFill";
            this.ChooseFill.Size = new System.Drawing.Size(121, 21);
            this.ChooseFill.TabIndex = 5;
            // 
            // ChooseColor
            // 
            this.ChooseColor.FormattingEnabled = true;
            this.ChooseColor.Location = new System.Drawing.Point(540, 11);
            this.ChooseColor.Name = "ChooseColor";
            this.ChooseColor.Size = new System.Drawing.Size(121, 21);
            this.ChooseColor.TabIndex = 6;
            // 
            // ChooseFillColor
            // 
            this.ChooseFillColor.FormattingEnabled = true;
            this.ChooseFillColor.Location = new System.Drawing.Point(667, 11);
            this.ChooseFillColor.Name = "ChooseFillColor";
            this.ChooseFillColor.Size = new System.Drawing.Size(121, 21);
            this.ChooseFillColor.TabIndex = 7;
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Location = new System.Drawing.Point(12, 43);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(25, 13);
            this.Info.TabIndex = 8;
            this.Info.Text = "Info";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.ChooseFillColor);
            this.Controls.Add(this.ChooseColor);
            this.Controls.Add(this.ChooseFill);
            this.Controls.Add(this.HeightValue);
            this.Controls.Add(this.WidthValue);
            this.Controls.Add(this.ChooseFigure);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ChooseFigure;
        private System.Windows.Forms.TextBox WidthValue;
        private System.Windows.Forms.TextBox HeightValue;
        private System.Windows.Forms.ComboBox ChooseFill;
        private System.Windows.Forms.ComboBox ChooseColor;
        private System.Windows.Forms.ComboBox ChooseFillColor;
        private System.Windows.Forms.Label Info;
    }
}

