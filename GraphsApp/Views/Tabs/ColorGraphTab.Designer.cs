namespace GraphsApp.Views.Tabs
{
    partial class ColorGraphTab
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
            GraphsApp.Services.App.Settings settings1 = new GraphsApp.Services.App.Settings();
            this.DisplayGroupBox = new System.Windows.Forms.GroupBox();
            this.Schedule2DControl = new GraphsApp.Views.Controls.Schedule2DControl();
            this.ColorGraphControl = new GraphsApp.Views.Controls.ColorControls.ColorGraphControl();
            this.DisplayGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DisplayGroupBox
            // 
            this.DisplayGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DisplayGroupBox.Controls.Add(this.Schedule2DControl);
            this.DisplayGroupBox.Location = new System.Drawing.Point(250, 0);
            this.DisplayGroupBox.Name = "DisplayGroupBox";
            this.DisplayGroupBox.Size = new System.Drawing.Size(311, 329);
            this.DisplayGroupBox.TabIndex = 1;
            this.DisplayGroupBox.TabStop = false;
            this.DisplayGroupBox.Text = "Display";
            // 
            // Schedule2DControl
            // 
            this.Schedule2DControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Schedule2DControl.Location = new System.Drawing.Point(3, 16);
            this.Schedule2DControl.Name = "Schedule2DControl";
            settings1.CorrectColor = System.Drawing.Color.White;
            settings1.ErrorColor = System.Drawing.Color.LightPink;
            settings1.LineXSize = 20;
            settings1.LineYSize = 20;
            settings1.PointSize = 10;
            settings1.SavePath = "Save.txt";
            settings1.ValueFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Schedule2DControl.Settings = settings1;
            this.Schedule2DControl.Size = new System.Drawing.Size(305, 310);
            this.Schedule2DControl.TabIndex = 0;
            // 
            // ColorGraphControl
            // 
            this.ColorGraphControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ColorGraphControl.Location = new System.Drawing.Point(0, 0);
            this.ColorGraphControl.Name = "ColorGraphControl";
            this.ColorGraphControl.Size = new System.Drawing.Size(244, 329);
            this.ColorGraphControl.TabIndex = 2;
            this.ColorGraphControl.ButtonClicked += new System.EventHandler(this.ColorGraphControl_ButtonClicked);
            // 
            // ColorGraphTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ColorGraphControl);
            this.Controls.Add(this.DisplayGroupBox);
            this.Name = "ColorGraphTab";
            this.Size = new System.Drawing.Size(561, 329);
            this.DisplayGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox DisplayGroupBox;
        private Controls.Schedule2DControl Schedule2DControl;
        private Controls.ColorControls.ColorGraphControl ColorGraphControl;
    }
}
