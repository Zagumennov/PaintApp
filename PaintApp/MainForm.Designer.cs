namespace PaintApp
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.TabFile = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroButtonLoadFile = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.tabInput = new MetroFramework.Controls.MetroTabPage();
            this.metroButtonLine = new MetroFramework.Controls.MetroButton();
            this.metroButtonRect = new MetroFramework.Controls.MetroButton();
            this.openGLControlView = new SharpGL.OpenGLControl();
            this.TabSettings = new MetroFramework.Controls.MetroTabPage();
            this.tabHelp = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl1.SuspendLayout();
            this.TabFile.SuspendLayout();
            this.tabInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControlView)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.TabFile);
            this.metroTabControl1.Controls.Add(this.tabInput);
            this.metroTabControl1.Controls.Add(this.TabSettings);
            this.metroTabControl1.Controls.Add(this.tabHelp);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(1093, 704);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTabControl1.TabIndex = 10;
            this.metroTabControl1.UseSelectable = true;
            // 
            // TabFile
            // 
            this.TabFile.Controls.Add(this.metroLabel4);
            this.TabFile.Controls.Add(this.metroButtonLoadFile);
            this.TabFile.Controls.Add(this.metroButton1);
            this.TabFile.HorizontalScrollbar = true;
            this.TabFile.HorizontalScrollbarBarColor = true;
            this.TabFile.HorizontalScrollbarHighlightOnWheel = false;
            this.TabFile.HorizontalScrollbarSize = 10;
            this.TabFile.Location = new System.Drawing.Point(4, 38);
            this.TabFile.Name = "TabFile";
            this.TabFile.Padding = new System.Windows.Forms.Padding(25);
            this.TabFile.Size = new System.Drawing.Size(1085, 662);
            this.TabFile.TabIndex = 2;
            this.TabFile.Text = "Файл";
            this.TabFile.VerticalScrollbar = true;
            this.TabFile.VerticalScrollbarBarColor = true;
            this.TabFile.VerticalScrollbarHighlightOnWheel = false;
            this.TabFile.VerticalScrollbarSize = 10;
            this.TabFile.Visible = false;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(28, 25);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(189, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Выберите загружаемый файл";
            // 
            // metroButtonLoadFile
            // 
            this.metroButtonLoadFile.Location = new System.Drawing.Point(540, 74);
            this.metroButtonLoadFile.Name = "metroButtonLoadFile";
            this.metroButtonLoadFile.Size = new System.Drawing.Size(104, 23);
            this.metroButtonLoadFile.TabIndex = 5;
            this.metroButtonLoadFile.Text = "Загрузить файл";
            this.metroButtonLoadFile.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(28, 74);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(104, 23);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Выбрать файл";
            this.metroButton1.UseSelectable = true;
            // 
            // tabInput
            // 
            this.tabInput.Controls.Add(this.metroButtonLine);
            this.tabInput.Controls.Add(this.metroButtonRect);
            this.tabInput.Controls.Add(this.openGLControlView);
            this.tabInput.HorizontalScrollbarBarColor = true;
            this.tabInput.HorizontalScrollbarHighlightOnWheel = false;
            this.tabInput.HorizontalScrollbarSize = 10;
            this.tabInput.Location = new System.Drawing.Point(4, 38);
            this.tabInput.Name = "tabInput";
            this.tabInput.Size = new System.Drawing.Size(1085, 662);
            this.tabInput.TabIndex = 5;
            this.tabInput.Text = "Редактор";
            this.tabInput.VerticalScrollbarBarColor = true;
            this.tabInput.VerticalScrollbarHighlightOnWheel = false;
            this.tabInput.VerticalScrollbarSize = 10;
            // 
            // metroButtonLine
            // 
            this.metroButtonLine.Location = new System.Drawing.Point(157, 21);
            this.metroButtonLine.Name = "metroButtonLine";
            this.metroButtonLine.Size = new System.Drawing.Size(134, 39);
            this.metroButtonLine.TabIndex = 4;
            this.metroButtonLine.Text = "Линия";
            this.metroButtonLine.UseSelectable = true;
            this.metroButtonLine.Click += new System.EventHandler(this.metroButtonLine_Click);
            // 
            // metroButtonRect
            // 
            this.metroButtonRect.Location = new System.Drawing.Point(0, 21);
            this.metroButtonRect.Name = "metroButtonRect";
            this.metroButtonRect.Size = new System.Drawing.Size(134, 39);
            this.metroButtonRect.TabIndex = 3;
            this.metroButtonRect.Text = "Прямоугольник";
            this.metroButtonRect.UseSelectable = true;
            this.metroButtonRect.Click += new System.EventHandler(this.metroButtonRect_Click);
            // 
            // openGLControlView
            // 
            this.openGLControlView.DrawFPS = false;
            this.openGLControlView.Location = new System.Drawing.Point(-1, 77);
            this.openGLControlView.Name = "openGLControlView";
            this.openGLControlView.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControlView.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openGLControlView.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControlView.Size = new System.Drawing.Size(1082, 586);
            this.openGLControlView.TabIndex = 2;
            this.openGLControlView.OpenGLInitialized += new System.EventHandler(this.openGLControlView_OpenGLInitialized);
            this.openGLControlView.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControlView_OpenGLDraw);
            this.openGLControlView.Load += new System.EventHandler(this.openGLControlView_Load);
            this.openGLControlView.Click += new System.EventHandler(this.openGLControlView_Click);
            this.openGLControlView.DoubleClick += new System.EventHandler(this.openGLControlView_DoubleClick);
            this.openGLControlView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.openGLControlView_MouseDown);
            this.openGLControlView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.openGLControlView_MouseMove);
            this.openGLControlView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.openGLControlView_MouseUp);
            this.openGLControlView.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.openGLControlView_MouseWheel);
            // 
            // TabSettings
            // 
            this.TabSettings.HorizontalScrollbarBarColor = true;
            this.TabSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.TabSettings.HorizontalScrollbarSize = 10;
            this.TabSettings.Location = new System.Drawing.Point(4, 38);
            this.TabSettings.Name = "TabSettings";
            this.TabSettings.Padding = new System.Windows.Forms.Padding(25);
            this.TabSettings.Size = new System.Drawing.Size(1085, 662);
            this.TabSettings.TabIndex = 3;
            this.TabSettings.Text = "Настройки";
            this.TabSettings.VerticalScrollbarBarColor = true;
            this.TabSettings.VerticalScrollbarHighlightOnWheel = false;
            this.TabSettings.VerticalScrollbarSize = 10;
            this.TabSettings.Visible = false;
            // 
            // tabHelp
            // 
            this.tabHelp.HorizontalScrollbarBarColor = true;
            this.tabHelp.HorizontalScrollbarHighlightOnWheel = false;
            this.tabHelp.HorizontalScrollbarSize = 10;
            this.tabHelp.Location = new System.Drawing.Point(4, 38);
            this.tabHelp.Name = "tabHelp";
            this.tabHelp.Size = new System.Drawing.Size(1085, 662);
            this.tabHelp.TabIndex = 4;
            this.tabHelp.Text = "Справка";
            this.tabHelp.VerticalScrollbarBarColor = true;
            this.tabHelp.VerticalScrollbarHighlightOnWheel = false;
            this.tabHelp.VerticalScrollbarSize = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 784);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "MainForm";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Графический редактор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.TabFile.ResumeLayout(false);
            this.TabFile.PerformLayout();
            this.tabInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.openGLControlView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage TabFile;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton metroButtonLoadFile;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTabPage tabInput;
        private MetroFramework.Controls.MetroTabPage TabSettings;
        private MetroFramework.Controls.MetroTabPage tabHelp;
        private MetroFramework.Controls.MetroButton metroButtonLine;
        private MetroFramework.Controls.MetroButton metroButtonRect;
        private SharpGL.OpenGLControl openGLControlView;
    }
}

