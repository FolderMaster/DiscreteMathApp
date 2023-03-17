namespace GraphsApp.Views.Controls.ColorControls
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
            this.Button = new System.Windows.Forms.Button();
            this.ColorsGroupBox = new System.Windows.Forms.GroupBox();
            this.ColorListControl = new GraphsApp.Views.Controls.ColorControls.ColorListControl();
            this.ColorsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(0, 0);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(75, 23);
            this.Button.TabIndex = 2;
            this.Button.Text = "Color graph";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // ColorsGroupBox
            // 
            this.ColorsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorsGroupBox.Controls.Add(this.ColorListControl);
            this.ColorsGroupBox.Location = new System.Drawing.Point(0, 29);
            this.ColorsGroupBox.Name = "ColorsGroupBox";
            this.ColorsGroupBox.Size = new System.Drawing.Size(438, 451);
            this.ColorsGroupBox.TabIndex = 3;
            this.ColorsGroupBox.TabStop = false;
            this.ColorsGroupBox.Text = "Colors";
            // 
            // ColorListControl
            // 
            this.ColorListControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColorListControl.Location = new System.Drawing.Point(3, 16);
            this.ColorListControl.Name = "ColorListControl";
            this.ColorListControl.Size = new System.Drawing.Size(432, 432);
            this.ColorListControl.TabIndex = 0;
            // 
            // ColorGraphControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ColorsGroupBox);
            this.Controls.Add(this.Button);
            this.Name = "ColorGraphControl";
            this.Size = new System.Drawing.Size(438, 480);
            this.ColorsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.GroupBox ColorsGroupBox;
        private ColorListControl ColorListControl;
    }
}
