namespace GraphsApp.Views.Controls.MatrixControls
{
    partial class MatrixControl
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
            this.FillButton = new System.Windows.Forms.Button();
            this.LoopsCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.LoopsCountLabel = new System.Windows.Forms.Label();
            this.EdgeMultiplicityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.EdgeMultiplicityLabel = new System.Windows.Forms.Label();
            this.VerticesCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.VerticesCountLabel = new System.Windows.Forms.Label();
            this.GenerationButton = new System.Windows.Forms.Button();
            this.EdgesCountLabel = new System.Windows.Forms.Label();
            this.EdgesCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.LoopsCountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdgeMultiplicityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VerticesCountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdgesCountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // FillButton
            // 
            this.FillButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FillButton.Location = new System.Drawing.Point(168, 425);
            this.FillButton.Name = "FillButton";
            this.FillButton.Size = new System.Drawing.Size(75, 23);
            this.FillButton.TabIndex = 21;
            this.FillButton.Text = "Fill";
            this.FillButton.UseVisualStyleBackColor = true;
            this.FillButton.Click += new System.EventHandler(this.FillButton_Click);
            // 
            // LoopsCountNumericUpDown
            // 
            this.LoopsCountNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LoopsCountNumericUpDown.Location = new System.Drawing.Point(72, 480);
            this.LoopsCountNumericUpDown.Name = "LoopsCountNumericUpDown";
            this.LoopsCountNumericUpDown.Size = new System.Drawing.Size(67, 20);
            this.LoopsCountNumericUpDown.TabIndex = 20;
            this.LoopsCountNumericUpDown.ValueChanged += new System.EventHandler(this.LoopsCountNumericUpDown_ValueChanged);
            // 
            // LoopsCountLabel
            // 
            this.LoopsCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LoopsCountLabel.AutoSize = true;
            this.LoopsCountLabel.Location = new System.Drawing.Point(-3, 482);
            this.LoopsCountLabel.Name = "LoopsCountLabel";
            this.LoopsCountLabel.Size = new System.Drawing.Size(69, 13);
            this.LoopsCountLabel.TabIndex = 19;
            this.LoopsCountLabel.Text = "Loops count:";
            // 
            // EdgeMultiplicityNumericUpDown
            // 
            this.EdgeMultiplicityNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EdgeMultiplicityNumericUpDown.Location = new System.Drawing.Point(88, 454);
            this.EdgeMultiplicityNumericUpDown.Name = "EdgeMultiplicityNumericUpDown";
            this.EdgeMultiplicityNumericUpDown.Size = new System.Drawing.Size(67, 20);
            this.EdgeMultiplicityNumericUpDown.TabIndex = 18;
            this.EdgeMultiplicityNumericUpDown.ValueChanged += new System.EventHandler(this.EdgeMultiplicityNumericUpDown_ValueChanged);
            // 
            // EdgeMultiplicityLabel
            // 
            this.EdgeMultiplicityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EdgeMultiplicityLabel.AutoSize = true;
            this.EdgeMultiplicityLabel.Location = new System.Drawing.Point(-3, 456);
            this.EdgeMultiplicityLabel.Name = "EdgeMultiplicityLabel";
            this.EdgeMultiplicityLabel.Size = new System.Drawing.Size(85, 13);
            this.EdgeMultiplicityLabel.TabIndex = 17;
            this.EdgeMultiplicityLabel.Text = "Edge multiplicity:";
            // 
            // VerticesCountNumericUpDown
            // 
            this.VerticesCountNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.VerticesCountNumericUpDown.Location = new System.Drawing.Point(81, 428);
            this.VerticesCountNumericUpDown.Name = "VerticesCountNumericUpDown";
            this.VerticesCountNumericUpDown.Size = new System.Drawing.Size(67, 20);
            this.VerticesCountNumericUpDown.TabIndex = 16;
            this.VerticesCountNumericUpDown.ValueChanged += new System.EventHandler(this.VerticesCountNumericUpDown_ValueChanged);
            // 
            // VerticesCountLabel
            // 
            this.VerticesCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.VerticesCountLabel.AutoSize = true;
            this.VerticesCountLabel.Location = new System.Drawing.Point(-3, 430);
            this.VerticesCountLabel.Name = "VerticesCountLabel";
            this.VerticesCountLabel.Size = new System.Drawing.Size(78, 13);
            this.VerticesCountLabel.TabIndex = 15;
            this.VerticesCountLabel.Text = "Vertices count:";
            // 
            // GenerationButton
            // 
            this.GenerationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GenerationButton.Location = new System.Drawing.Point(168, 477);
            this.GenerationButton.Name = "GenerationButton";
            this.GenerationButton.Size = new System.Drawing.Size(75, 23);
            this.GenerationButton.TabIndex = 14;
            this.GenerationButton.Text = "Generate";
            this.GenerationButton.UseVisualStyleBackColor = true;
            this.GenerationButton.Click += new System.EventHandler(this.GenerationButton_Click);
            // 
            // EdgesCountLabel
            // 
            this.EdgesCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EdgesCountLabel.AutoSize = true;
            this.EdgesCountLabel.Location = new System.Drawing.Point(-3, 404);
            this.EdgesCountLabel.Name = "EdgesCountLabel";
            this.EdgesCountLabel.Size = new System.Drawing.Size(70, 13);
            this.EdgesCountLabel.TabIndex = 22;
            this.EdgesCountLabel.Text = "Edges count:";
            // 
            // EdgesCountNumericUpDown
            // 
            this.EdgesCountNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EdgesCountNumericUpDown.Location = new System.Drawing.Point(73, 402);
            this.EdgesCountNumericUpDown.Name = "EdgesCountNumericUpDown";
            this.EdgesCountNumericUpDown.Size = new System.Drawing.Size(67, 20);
            this.EdgesCountNumericUpDown.TabIndex = 23;
            this.EdgesCountNumericUpDown.ValueChanged += new System.EventHandler(this.EdgesCountNumericUpDown_ValueChanged);
            // 
            // MatrixControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.EdgesCountNumericUpDown);
            this.Controls.Add(this.EdgesCountLabel);
            this.Controls.Add(this.FillButton);
            this.Controls.Add(this.LoopsCountNumericUpDown);
            this.Controls.Add(this.LoopsCountLabel);
            this.Controls.Add(this.EdgeMultiplicityNumericUpDown);
            this.Controls.Add(this.EdgeMultiplicityLabel);
            this.Controls.Add(this.VerticesCountNumericUpDown);
            this.Controls.Add(this.VerticesCountLabel);
            this.Controls.Add(this.GenerationButton);
            this.Name = "MatrixControl";
            this.Size = new System.Drawing.Size(500, 500);
            ((System.ComponentModel.ISupportInitialize)(this.LoopsCountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdgeMultiplicityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VerticesCountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdgesCountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FillButton;
        private System.Windows.Forms.NumericUpDown LoopsCountNumericUpDown;
        private System.Windows.Forms.Label LoopsCountLabel;
        private System.Windows.Forms.NumericUpDown EdgeMultiplicityNumericUpDown;
        private System.Windows.Forms.Label EdgeMultiplicityLabel;
        private System.Windows.Forms.NumericUpDown VerticesCountNumericUpDown;
        private System.Windows.Forms.Label VerticesCountLabel;
        private System.Windows.Forms.Button GenerationButton;
        private System.Windows.Forms.Label EdgesCountLabel;
        private System.Windows.Forms.NumericUpDown EdgesCountNumericUpDown;
    }
}
