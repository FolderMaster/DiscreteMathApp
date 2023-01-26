namespace GraphsApp.Views.Controls
{
    partial class ColorGraphControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ColorPickerControl1 = new GraphsApp.Views.Controls.MatrixControls.ColorPickerControl();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.Button = new System.Windows.Forms.Button();
            this.ColorPickerControl2 = new GraphsApp.Views.Controls.MatrixControls.ColorPickerControl();
            this.ColorPickerControl3 = new GraphsApp.Views.Controls.MatrixControls.ColorPickerControl();
            this.ColorPickerControl4 = new GraphsApp.Views.Controls.MatrixControls.ColorPickerControl();
            this.SuspendLayout();
            // 
            // ColorPickerControl1
            // 
            this.ColorPickerControl1.Location = new System.Drawing.Point(37, 0);
            this.ColorPickerControl1.Name = "ColorPickerControl1";
            this.ColorPickerControl1.SelectedColor = System.Drawing.Color.Red;
            this.ColorPickerControl1.Size = new System.Drawing.Size(75, 23);
            this.ColorPickerControl1.TabIndex = 0;
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(-3, 5);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(34, 13);
            this.ColorLabel.TabIndex = 1;
            this.ColorLabel.Text = "Color:";
            // 
            // Button
            // 
            this.Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button.Location = new System.Drawing.Point(363, 0);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(75, 23);
            this.Button.TabIndex = 2;
            this.Button.Text = "Color graph";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // ColorPickerControl2
            // 
            this.ColorPickerControl2.Location = new System.Drawing.Point(118, 0);
            this.ColorPickerControl2.Name = "ColorPickerControl2";
            this.ColorPickerControl2.SelectedColor = System.Drawing.Color.Blue;
            this.ColorPickerControl2.Size = new System.Drawing.Size(75, 23);
            this.ColorPickerControl2.TabIndex = 3;
            // 
            // ColorPickerControl3
            // 
            this.ColorPickerControl3.Location = new System.Drawing.Point(199, 0);
            this.ColorPickerControl3.Name = "ColorPickerControl3";
            this.ColorPickerControl3.SelectedColor = System.Drawing.Color.Lime;
            this.ColorPickerControl3.Size = new System.Drawing.Size(75, 23);
            this.ColorPickerControl3.TabIndex = 4;
            // 
            // ColorPickerControl4
            // 
            this.ColorPickerControl4.Location = new System.Drawing.Point(280, 0);
            this.ColorPickerControl4.Name = "ColorPickerControl4";
            this.ColorPickerControl4.SelectedColor = System.Drawing.Color.Yellow;
            this.ColorPickerControl4.Size = new System.Drawing.Size(75, 23);
            this.ColorPickerControl4.TabIndex = 5;
            // 
            // ColorGraphControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ColorPickerControl4);
            this.Controls.Add(this.ColorPickerControl3);
            this.Controls.Add(this.ColorPickerControl2);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.ColorPickerControl1);
            this.Name = "ColorGraphControl";
            this.Size = new System.Drawing.Size(438, 23);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MatrixControls.ColorPickerControl ColorPickerControl1;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Button Button;
        private MatrixControls.ColorPickerControl ColorPickerControl2;
        private MatrixControls.ColorPickerControl ColorPickerControl3;
        private MatrixControls.ColorPickerControl ColorPickerControl4;
    }
}
