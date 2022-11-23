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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.AdjacencyMatrixTabPage = new System.Windows.Forms.TabPage();
            this.PathMatrixPage = new System.Windows.Forms.TabPage();
            this.AdjacencyMatrixTab = new GraphsApp.Views.Tabs.AdjacencyMatrixTab();
            this.PathMatrixTab = new GraphsApp.Views.Tabs.PathMatrixTab();
            this.TabControl.SuspendLayout();
            this.AdjacencyMatrixTabPage.SuspendLayout();
            this.PathMatrixPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.AdjacencyMatrixTabPage);
            this.TabControl.Controls.Add(this.PathMatrixPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(800, 450);
            this.TabControl.TabIndex = 0;
            // 
            // AdjacencyMatrixTabPage
            // 
            this.AdjacencyMatrixTabPage.Controls.Add(this.AdjacencyMatrixTab);
            this.AdjacencyMatrixTabPage.Location = new System.Drawing.Point(4, 22);
            this.AdjacencyMatrixTabPage.Name = "AdjacencyMatrixTabPage";
            this.AdjacencyMatrixTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AdjacencyMatrixTabPage.Size = new System.Drawing.Size(792, 424);
            this.AdjacencyMatrixTabPage.TabIndex = 0;
            this.AdjacencyMatrixTabPage.Text = "AdjacencyMatrix";
            this.AdjacencyMatrixTabPage.UseVisualStyleBackColor = true;
            // 
            // PathMatrixPage
            // 
            this.PathMatrixPage.Controls.Add(this.PathMatrixTab);
            this.PathMatrixPage.Location = new System.Drawing.Point(4, 22);
            this.PathMatrixPage.Name = "PathMatrixPage";
            this.PathMatrixPage.Padding = new System.Windows.Forms.Padding(3);
            this.PathMatrixPage.Size = new System.Drawing.Size(792, 424);
            this.PathMatrixPage.TabIndex = 1;
            this.PathMatrixPage.Text = "PathMatrix";
            this.PathMatrixPage.UseVisualStyleBackColor = true;
            // 
            // AdjacencyMatrixTab
            // 
            this.AdjacencyMatrixTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdjacencyMatrixTab.Location = new System.Drawing.Point(3, 3);
            this.AdjacencyMatrixTab.Name = "AdjacencyMatrixTab";
            this.AdjacencyMatrixTab.Size = new System.Drawing.Size(786, 418);
            this.AdjacencyMatrixTab.TabIndex = 0;
            this.AdjacencyMatrixTab.MatrixChanged += new System.EventHandler(this.AdjacencyMatrixTab_MatrixChanged);
            // 
            // PathMatrixTab
            // 
            this.PathMatrixTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PathMatrixTab.Location = new System.Drawing.Point(3, 3);
            this.PathMatrixTab.Name = "PathMatrixTab";
            this.PathMatrixTab.Size = new System.Drawing.Size(786, 418);
            this.PathMatrixTab.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabControl);
            this.Name = "MainForm";
            this.Text = "GraphsApp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TabControl.ResumeLayout(false);
            this.AdjacencyMatrixTabPage.ResumeLayout(false);
            this.PathMatrixPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage AdjacencyMatrixTabPage;
        private System.Windows.Forms.TabPage PathMatrixPage;
        private Tabs.AdjacencyMatrixTab AdjacencyMatrixTab;
        private Tabs.PathMatrixTab PathMatrixTab;
    }
}