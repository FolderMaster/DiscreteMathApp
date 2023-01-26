namespace GraphsApp.Views.Tabs
{
    partial class PathCountTab
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
            this.AdjacencyMatrixGroupBox = new System.Windows.Forms.GroupBox();
            this.AdjacencyMatrixGridControl = new GraphsApp.Views.Controls.MatrixControls.AdjacencyMatrixGridControl();
            this.PathCountMatrixGroupBox = new System.Windows.Forms.GroupBox();
            this.PathCountMatrixControl = new GraphsApp.Views.Controls.MatrixControls.PathCountMatrixControl();
            this.AdjacencyMatrixGroupBox.SuspendLayout();
            this.PathCountMatrixGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdjacencyMatrixGroupBox
            // 
            this.AdjacencyMatrixGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AdjacencyMatrixGroupBox.Controls.Add(this.AdjacencyMatrixGridControl);
            this.AdjacencyMatrixGroupBox.Location = new System.Drawing.Point(0, 0);
            this.AdjacencyMatrixGroupBox.Name = "AdjacencyMatrixGroupBox";
            this.AdjacencyMatrixGroupBox.Size = new System.Drawing.Size(372, 418);
            this.AdjacencyMatrixGroupBox.TabIndex = 0;
            this.AdjacencyMatrixGroupBox.TabStop = false;
            this.AdjacencyMatrixGroupBox.Text = "Adjacency matrix";
            // 
            // AdjacencyMatrixGridControl
            // 
            this.AdjacencyMatrixGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdjacencyMatrixGridControl.Location = new System.Drawing.Point(3, 16);
            this.AdjacencyMatrixGridControl.Name = "AdjacencyMatrixGridControl";
            this.AdjacencyMatrixGridControl.Size = new System.Drawing.Size(366, 399);
            this.AdjacencyMatrixGridControl.TabIndex = 0;
            // 
            // PathCountMatrixGroupBox
            // 
            this.PathCountMatrixGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PathCountMatrixGroupBox.Controls.Add(this.PathCountMatrixControl);
            this.PathCountMatrixGroupBox.Location = new System.Drawing.Point(378, 0);
            this.PathCountMatrixGroupBox.Name = "PathCountMatrixGroupBox";
            this.PathCountMatrixGroupBox.Size = new System.Drawing.Size(436, 418);
            this.PathCountMatrixGroupBox.TabIndex = 1;
            this.PathCountMatrixGroupBox.TabStop = false;
            this.PathCountMatrixGroupBox.Text = "Path count matrix";
            // 
            // PathCountMatrixControl
            // 
            this.PathCountMatrixControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PathCountMatrixControl.Location = new System.Drawing.Point(3, 16);
            this.PathCountMatrixControl.Name = "PathCountMatrixControl";
            this.PathCountMatrixControl.Size = new System.Drawing.Size(430, 399);
            this.PathCountMatrixControl.TabIndex = 0;
            // 
            // PathCountMatrixTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PathCountMatrixGroupBox);
            this.Controls.Add(this.AdjacencyMatrixGroupBox);
            this.Name = "PathCountMatrixTab";
            this.Size = new System.Drawing.Size(814, 418);
            this.AdjacencyMatrixGroupBox.ResumeLayout(false);
            this.PathCountMatrixGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AdjacencyMatrixGroupBox;
        private System.Windows.Forms.GroupBox PathCountMatrixGroupBox;
        private Controls.MatrixControls.AdjacencyMatrixGridControl AdjacencyMatrixGridControl;
        private Controls.MatrixControls.PathCountMatrixControl PathCountMatrixControl;
    }
}
