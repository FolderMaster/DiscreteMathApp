namespace GraphsApp.Views.Controls
{
    partial class PathPickerControl
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
            this.ShortestPathFromLabel = new System.Windows.Forms.Label();
            this.ToLabel = new System.Windows.Forms.Label();
            this.ToVertexSelectorControl = new GraphsApp.Views.Controls.VertexSelectorControl();
            this.FromVertexSelectorControl = new GraphsApp.Views.Controls.VertexSelectorControl();
            this.SuspendLayout();
            // 
            // Button
            // 
            this.Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button.Location = new System.Drawing.Point(373, 0);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(75, 23);
            this.Button.TabIndex = 0;
            this.Button.Text = "Find";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // ShortestPathFromLabel
            // 
            this.ShortestPathFromLabel.AutoSize = true;
            this.ShortestPathFromLabel.Location = new System.Drawing.Point(-3, 5);
            this.ShortestPathFromLabel.Name = "ShortestPathFromLabel";
            this.ShortestPathFromLabel.Size = new System.Drawing.Size(93, 13);
            this.ShortestPathFromLabel.TabIndex = 1;
            this.ShortestPathFromLabel.Text = "Shortest path from";
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Location = new System.Drawing.Point(223, 5);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(16, 13);
            this.ToLabel.TabIndex = 2;
            this.ToLabel.Text = "to";
            // 
            // ToVertexSelectorControl
            // 
            this.ToVertexSelectorControl.Location = new System.Drawing.Point(245, 0);
            this.ToVertexSelectorControl.Name = "ToVertexSelectorControl";
            this.ToVertexSelectorControl.Size = new System.Drawing.Size(121, 21);
            this.ToVertexSelectorControl.TabIndex = 3;
            // 
            // FromVertexSelectorControl
            // 
            this.FromVertexSelectorControl.Location = new System.Drawing.Point(96, 0);
            this.FromVertexSelectorControl.Name = "FromVertexSelectorControl";
            this.FromVertexSelectorControl.Size = new System.Drawing.Size(121, 21);
            this.FromVertexSelectorControl.TabIndex = 4;
            // 
            // PathPickerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FromVertexSelectorControl);
            this.Controls.Add(this.ToVertexSelectorControl);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.ShortestPathFromLabel);
            this.Controls.Add(this.Button);
            this.Name = "PathPickerControl";
            this.Size = new System.Drawing.Size(448, 23);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.Label ShortestPathFromLabel;
        private System.Windows.Forms.Label ToLabel;
        private VertexSelectorControl ToVertexSelectorControl;
        private VertexSelectorControl FromVertexSelectorControl;
    }
}
