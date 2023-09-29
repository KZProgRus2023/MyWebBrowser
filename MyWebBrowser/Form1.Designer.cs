namespace MyWebBrowser
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.новаяВкладкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новоеОкноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новоеОкноToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.обычноеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новоеОкноInPrivateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.масштабToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.избранноеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.журналToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.покупкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.приложенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.установитьЭтотСайтКакПриложенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотретьПриложенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.игрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расширенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.основные_параметры_браузераtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьtoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.снимокВебстраницыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиНаСтраницеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перезагрузитьВРежимеInternetExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.другиеИнструментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.приЗапускеБраузераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-5, 68);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(807, 370);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowser1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(799, 344);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(799, 376);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(793, 338);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяВкладкаToolStripMenuItem,
            this.новоеОкноToolStripMenuItem1,
            this.масштабToolStripMenuItem,
            this.избранноеToolStripMenuItem,
            this.журналToolStripMenuItem,
            this.покупкиToolStripMenuItem,
            this.загрузкиToolStripMenuItem,
            this.приложенияToolStripMenuItem,
            this.игрыToolStripMenuItem,
            this.расширенияToolStripMenuItem,
            this.основные_параметры_браузераtoolStripMenuItem,
            this.печатьtoolStripMenuItem1,
            this.снимокВебстраницыToolStripMenuItem,
            this.найтиНаСтраницеToolStripMenuItem,
            this.перезагрузитьВРежимеInternetExplorerToolStripMenuItem,
            this.другиеИнструментыToolStripMenuItem,
            this.параметрыToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 61);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // новаяВкладкаToolStripMenuItem
            // 
            this.новаяВкладкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новоеОкноToolStripMenuItem});
            this.новаяВкладкаToolStripMenuItem.Name = "новаяВкладкаToolStripMenuItem";
            this.новаяВкладкаToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.новаяВкладкаToolStripMenuItem.Text = "Новая вкладка";
            // 
            // новоеОкноToolStripMenuItem
            // 
            this.новоеОкноToolStripMenuItem.Name = "новоеОкноToolStripMenuItem";
            this.новоеОкноToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.новоеОкноToolStripMenuItem.Text = "Новое окно";
            // 
            // новоеОкноToolStripMenuItem1
            // 
            this.новоеОкноToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обычноеToolStripMenuItem,
            this.новоеОкноInPrivateToolStripMenuItem});
            this.новоеОкноToolStripMenuItem1.Name = "новоеОкноToolStripMenuItem1";
            this.новоеОкноToolStripMenuItem1.Size = new System.Drawing.Size(84, 20);
            this.новоеОкноToolStripMenuItem1.Text = "Новое окно";
            // 
            // обычноеToolStripMenuItem
            // 
            this.обычноеToolStripMenuItem.Name = "обычноеToolStripMenuItem";
            this.обычноеToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.обычноеToolStripMenuItem.Text = "Обычное";
            // 
            // новоеОкноInPrivateToolStripMenuItem
            // 
            this.новоеОкноInPrivateToolStripMenuItem.Name = "новоеОкноInPrivateToolStripMenuItem";
            this.новоеОкноInPrivateToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.новоеОкноInPrivateToolStripMenuItem.Text = "Новое окно InPrivate";
            // 
            // масштабToolStripMenuItem
            // 
            this.масштабToolStripMenuItem.Name = "масштабToolStripMenuItem";
            this.масштабToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.масштабToolStripMenuItem.Text = "Масштаб";
            // 
            // избранноеToolStripMenuItem
            // 
            this.избранноеToolStripMenuItem.Name = "избранноеToolStripMenuItem";
            this.избранноеToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.избранноеToolStripMenuItem.Text = "Избранное";
            // 
            // журналToolStripMenuItem
            // 
            this.журналToolStripMenuItem.Name = "журналToolStripMenuItem";
            this.журналToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.журналToolStripMenuItem.Text = "Журнал";
            // 
            // покупкиToolStripMenuItem
            // 
            this.покупкиToolStripMenuItem.Name = "покупкиToolStripMenuItem";
            this.покупкиToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.покупкиToolStripMenuItem.Text = "Покупки";
            // 
            // загрузкиToolStripMenuItem
            // 
            this.загрузкиToolStripMenuItem.Name = "загрузкиToolStripMenuItem";
            this.загрузкиToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.загрузкиToolStripMenuItem.Text = "Загрузки";
            // 
            // приложенияToolStripMenuItem
            // 
            this.приложенияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.установитьЭтотСайтКакПриложенияToolStripMenuItem,
            this.просмотретьПриложенияToolStripMenuItem});
            this.приложенияToolStripMenuItem.Name = "приложенияToolStripMenuItem";
            this.приложенияToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.приложенияToolStripMenuItem.Text = "Приложения";
            // 
            // установитьЭтотСайтКакПриложенияToolStripMenuItem
            // 
            this.установитьЭтотСайтКакПриложенияToolStripMenuItem.Name = "установитьЭтотСайтКакПриложенияToolStripMenuItem";
            this.установитьЭтотСайтКакПриложенияToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.установитьЭтотСайтКакПриложенияToolStripMenuItem.Text = "Установить этот сайт как приложения";
            // 
            // просмотретьПриложенияToolStripMenuItem
            // 
            this.просмотретьПриложенияToolStripMenuItem.Name = "просмотретьПриложенияToolStripMenuItem";
            this.просмотретьПриложенияToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.просмотретьПриложенияToolStripMenuItem.Text = "Просмотреть приложения";
            // 
            // игрыToolStripMenuItem
            // 
            this.игрыToolStripMenuItem.Name = "игрыToolStripMenuItem";
            this.игрыToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.игрыToolStripMenuItem.Text = "Игры";
            // 
            // расширенияToolStripMenuItem
            // 
            this.расширенияToolStripMenuItem.Name = "расширенияToolStripMenuItem";
            this.расширенияToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.расширенияToolStripMenuItem.Text = "Расширения";
            this.расширенияToolStripMenuItem.Click += new System.EventHandler(this.расширенияToolStripMenuItem_Click);
            // 
            // основные_параметры_браузераtoolStripMenuItem
            // 
            this.основные_параметры_браузераtoolStripMenuItem.Name = "основные_параметры_браузераtoolStripMenuItem";
            this.основные_параметры_браузераtoolStripMenuItem.Size = new System.Drawing.Size(194, 20);
            this.основные_параметры_браузераtoolStripMenuItem.Text = "Основные параметры браузера";
            // 
            // печатьtoolStripMenuItem1
            // 
            this.печатьtoolStripMenuItem1.Name = "печатьtoolStripMenuItem1";
            this.печатьtoolStripMenuItem1.Size = new System.Drawing.Size(58, 20);
            this.печатьtoolStripMenuItem1.Text = "Печать";
            // 
            // снимокВебстраницыToolStripMenuItem
            // 
            this.снимокВебстраницыToolStripMenuItem.Name = "снимокВебстраницыToolStripMenuItem";
            this.снимокВебстраницыToolStripMenuItem.Size = new System.Drawing.Size(144, 19);
            this.снимокВебстраницыToolStripMenuItem.Text = "Снимок веб-страницы";
            // 
            // найтиНаСтраницеToolStripMenuItem
            // 
            this.найтиНаСтраницеToolStripMenuItem.Name = "найтиНаСтраницеToolStripMenuItem";
            this.найтиНаСтраницеToolStripMenuItem.Size = new System.Drawing.Size(123, 19);
            this.найтиНаСтраницеToolStripMenuItem.Text = "Найти на странице";
            // 
            // перезагрузитьВРежимеInternetExplorerToolStripMenuItem
            // 
            this.перезагрузитьВРежимеInternetExplorerToolStripMenuItem.Name = "перезагрузитьВРежимеInternetExplorerToolStripMenuItem";
            this.перезагрузитьВРежимеInternetExplorerToolStripMenuItem.Size = new System.Drawing.Size(245, 19);
            this.перезагрузитьВРежимеInternetExplorerToolStripMenuItem.Text = "Перезагрузить в режиме Internet Explorer";
            // 
            // другиеИнструментыToolStripMenuItem
            // 
            this.другиеИнструментыToolStripMenuItem.Name = "другиеИнструментыToolStripMenuItem";
            this.другиеИнструментыToolStripMenuItem.Size = new System.Drawing.Size(135, 19);
            this.другиеИнструментыToolStripMenuItem.Text = "Другие инструменты";
            // 
            // параметрыToolStripMenuItem
            // 
            this.параметрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.приЗапускеБраузераToolStripMenuItem});
            this.параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
            this.параметрыToolStripMenuItem.Size = new System.Drawing.Size(83, 19);
            this.параметрыToolStripMenuItem.Text = "Параметры";
            // 
            // приЗапускеБраузераToolStripMenuItem
            // 
            this.приЗапускеБраузераToolStripMenuItem.Name = "приЗапускеБраузераToolStripMenuItem";
            this.приЗапускеБраузераToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.приЗапускеБраузераToolStripMenuItem.Text = "При запуске браузера";
            this.приЗапускеБраузераToolStripMenuItem.Click += new System.EventHandler(this.приЗапускеБраузераToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem новаяВкладкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новоеОкноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новоеОкноToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem обычноеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новоеОкноInPrivateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem масштабToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem избранноеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem журналToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem покупкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem приложенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem установитьЭтотСайтКакПриложенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотретьПриложенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem игрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расширенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem основные_параметры_браузераtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem печатьtoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem снимокВебстраницыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найтиНаСтраницеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перезагрузитьВРежимеInternetExplorerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem другиеИнструментыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параметрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem приЗапускеБраузераToolStripMenuItem;
    }
}

