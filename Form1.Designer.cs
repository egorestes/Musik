namespace Musik
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ChromiumContainerPanel = new System.Windows.Forms.Panel();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.VkButton = new System.Windows.Forms.PictureBox();
            this.YandexButton = new System.Windows.Forms.PictureBox();
            this.RefreshButton = new System.Windows.Forms.PictureBox();
            this.ForwardButton = new System.Windows.Forms.PictureBox();
            this.BackButton = new System.Windows.Forms.PictureBox();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VkButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YandexButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForwardButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).BeginInit();
            this.SuspendLayout();
            // 
            // ChromiumContainerPanel
            // 
            this.ChromiumContainerPanel.Location = new System.Drawing.Point(0, 29);
            this.ChromiumContainerPanel.Name = "ChromiumContainerPanel";
            this.ChromiumContainerPanel.Size = new System.Drawing.Size(1167, 775);
            this.ChromiumContainerPanel.TabIndex = 0;
            // 
            // ControlPanel
            // 
            this.ControlPanel.Controls.Add(this.VkButton);
            this.ControlPanel.Controls.Add(this.YandexButton);
            this.ControlPanel.Controls.Add(this.RefreshButton);
            this.ControlPanel.Controls.Add(this.ForwardButton);
            this.ControlPanel.Controls.Add(this.BackButton);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(1167, 33);
            this.ControlPanel.TabIndex = 0;
            // 
            // VkButton
            // 
            this.VkButton.Image = ((System.Drawing.Image)(resources.GetObject("VkButton.Image")));
            this.VkButton.Location = new System.Drawing.Point(1118, 4);
            this.VkButton.Name = "VkButton";
            this.VkButton.Size = new System.Drawing.Size(37, 27);
            this.VkButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.VkButton.TabIndex = 9;
            this.VkButton.TabStop = false;
            this.VkButton.Click += new System.EventHandler(this.VkButton_Click);
            // 
            // YandexButton
            // 
            this.YandexButton.Image = ((System.Drawing.Image)(resources.GetObject("YandexButton.Image")));
            this.YandexButton.Location = new System.Drawing.Point(1117, 4);
            this.YandexButton.Name = "YandexButton";
            this.YandexButton.Size = new System.Drawing.Size(38, 26);
            this.YandexButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.YandexButton.TabIndex = 8;
            this.YandexButton.TabStop = false;
            this.YandexButton.Click += new System.EventHandler(this.YandexButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButton.Image")));
            this.RefreshButton.Location = new System.Drawing.Point(64, 3);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(25, 23);
            this.RefreshButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.RefreshButton.TabIndex = 7;
            this.RefreshButton.TabStop = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            this.RefreshButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RefreshButton_MouseDown);
            this.RefreshButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RefreshButton_MouseUp);
            // 
            // ForwardButton
            // 
            this.ForwardButton.Image = ((System.Drawing.Image)(resources.GetObject("ForwardButton.Image")));
            this.ForwardButton.Location = new System.Drawing.Point(34, 3);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(24, 23);
            this.ForwardButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ForwardButton.TabIndex = 6;
            this.ForwardButton.TabStop = false;
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            this.ForwardButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ForwardButton_MouseDown);
            this.ForwardButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ForwardButton_MouseUp);
            // 
            // BackButton
            // 
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.Location = new System.Drawing.Point(3, 3);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(25, 23);
            this.BackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BackButton.TabIndex = 5;
            this.BackButton.TabStop = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            this.BackButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BackButton_MouseDown);
            this.BackButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BackButton_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 804);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.ChromiumContainerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Яндекс.Музыка";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ControlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VkButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YandexButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForwardButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ChromiumContainerPanel;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.PictureBox ForwardButton;
        private System.Windows.Forms.PictureBox BackButton;
        private System.Windows.Forms.PictureBox RefreshButton;
        private System.Windows.Forms.PictureBox VkButton;
        private System.Windows.Forms.PictureBox YandexButton;
    }
}

