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
            this.AdjacencyMatrixTab = new GraphsApp.Views.Tabs.AdjacencyMatrixTab();
            this.PathMatrixPage = new System.Windows.Forms.TabPage();
            this.PathMatrixTab = new GraphsApp.Views.Tabs.PathMatrixTab();
            this.TabControl.SuspendLayout();
            this.CreatorMatrixTabPage.SuspendLayout();
            this.PathMatrixPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.CreatorMatrixTabPage);
            this.TabControl.Controls.Add(this.PathMatrixPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(800, 450);
            this.TabControl.TabIndex = 0;
            // 
            // CreatorMatrixTabPage
            // 
            this.CreatorMatrixTabPage.Controls.Add(this.AdjacencyMatrixTab);
            this.CreatorMatrixTabPage.Location = new System.Drawing.Point(4, 22);
            this.CreatorMatrixTabPage.Name = "CreatorMatrixTabPage";
            this.CreatorMatrixTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CreatorMatrixTabPage.Size = new System.Drawing.Size(792, 424);
            this.CreatorMatrixTabPage.TabIndex = 0;
            this.CreatorMatrixTabPage.Text = "Creator matrix";
            this.CreatorMatrixTabPage.UseVisualStyleBackColor = true;
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
            // PathMatrixPage
            // 
            this.PathMatrixPage.Controls.Add(this.PathMatrixTab);
            this.PathMatrixPage.Location = new System.Drawing.Point(4, 22);
            this.PathMatrixPage.Name = "PathMatrixPage";
            this.PathMatrixPage.Padding = new System.Windows.Forms.Padding(3);
            this.PathMatrixPage.Size = new System.Drawing.Size(792, 424);
            this.PathMatrixPage.TabIndex = 1;
            this.PathMatrixPage.Text = "Path matrix";
            this.PathMatrixPage.UseVisualStyleBackColor = true;
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
            this.CreatorMatrixTabPage.ResumeLayout(false);
            this.PathMatrixPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage CreatorMatrixTabPage;
        private System.Windows.Forms.TabPage PathMatrixPage;
        private Tabs.AdjacencyMatrixTab AdjacencyMatrixTab;
        private Tabs.PathMatrixTab PathMatrixTab;
    }
}