namespace GraphsApp.Views.Controls.MatrixControls
{
    partial class PathCountMatrixControl
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
            this.PathLengthLabel = new System.Windows.Forms.Label();
            this.PathLengthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Button = new System.Windows.Forms.Button();
            this.AdjacencyMatrixGridControl = new GraphsApp.Views.Controls.MatrixControls.AdjacencyMatrixGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.PathLengthNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // PathLengthLabel
            // 
            this.PathLengthLabel.AutoSize = true;
            this.PathLengthLabel.Location = new System.Drawing.Point(-3, 5);
            this.PathLengthLabel.Name = "PathLengthLabel";
            this.PathLengthLabel.Size = new System.Drawing.Size(64, 13);
            this.PathLengthLabel.TabIndex = 0;
            this.PathLengthLabel.Text = "Path length:";
            // 
            // PathLengthNumericUpDown
            // 
            this.PathLengthNumericUpDown.Location = new System.Drawing.Point(67, 3);
            this.PathLengthNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PathLengthNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PathLengthNumericUpDown.Name = "PathLengthNumericUpDown";
            this.PathLengthNumericUpDown.Size = new System.Drawing.Size(48, 20);
            this.PathLengthNumericUpDown.TabIndex = 1;
            this.PathLengthNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PathLengthNumericUpDown.ValueChanged += new System.EventHandler(this.PathLengthNumericUpDown_ValueChanged);
            // 
            // Button
            // 
            this.Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button.Location = new System.Drawing.Point(461, 0);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(75, 23);
            this.Button.TabIndex = 2;
            this.Button.Text = "Get matrix";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // AdjacencyMatrixGridControl
            // 
            this.AdjacencyMatrixGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdjacencyMatrixGridControl.Location = new System.Drawing.Point(0, 29);
            this.AdjacencyMatrixGridControl.Name = "AdjacencyMatrixGridControl";
            this.AdjacencyMatrixGridControl.Size = new System.Drawing.Size(536, 376);
            this.AdjacencyMatrixGridControl.TabIndex = 3;
            // 
            // PathMatrixControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AdjacencyMatrixGridControl);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.PathLengthNumericUpDown);
            this.Controls.Add(this.PathLengthLabel);
            this.Name = "PathMatrixControl";
            this.Size = new System.Drawing.Size(536, 405);
            ((System.ComponentModel.ISupportInitialize)(this.PathLengthNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PathLengthLabel;
        private System.Windows.Forms.NumericUpDown PathLengthNumericUpDown;
        private System.Windows.Forms.Button Button;
        private MatrixControls.AdjacencyMatrixGridControl AdjacencyMatrixGridControl;
    }
}
