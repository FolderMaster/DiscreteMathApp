namespace GraphsApp.Views.Controls
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
            this.VerticesCountLabel = new System.Windows.Forms.Label();
            this.GenerationButton = new System.Windows.Forms.Button();
            this.VerticesCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.EdgeMultiplicityLabel = new System.Windows.Forms.Label();
            this.EdgeMultiplicityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.LoopsCountLabel = new System.Windows.Forms.Label();
            this.LoopsCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FillButton = new System.Windows.Forms.Button();
            this.AdjacencyMatrixGridControl = new GraphsApp.Views.Controls.AdjacencyMatrixGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.VerticesCountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdgeMultiplicityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoopsCountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // VerticesCountLabel
            // 
            this.VerticesCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.VerticesCountLabel.AutoSize = true;
            this.VerticesCountLabel.Location = new System.Drawing.Point(-3, 330);
            this.VerticesCountLabel.Name = "VerticesCountLabel";
            this.VerticesCountLabel.Size = new System.Drawing.Size(78, 13);
            this.VerticesCountLabel.TabIndex = 6;
            this.VerticesCountLabel.Text = "Vertices count:";
            // 
            // GenerationButton
            // 
            this.GenerationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GenerationButton.Location = new System.Drawing.Point(166, 377);
            this.GenerationButton.Name = "GenerationButton";
            this.GenerationButton.Size = new System.Drawing.Size(75, 23);
            this.GenerationButton.TabIndex = 5;
            this.GenerationButton.Text = "Generate";
            this.GenerationButton.UseVisualStyleBackColor = true;
            this.GenerationButton.Click += new System.EventHandler(this.GenerationButton_Click);
            // 
            // VerticesCountNumericUpDown
            // 
            this.VerticesCountNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.VerticesCountNumericUpDown.Location = new System.Drawing.Point(81, 328);
            this.VerticesCountNumericUpDown.Name = "VerticesCountNumericUpDown";
            this.VerticesCountNumericUpDown.Size = new System.Drawing.Size(67, 20);
            this.VerticesCountNumericUpDown.TabIndex = 8;
            this.VerticesCountNumericUpDown.ValueChanged += new System.EventHandler(this.VerticesCountNumericUpDown_ValueChanged);
            // 
            // EdgeMultiplicityLabel
            // 
            this.EdgeMultiplicityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EdgeMultiplicityLabel.AutoSize = true;
            this.EdgeMultiplicityLabel.Location = new System.Drawing.Point(-3, 356);
            this.EdgeMultiplicityLabel.Name = "EdgeMultiplicityLabel";
            this.EdgeMultiplicityLabel.Size = new System.Drawing.Size(85, 13);
            this.EdgeMultiplicityLabel.TabIndex = 9;
            this.EdgeMultiplicityLabel.Text = "Edge multiplicity:";
            // 
            // EdgeMultiplicityNumericUpDown
            // 
            this.EdgeMultiplicityNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EdgeMultiplicityNumericUpDown.Location = new System.Drawing.Point(88, 354);
            this.EdgeMultiplicityNumericUpDown.Name = "EdgeMultiplicityNumericUpDown";
            this.EdgeMultiplicityNumericUpDown.Size = new System.Drawing.Size(67, 20);
            this.EdgeMultiplicityNumericUpDown.TabIndex = 10;
            this.EdgeMultiplicityNumericUpDown.ValueChanged += new System.EventHandler(this.EdgeMultiplicityNumericUpDown_ValueChanged);
            // 
            // LoopsCountLabel
            // 
            this.LoopsCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LoopsCountLabel.AutoSize = true;
            this.LoopsCountLabel.Location = new System.Drawing.Point(-3, 382);
            this.LoopsCountLabel.Name = "LoopsCountLabel";
            this.LoopsCountLabel.Size = new System.Drawing.Size(69, 13);
            this.LoopsCountLabel.TabIndex = 11;
            this.LoopsCountLabel.Text = "Loops count:";
            // 
            // LoopsCountNumericUpDown
            // 
            this.LoopsCountNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LoopsCountNumericUpDown.Location = new System.Drawing.Point(72, 380);
            this.LoopsCountNumericUpDown.Name = "LoopsCountNumericUpDown";
            this.LoopsCountNumericUpDown.Size = new System.Drawing.Size(67, 20);
            this.LoopsCountNumericUpDown.TabIndex = 12;
            this.LoopsCountNumericUpDown.ValueChanged += new System.EventHandler(this.LoopsCountNumericUpDown_ValueChanged);
            // 
            // FillButton
            // 
            this.FillButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FillButton.Location = new System.Drawing.Point(166, 325);
            this.FillButton.Name = "FillButton";
            this.FillButton.Size = new System.Drawing.Size(75, 23);
            this.FillButton.TabIndex = 13;
            this.FillButton.Text = "Fill";
            this.FillButton.UseVisualStyleBackColor = true;
            this.FillButton.Click += new System.EventHandler(this.FillButton_Click);
            // 
            // AdjacencyMatrixGridControl
            // 
            this.AdjacencyMatrixGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdjacencyMatrixGridControl.Location = new System.Drawing.Point(0, 0);
            this.AdjacencyMatrixGridControl.Name = "AdjacencyMatrixGridControl";
            this.AdjacencyMatrixGridControl.Size = new System.Drawing.Size(542, 319);
            this.AdjacencyMatrixGridControl.TabIndex = 14;
            this.AdjacencyMatrixGridControl.MatrixChanged += new System.EventHandler(this.AdjacencyMatrixGridControl_MatrixChanged);
            // 
            // AdjacencyMatrixControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AdjacencyMatrixGridControl);
            this.Controls.Add(this.FillButton);
            this.Controls.Add(this.LoopsCountNumericUpDown);
            this.Controls.Add(this.LoopsCountLabel);
            this.Controls.Add(this.EdgeMultiplicityNumericUpDown);
            this.Controls.Add(this.EdgeMultiplicityLabel);
            this.Controls.Add(this.VerticesCountNumericUpDown);
            this.Controls.Add(this.VerticesCountLabel);
            this.Controls.Add(this.GenerationButton);
            this.Name = "AdjacencyMatrixControl";
            this.Size = new System.Drawing.Size(542, 400);
            ((System.ComponentModel.ISupportInitialize)(this.VerticesCountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdgeMultiplicityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoopsCountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label VerticesCountLabel;
        private System.Windows.Forms.Button GenerationButton;
        private System.Windows.Forms.NumericUpDown VerticesCountNumericUpDown;
        private System.Windows.Forms.Label EdgeMultiplicityLabel;
        private System.Windows.Forms.NumericUpDown EdgeMultiplicityNumericUpDown;
        private System.Windows.Forms.Label LoopsCountLabel;
        private System.Windows.Forms.NumericUpDown LoopsCountNumericUpDown;
        private System.Windows.Forms.Button FillButton;
        private AdjacencyMatrixGridControl AdjacencyMatrixGridControl;
    }
}
