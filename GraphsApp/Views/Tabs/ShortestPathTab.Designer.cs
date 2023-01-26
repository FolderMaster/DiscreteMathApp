namespace GraphsApp.Views.Tabs
{
    partial class ShortestPathTab
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
            this.EdgeEditorControl = new GraphsApp.Views.Controls.EdgeEditorControl();
            this.PathPickerControl = new GraphsApp.Views.Controls.PathPickerControl();
            this.EdgeEditorGroupBox = new System.Windows.Forms.GroupBox();
            this.DisplayGroupBox = new System.Windows.Forms.GroupBox();
            this.Schedule2DControl = new GraphsApp.Views.Controls.Schedule2DControl();
            this.EdgeEditorGroupBox.SuspendLayout();
            this.DisplayGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EdgeEditorControl
            // 
            this.EdgeEditorControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EdgeEditorControl.Location = new System.Drawing.Point(3, 16);
            this.EdgeEditorControl.Name = "EdgeEditorControl";
            this.EdgeEditorControl.Size = new System.Drawing.Size(677, 21);
            this.EdgeEditorControl.TabIndex = 0;
            // 
            // PathPickerControl
            // 
            this.PathPickerControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PathPickerControl.Location = new System.Drawing.Point(0, 0);
            this.PathPickerControl.Name = "PathPickerControl";
            this.PathPickerControl.Size = new System.Drawing.Size(683, 23);
            this.PathPickerControl.TabIndex = 1;
            // 
            // EdgeEditorGroupBox
            // 
            this.EdgeEditorGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdgeEditorGroupBox.Controls.Add(this.EdgeEditorControl);
            this.EdgeEditorGroupBox.Location = new System.Drawing.Point(0, 29);
            this.EdgeEditorGroupBox.Name = "EdgeEditorGroupBox";
            this.EdgeEditorGroupBox.Size = new System.Drawing.Size(683, 40);
            this.EdgeEditorGroupBox.TabIndex = 2;
            this.EdgeEditorGroupBox.TabStop = false;
            this.EdgeEditorGroupBox.Text = "Edge editor";
            // 
            // DisplayGroupBox
            // 
            this.DisplayGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DisplayGroupBox.Controls.Add(this.Schedule2DControl);
            this.DisplayGroupBox.Location = new System.Drawing.Point(0, 75);
            this.DisplayGroupBox.Name = "DisplayGroupBox";
            this.DisplayGroupBox.Size = new System.Drawing.Size(683, 314);
            this.DisplayGroupBox.TabIndex = 3;
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
            this.Schedule2DControl.Size = new System.Drawing.Size(677, 295);
            this.Schedule2DControl.TabIndex = 0;
            // 
            // ShortestPathTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DisplayGroupBox);
            this.Controls.Add(this.EdgeEditorGroupBox);
            this.Controls.Add(this.PathPickerControl);
            this.Name = "ShortestPathTab";
            this.Size = new System.Drawing.Size(683, 389);
            this.EdgeEditorGroupBox.ResumeLayout(false);
            this.DisplayGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.EdgeEditorControl EdgeEditorControl;
        private Controls.PathPickerControl PathPickerControl;
        private System.Windows.Forms.GroupBox EdgeEditorGroupBox;
        private System.Windows.Forms.GroupBox DisplayGroupBox;
        private Controls.Schedule2DControl Schedule2DControl;
    }
}
