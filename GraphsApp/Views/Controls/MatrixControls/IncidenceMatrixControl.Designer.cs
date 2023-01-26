namespace GraphsApp.Views.Controls.MatrixControls
{
    partial class IncidenceMatrixControl
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
            this.IncidenceMatrixGridControl = new GraphsApp.Views.Controls.MatrixControls.IncidenceMatrixGridControl();
            this.SuspendLayout();
            // 
            // IncidenceMatrixGridControl
            // 
            this.IncidenceMatrixGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IncidenceMatrixGridControl.Location = new System.Drawing.Point(0, 0);
            this.IncidenceMatrixGridControl.Name = "IncidenceMatrixGridControl";
            this.IncidenceMatrixGridControl.Size = new System.Drawing.Size(500, 396);
            this.IncidenceMatrixGridControl.TabIndex = 0;
            this.IncidenceMatrixGridControl.MatrixChanged += new System.EventHandler(this.IncidenceMatrixGridControl_MatrixChanged);
            // 
            // IncidenceMatrixControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.IncidenceMatrixGridControl);
            this.Name = "IncidenceMatrixControl";
            this.Controls.SetChildIndex(this.IncidenceMatrixGridControl, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private IncidenceMatrixGridControl IncidenceMatrixGridControl;
    }
}
