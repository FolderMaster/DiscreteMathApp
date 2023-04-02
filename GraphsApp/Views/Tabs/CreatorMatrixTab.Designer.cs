namespace GraphsApp.Views.Tabs
{
    partial class CreatorMatrixTab
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
            GraphsApp.Services.App.Settings settings1 = new GraphsApp.Services.App.Settings();
            this.AgainButton = new System.Windows.Forms.Button();
            this.DisplayGroupBox = new System.Windows.Forms.GroupBox();
            this.Schedule2DControl = new GraphsApp.Views.Controls.Plot2DControl();
            this.AdjacencyMatrixControl = new GraphsApp.Views.Controls.MatrixControls.AdjacencyMatrixControl();
            this.MatrixTabControl = new System.Windows.Forms.TabControl();
            this.AdjacencyMatrixTabPage = new System.Windows.Forms.TabPage();
            this.IncidenceMatrixTabPage = new System.Windows.Forms.TabPage();
            this.IncidenceMatrixControl = new GraphsApp.Views.Controls.MatrixControls.IncidenceMatrixControl();
            this.DisplayGroupBox.SuspendLayout();
            this.MatrixTabControl.SuspendLayout();
            this.AdjacencyMatrixTabPage.SuspendLayout();
            this.IncidenceMatrixTabPage.SuspendLayout();
            this.SuspendLayout();
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
            settings1.PointSize = 10;
            settings1.SavePath = "Save.txt";
            settings1.ValueFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Schedule2DControl.Settings = settings1;
            this.Schedule2DControl.Size = new System.Drawing.Size(428, 403);
            this.Schedule2DControl.TabIndex = 0;
            // 
            // AdjacencyMatrixControl
            // 
            this.AdjacencyMatrixControl.AutoSize = true;
            this.AdjacencyMatrixControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdjacencyMatrixControl.Location = new System.Drawing.Point(3, 3);
            this.AdjacencyMatrixControl.Name = "AdjacencyMatrixControl";
            this.AdjacencyMatrixControl.Size = new System.Drawing.Size(358, 419);
            this.AdjacencyMatrixControl.TabIndex = 0;
            this.AdjacencyMatrixControl.MatrixChanged += new System.EventHandler(this.AdjacencyMatrixControl_MatrixChanged);
            // 
            // MatrixTabControl
            // 
            this.MatrixTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MatrixTabControl.Controls.Add(this.AdjacencyMatrixTabPage);
            this.MatrixTabControl.Controls.Add(this.IncidenceMatrixTabPage);
            this.MatrixTabControl.Location = new System.Drawing.Point(0, 0);
            this.MatrixTabControl.Name = "MatrixTabControl";
            this.MatrixTabControl.SelectedIndex = 0;
            this.MatrixTabControl.Size = new System.Drawing.Size(372, 451);
            this.MatrixTabControl.TabIndex = 4;
            // 
            // AdjacencyMatrixTabPage
            // 
            this.AdjacencyMatrixTabPage.Controls.Add(this.AdjacencyMatrixControl);
            this.AdjacencyMatrixTabPage.Location = new System.Drawing.Point(4, 22);
            this.AdjacencyMatrixTabPage.Name = "AdjacencyMatrixTabPage";
            this.AdjacencyMatrixTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AdjacencyMatrixTabPage.Size = new System.Drawing.Size(364, 425);
            this.AdjacencyMatrixTabPage.TabIndex = 0;
            this.AdjacencyMatrixTabPage.Text = "Adjacency matrix";
            this.AdjacencyMatrixTabPage.UseVisualStyleBackColor = true;
            // 
            // IncidenceMatrixTabPage
            // 
            this.IncidenceMatrixTabPage.Controls.Add(this.IncidenceMatrixControl);
            this.IncidenceMatrixTabPage.Location = new System.Drawing.Point(4, 22);
            this.IncidenceMatrixTabPage.Name = "IncidenceMatrixTabPage";
            this.IncidenceMatrixTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.IncidenceMatrixTabPage.Size = new System.Drawing.Size(364, 425);
            this.IncidenceMatrixTabPage.TabIndex = 1;
            this.IncidenceMatrixTabPage.Text = "Incidence matrix";
            this.IncidenceMatrixTabPage.UseVisualStyleBackColor = true;
            // 
            // IncidenceMatrixControl
            // 
            this.IncidenceMatrixControl.AutoSize = true;
            this.IncidenceMatrixControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IncidenceMatrixControl.Location = new System.Drawing.Point(3, 3);
            this.IncidenceMatrixControl.Name = "IncidenceMatrixControl";
            this.IncidenceMatrixControl.Size = new System.Drawing.Size(358, 419);
            this.IncidenceMatrixControl.TabIndex = 0;
            this.IncidenceMatrixControl.MatrixChanged += new System.EventHandler(this.IncidenceMatrixControl_MatrixChanged);
            // 
            // CreatorMatrixTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MatrixTabControl);
            this.Controls.Add(this.AgainButton);
            this.Controls.Add(this.DisplayGroupBox);
            this.Name = "CreatorMatrixTab";
            this.Size = new System.Drawing.Size(812, 451);
            this.DisplayGroupBox.ResumeLayout(false);
            this.MatrixTabControl.ResumeLayout(false);
            this.AdjacencyMatrixTabPage.ResumeLayout(false);
            this.AdjacencyMatrixTabPage.PerformLayout();
            this.IncidenceMatrixTabPage.ResumeLayout(false);
            this.IncidenceMatrixTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox DisplayGroupBox;
        private Controls.MatrixControls.AdjacencyMatrixControl AdjacencyMatrixControl;
        private System.Windows.Forms.Button AgainButton;
        private Controls.Plot2DControl Schedule2DControl;
        private System.Windows.Forms.TabControl MatrixTabControl;
        private System.Windows.Forms.TabPage AdjacencyMatrixTabPage;
        private System.Windows.Forms.TabPage IncidenceMatrixTabPage;
        private Controls.MatrixControls.IncidenceMatrixControl IncidenceMatrixControl;
    }
}
