namespace GraphsApp.Views.Tabs
{
    partial class PathMatrixTab
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
            this.PathMatrixGroupBox = new System.Windows.Forms.GroupBox();
            this.AdjacencyMatrixGridControl = new GraphsApp.Views.Controls.AdjacencyMatrixGridControl();
            this.PathMatrixControl = new GraphsApp.Views.Controls.PathMatrixControl();
            this.AdjacencyMatrixGroupBox.SuspendLayout();
            this.PathMatrixGroupBox.SuspendLayout();
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
            this.AdjacencyMatrixGroupBox.Text = "AdjacencyMatrix";
            // 
            // PathMatrixGroupBox
            // 
            this.PathMatrixGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PathMatrixGroupBox.Controls.Add(this.PathMatrixControl);
            this.PathMatrixGroupBox.Location = new System.Drawing.Point(378, 0);
            this.PathMatrixGroupBox.Name = "PathMatrixGroupBox";
            this.PathMatrixGroupBox.Size = new System.Drawing.Size(436, 418);
            this.PathMatrixGroupBox.TabIndex = 1;
            this.PathMatrixGroupBox.TabStop = false;
            this.PathMatrixGroupBox.Text = "PathMatrix";
            // 
            // AdjacencyMatrixGridControl
            // 
            this.AdjacencyMatrixGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdjacencyMatrixGridControl.Location = new System.Drawing.Point(3, 16);
            this.AdjacencyMatrixGridControl.Name = "AdjacencyMatrixGridControl";
            this.AdjacencyMatrixGridControl.Size = new System.Drawing.Size(366, 399);
            this.AdjacencyMatrixGridControl.TabIndex = 0;
            // 
            // PathMatrixControl
            // 
            this.PathMatrixControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PathMatrixControl.Location = new System.Drawing.Point(3, 16);
            this.PathMatrixControl.Name = "PathMatrixControl";
            this.PathMatrixControl.Size = new System.Drawing.Size(430, 399);
            this.PathMatrixControl.TabIndex = 0;
            // 
            // PathMatrixTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PathMatrixGroupBox);
            this.Controls.Add(this.AdjacencyMatrixGroupBox);
            this.Name = "PathMatrixTab";
            this.Size = new System.Drawing.Size(814, 418);
            this.AdjacencyMatrixGroupBox.ResumeLayout(false);
            this.PathMatrixGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AdjacencyMatrixGroupBox;
        private System.Windows.Forms.GroupBox PathMatrixGroupBox;
        private Controls.AdjacencyMatrixGridControl AdjacencyMatrixGridControl;
        private Controls.PathMatrixControl PathMatrixControl;
    }
}
