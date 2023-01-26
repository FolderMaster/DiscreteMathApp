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
            this.CreatorMatrixTabPage = new System.Windows.Forms.TabPage();
            this.CreatorMatrixTab = new GraphsApp.Views.Tabs.CreatorMatrixTab();
            this.PathCountTabPage = new System.Windows.Forms.TabPage();
            this.PathCountTab = new GraphsApp.Views.Tabs.PathCountTab();
            this.ShortestPathTabPage = new System.Windows.Forms.TabPage();
            this.ShortestPathTab = new GraphsApp.Views.Tabs.ShortestPathTab();
            this.ColorGraphTabPage = new System.Windows.Forms.TabPage();
            this.ColorGraphTab = new GraphsApp.Views.Tabs.ColorGraphTab();
            this.TabControl.SuspendLayout();
            this.CreatorMatrixTabPage.SuspendLayout();
            this.PathCountTabPage.SuspendLayout();
            this.ShortestPathTabPage.SuspendLayout();
            this.ColorGraphTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.CreatorMatrixTabPage);
            this.TabControl.Controls.Add(this.PathCountTabPage);
            this.TabControl.Controls.Add(this.ShortestPathTabPage);
            this.TabControl.Controls.Add(this.ColorGraphTabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(800, 450);
            this.TabControl.TabIndex = 0;
            // 
            // CreatorMatrixTabPage
            // 
            this.CreatorMatrixTabPage.Controls.Add(this.CreatorMatrixTab);
            this.CreatorMatrixTabPage.Location = new System.Drawing.Point(4, 22);
            this.CreatorMatrixTabPage.Name = "CreatorMatrixTabPage";
            this.CreatorMatrixTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CreatorMatrixTabPage.Size = new System.Drawing.Size(792, 424);
            this.CreatorMatrixTabPage.TabIndex = 0;
            this.CreatorMatrixTabPage.Text = "Creator matrix";
            this.CreatorMatrixTabPage.UseVisualStyleBackColor = true;
            // 
            // CreatorMatrixTab
            // 
            this.CreatorMatrixTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreatorMatrixTab.Location = new System.Drawing.Point(3, 3);
            this.CreatorMatrixTab.Name = "CreatorMatrixTab";
            this.CreatorMatrixTab.Size = new System.Drawing.Size(786, 418);
            this.CreatorMatrixTab.TabIndex = 0;
            this.CreatorMatrixTab.MatrixChanged += new System.EventHandler(this.AdjacencyMatrixTab_MatrixChanged);
            // 
            // PathCountTabPage
            // 
            this.PathCountTabPage.Controls.Add(this.PathCountTab);
            this.PathCountTabPage.Location = new System.Drawing.Point(4, 22);
            this.PathCountTabPage.Name = "PathCountTabPage";
            this.PathCountTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PathCountTabPage.Size = new System.Drawing.Size(792, 424);
            this.PathCountTabPage.TabIndex = 1;
            this.PathCountTabPage.Text = "Path count";
            this.PathCountTabPage.UseVisualStyleBackColor = true;
            // 
            // PathCountTab
            // 
            this.PathCountTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PathCountTab.Location = new System.Drawing.Point(3, 3);
            this.PathCountTab.Name = "PathCountTab";
            this.PathCountTab.Size = new System.Drawing.Size(786, 418);
            this.PathCountTab.TabIndex = 0;
            // 
            // ShortestPathTabPage
            // 
            this.ShortestPathTabPage.Controls.Add(this.ShortestPathTab);
            this.ShortestPathTabPage.Location = new System.Drawing.Point(4, 22);
            this.ShortestPathTabPage.Name = "ShortestPathTabPage";
            this.ShortestPathTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ShortestPathTabPage.Size = new System.Drawing.Size(792, 424);
            this.ShortestPathTabPage.TabIndex = 2;
            this.ShortestPathTabPage.Text = "Shortest path";
            this.ShortestPathTabPage.UseVisualStyleBackColor = true;
            // 
            // ShortestPathTab
            // 
            this.ShortestPathTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShortestPathTab.Location = new System.Drawing.Point(3, 3);
            this.ShortestPathTab.Name = "ShortestPathTab";
            this.ShortestPathTab.Size = new System.Drawing.Size(786, 418);
            this.ShortestPathTab.TabIndex = 0;
            // 
            // ColorGraphTabPage
            // 
            this.ColorGraphTabPage.Controls.Add(this.ColorGraphTab);
            this.ColorGraphTabPage.Location = new System.Drawing.Point(4, 22);
            this.ColorGraphTabPage.Name = "ColorGraphTabPage";
            this.ColorGraphTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ColorGraphTabPage.Size = new System.Drawing.Size(792, 424);
            this.ColorGraphTabPage.TabIndex = 3;
            this.ColorGraphTabPage.Text = "Color graph";
            this.ColorGraphTabPage.UseVisualStyleBackColor = true;
            // 
            // ColorGraphTab
            // 
            this.ColorGraphTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColorGraphTab.Location = new System.Drawing.Point(3, 3);
            this.ColorGraphTab.Name = "ColorGraphTab";
            this.ColorGraphTab.Size = new System.Drawing.Size(786, 418);
            this.ColorGraphTab.TabIndex = 0;
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
            this.CreatorMatrixTabPage.ResumeLayout(false);
            this.PathCountTabPage.ResumeLayout(false);
            this.ShortestPathTabPage.ResumeLayout(false);
            this.ColorGraphTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage CreatorMatrixTabPage;
        private System.Windows.Forms.TabPage PathCountTabPage;
        private Tabs.CreatorMatrixTab CreatorMatrixTab;
        private Tabs.PathCountTab PathCountTab;
        private System.Windows.Forms.TabPage ShortestPathTabPage;
        private Tabs.ShortestPathTab ShortestPathTab;
        private System.Windows.Forms.TabPage ColorGraphTabPage;
        private Tabs.ColorGraphTab ColorGraphTab;
    }
}