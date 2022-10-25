namespace GraphsApp.Views.Forms
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DisplayButton = new System.Windows.Forms.Button();
            this.schedule2DControl1 = new GraphsApp.Views.Controls.Schedule2DControl();
            this.AdjacencyMatrixControl = new GraphsApp.Views.Controls.AdjacencyMatrixControl();
            this.SuspendLayout();
            // 
            // DisplayButton
            // 
            this.DisplayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DisplayButton.Location = new System.Drawing.Point(12, 415);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(75, 23);
            this.DisplayButton.TabIndex = 2;
            this.DisplayButton.Text = "Display";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // schedule2DControl1
            // 
            this.schedule2DControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.schedule2DControl1.Location = new System.Drawing.Point(395, 12);
            this.schedule2DControl1.Name = "schedule2DControl1";
            this.schedule2DControl1.Size = new System.Drawing.Size(393, 426);
            this.schedule2DControl1.TabIndex = 1;
            // 
            // AdjacencyMatrixControl
            // 
            this.AdjacencyMatrixControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AdjacencyMatrixControl.Location = new System.Drawing.Point(12, 12);
            this.AdjacencyMatrixControl.Name = "AdjacencyMatrixControl";
            this.AdjacencyMatrixControl.Size = new System.Drawing.Size(377, 397);
            this.AdjacencyMatrixControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.schedule2DControl1);
            this.Controls.Add(this.AdjacencyMatrixControl);
            this.Name = "MainForm";
            this.Text = "GraphsApp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.AdjacencyMatrixControl AdjacencyMatrixControl;
        private Controls.Schedule2DControl schedule2DControl1;
        private System.Windows.Forms.Button DisplayButton;
    }
}

