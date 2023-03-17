namespace GraphsApp.Views.Controls.PathControls
{
    partial class EdgeEditorControl
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
            this.components = new System.ComponentModel.Container();
            this.EdgeSelectorControl = new GraphsApp.Views.Controls.PathControls.EdgeSelectorControl();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // EdgeSelectorControl
            // 
            this.EdgeSelectorControl.Location = new System.Drawing.Point(0, 0);
            this.EdgeSelectorControl.Name = "EdgeSelectorControl";
            this.EdgeSelectorControl.SelectedEdge = null;
            this.EdgeSelectorControl.Size = new System.Drawing.Size(121, 21);
            this.EdgeSelectorControl.TabIndex = 0;
            this.EdgeSelectorControl.SelectedEdgeChanged += new System.EventHandler(this.EdgeSelectorControl_SelectedEdgeChanged);
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(127, 3);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(44, 13);
            this.WeightLabel.TabIndex = 1;
            this.WeightLabel.Text = "Weight:";
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightTextBox.Location = new System.Drawing.Point(177, 0);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(174, 20);
            this.WeightTextBox.TabIndex = 2;
            this.WeightTextBox.TextChanged += new System.EventHandler(this.WeightTextBox_TextChanged);
            // 
            // EdgeEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WeightTextBox);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.EdgeSelectorControl);
            this.Name = "EdgeEditorControl";
            this.Size = new System.Drawing.Size(351, 21);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EdgeSelectorControl EdgeSelectorControl;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}
