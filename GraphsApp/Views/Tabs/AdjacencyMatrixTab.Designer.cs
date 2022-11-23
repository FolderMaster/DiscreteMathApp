namespace GraphsApp.Views.Tabs
{
    partial class AdjacencyMatrixTab
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
            GraphsApp.Services.App.Settings settings3 = new GraphsApp.Services.App.Settings();
            this.AdjacencyMatrixGroupBox = new System.Windows.Forms.GroupBox();
            this.AgainButton = new System.Windows.Forms.Button();
            this.AdjacencyMatrixControl = new GraphsApp.Views.Controls.AdjacencyMatrixControl();
            this.DisplayGroupBox = new System.Windows.Forms.GroupBox();
            this.Schedule2DControl = new GraphsApp.Views.Controls.Schedule2DControl();
            this.AdjacencyMatrixGroupBox.SuspendLayout();
            this.DisplayGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdjacencyMatrixGroupBox
            // 
            this.AdjacencyMatrixGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AdjacencyMatrixGroupBox.Controls.Add(this.AdjacencyMatrixControl);
            this.AdjacencyMatrixGroupBox.Location = new System.Drawing.Point(0, 0);
            this.AdjacencyMatrixGroupBox.Name = "AdjacencyMatrixGroupBox";
            this.AdjacencyMatrixGroupBox.Size = new System.Drawing.Size(372, 451);
            this.AdjacencyMatrixGroupBox.TabIndex = 0;
            this.AdjacencyMatrixGroupBox.TabStop = false;
            this.AdjacencyMatrixGroupBox.Text = "AdjacencyMatrix";
            // 
            // AgainButton
            // 
            this.AgainButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AgainButton.Location = new System.Drawing.Point(737, 428);
            this.AgainButton.Name = "AgainButton";
            this.AgainButton.Size = new System.Drawing.Size(75, 23);
            this.AgainButton.TabIndex = 3;
            this.AgainButton.Text = "Again";
            this.AgainButton.UseVisualStyleBackColor = true;
            this.AgainButton.Click += new System.EventHandler(this.AgainButton_Click);
            // 
            // AdjacencyMatrixControl
            // 
            this.AdjacencyMatrixControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdjacencyMatrixControl.Location = new System.Drawing.Point(3, 16);
            this.AdjacencyMatrixControl.Name = "AdjacencyMatrixControl";
            this.AdjacencyMatrixControl.Size = new System.Drawing.Size(366, 432);
            this.AdjacencyMatrixControl.TabIndex = 0;
            this.AdjacencyMatrixControl.MatrixChanged += new System.EventHandler(this.AdjacencyMatrixControl_MatrixChanged);
            // 
            // DisplayGroupBox
            // 
            this.DisplayGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DisplayGroupBox.Controls.Add(this.Schedule2DControl);
            this.DisplayGroupBox.Location = new System.Drawing.Point(378, 0);
            this.DisplayGroupBox.Name = "DisplayGroupBox";
            this.DisplayGroupBox.Size = new System.Drawing.Size(434, 422);
            this.DisplayGroupBox.TabIndex = 1;
            this.DisplayGroupBox.TabStop = false;
            this.DisplayGroupBox.Text = "Display";
            // 
            // Schedule2DControl
            // 
            this.Schedule2DControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Schedule2DControl.Location = new System.Drawing.Point(3, 16);
            this.Schedule2DControl.Name = "Schedule2DControl";
            settings3.CorrectColor = System.Drawing.Color.White;
            settings3.ErrorColor = System.Drawing.Color.LightPink;
            settings3.LineXSize = 20;
            settings3.LineYSize = 20;
            settings3.PointSize = 10;
            settings3.SavePath = "Save.txt";
            settings3.ValueFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Schedule2DControl.Settings = settings3;
            this.Schedule2DControl.Size = new System.Drawing.Size(428, 403);
            this.Schedule2DControl.TabIndex = 0;
            // 
            // AdjacencyMatrixTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AgainButton);
            this.Controls.Add(this.DisplayGroupBox);
            this.Controls.Add(this.AdjacencyMatrixGroupBox);
            this.Name = "AdjacencyMatrixTab";
            this.Size = new System.Drawing.Size(812, 451);
            this.AdjacencyMatrixGroupBox.ResumeLayout(false);
            this.DisplayGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AdjacencyMatrixGroupBox;
        private System.Windows.Forms.GroupBox DisplayGroupBox;
        private Controls.AdjacencyMatrixControl AdjacencyMatrixControl;
        private System.Windows.Forms.Button AgainButton;
        private Controls.Schedule2DControl Schedule2DControl;
    }
}
