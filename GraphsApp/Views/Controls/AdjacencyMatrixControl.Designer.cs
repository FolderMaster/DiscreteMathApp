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
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.VerticesCountLabel = new System.Windows.Forms.Label();
            this.GenerationButton = new System.Windows.Forms.Button();
            this.VerticesCountTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(0, 29);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(559, 371);
            this.DataGridView.TabIndex = 0;
            this.DataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellEndEdit);
            this.DataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DataGridView_CellValidating);
            // 
            // VerticesCountLabel
            // 
            this.VerticesCountLabel.AutoSize = true;
            this.VerticesCountLabel.Location = new System.Drawing.Point(-3, 3);
            this.VerticesCountLabel.Name = "VerticesCountLabel";
            this.VerticesCountLabel.Size = new System.Drawing.Size(78, 13);
            this.VerticesCountLabel.TabIndex = 6;
            this.VerticesCountLabel.Text = "Vertices count:";
            // 
            // GenerationButton
            // 
            this.GenerationButton.Location = new System.Drawing.Point(189, 0);
            this.GenerationButton.Name = "GenerationButton";
            this.GenerationButton.Size = new System.Drawing.Size(75, 23);
            this.GenerationButton.TabIndex = 5;
            this.GenerationButton.Text = "Generate";
            this.GenerationButton.UseVisualStyleBackColor = true;
            this.GenerationButton.Click += new System.EventHandler(this.GenerationButton_Click);
            // 
            // VerticesCountTextBox
            // 
            this.VerticesCountTextBox.Location = new System.Drawing.Point(83, 0);
            this.VerticesCountTextBox.Name = "VerticesCountTextBox";
            this.VerticesCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.VerticesCountTextBox.TabIndex = 4;
            // 
            // AdjacencyMatrixControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.VerticesCountLabel);
            this.Controls.Add(this.GenerationButton);
            this.Controls.Add(this.VerticesCountTextBox);
            this.Controls.Add(this.DataGridView);
            this.Name = "AdjacencyMatrixControl";
            this.Size = new System.Drawing.Size(559, 400);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Label VerticesCountLabel;
        private System.Windows.Forms.Button GenerationButton;
        private System.Windows.Forms.TextBox VerticesCountTextBox;
    }
}
