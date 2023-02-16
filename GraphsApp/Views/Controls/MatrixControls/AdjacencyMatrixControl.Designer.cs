namespace GraphsApp.Views.Controls.MatrixControls
{
    partial class AdjacencyMatrixControl
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
            this.AdjacencyMatrixGridControl = new GraphsApp.Views.Controls.MatrixControls.AdjacencyMatrixGridControl();
            this.SuspendLayout();
            // 
            // AdjacencyMatrixGridControl
            // 
            this.AdjacencyMatrixGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdjacencyMatrixGridControl.Location = new System.Drawing.Point(0, 0);
            this.AdjacencyMatrixGridControl.Name = "AdjacencyMatrixGridControl";
            this.AdjacencyMatrixGridControl.Size = new System.Drawing.Size(500, 367);
            this.AdjacencyMatrixGridControl.TabIndex = 22;
            this.AdjacencyMatrixGridControl.MatrixChanged += new System.EventHandler(this.AdjacencyMatrixGridControl_MatrixChanged);
            // 
            // AdjacencyMatrixControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AdjacencyMatrixGridControl);
            this.Name = "AdjacencyMatrixControl";
            this.Controls.SetChildIndex(this.AdjacencyMatrixGridControl, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AdjacencyMatrixGridControl AdjacencyMatrixGridControl;
    }
}
