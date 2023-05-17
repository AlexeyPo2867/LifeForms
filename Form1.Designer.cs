namespace LifeForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip = new MenuStrip();
            нарисоватьToolStripMenuItem = new ToolStripMenuItem();
            стартToolStripMenuItem = new ToolStripMenuItem();
            стопToolStripMenuItem = new ToolStripMenuItem();
            настройкиToolStripMenuItem = new ToolStripMenuItem();
            фигураToolStripMenuItem = new ToolStripMenuItem();
            квадратToolStripMenuItem = new ToolStripMenuItem();
            шарикToolStripMenuItem = new ToolStripMenuItem();
            скоростьToolStripMenuItem = new ToolStripMenuItem();
            увеличитьToolStripMenuItem = new ToolStripMenuItem();
            меньшеToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            timer = new System.Windows.Forms.Timer(components);
            picture = new PictureBox();
            statusStrip = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            размерToolStripMenuItem = new ToolStripMenuItem();
            большеToolStripMenuItem = new ToolStripMenuItem();
            меньшеToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(24, 24);
            menuStrip.Items.AddRange(new ToolStripItem[] { нарисоватьToolStripMenuItem, стартToolStripMenuItem, стопToolStripMenuItem, настройкиToolStripMenuItem, выходToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 33);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // нарисоватьToolStripMenuItem
            // 
            нарисоватьToolStripMenuItem.Name = "нарисоватьToolStripMenuItem";
            нарисоватьToolStripMenuItem.Size = new Size(125, 29);
            нарисоватьToolStripMenuItem.Text = "Нарисовать";
            нарисоватьToolStripMenuItem.Click += нарисоватьToolStripMenuItem_Click;
            // 
            // стартToolStripMenuItem
            // 
            стартToolStripMenuItem.Name = "стартToolStripMenuItem";
            стартToolStripMenuItem.Size = new Size(73, 29);
            стартToolStripMenuItem.Text = "Старт";
            стартToolStripMenuItem.Click += стартToolStripMenuItem_Click;
            // 
            // стопToolStripMenuItem
            // 
            стопToolStripMenuItem.Name = "стопToolStripMenuItem";
            стопToolStripMenuItem.Size = new Size(67, 29);
            стопToolStripMenuItem.Text = "Стоп";
            стопToolStripMenuItem.Click += стопToolStripMenuItem_Click;
            // 
            // настройкиToolStripMenuItem
            // 
            настройкиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { фигураToolStripMenuItem, скоростьToolStripMenuItem, размерToolStripMenuItem });
            настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            настройкиToolStripMenuItem.Size = new Size(116, 29);
            настройкиToolStripMenuItem.Text = "Настройки";
            настройкиToolStripMenuItem.Click += настройкиToolStripMenuItem_Click;
            // 
            // фигураToolStripMenuItem
            // 
            фигураToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { квадратToolStripMenuItem, шарикToolStripMenuItem });
            фигураToolStripMenuItem.Name = "фигураToolStripMenuItem";
            фигураToolStripMenuItem.Size = new Size(270, 34);
            фигураToolStripMenuItem.Text = "Фигура";
            // 
            // квадратToolStripMenuItem
            // 
            квадратToolStripMenuItem.Name = "квадратToolStripMenuItem";
            квадратToolStripMenuItem.Size = new Size(180, 34);
            квадратToolStripMenuItem.Text = "Квадрат";
            квадратToolStripMenuItem.Click += квадратToolStripMenuItem_Click;
            // 
            // шарикToolStripMenuItem
            // 
            шарикToolStripMenuItem.Name = "шарикToolStripMenuItem";
            шарикToolStripMenuItem.Size = new Size(180, 34);
            шарикToolStripMenuItem.Text = "Шарик";
            шарикToolStripMenuItem.Click += шарикToolStripMenuItem_Click;
            // 
            // скоростьToolStripMenuItem
            // 
            скоростьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { увеличитьToolStripMenuItem, меньшеToolStripMenuItem });
            скоростьToolStripMenuItem.Name = "скоростьToolStripMenuItem";
            скоростьToolStripMenuItem.Size = new Size(270, 34);
            скоростьToolStripMenuItem.Text = "Скорость";
            // 
            // увеличитьToolStripMenuItem
            // 
            увеличитьToolStripMenuItem.Name = "увеличитьToolStripMenuItem";
            увеличитьToolStripMenuItem.Size = new Size(270, 34);
            увеличитьToolStripMenuItem.Text = "Больше";
            увеличитьToolStripMenuItem.Click += увеличитьToolStripMenuItem_Click;
            // 
            // меньшеToolStripMenuItem
            // 
            меньшеToolStripMenuItem.Name = "меньшеToolStripMenuItem";
            меньшеToolStripMenuItem.Size = new Size(270, 34);
            меньшеToolStripMenuItem.Text = "Меньше";
            меньшеToolStripMenuItem.Click += меньшеToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(80, 29);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // picture
            // 
            picture.Location = new Point(12, 36);
            picture.Name = "picture";
            picture.Size = new Size(776, 372);
            picture.TabIndex = 1;
            picture.TabStop = false;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(24, 24);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip.Location = new Point(0, 418);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(800, 32);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(179, 25);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // размерToolStripMenuItem
            // 
            размерToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { большеToolStripMenuItem, меньшеToolStripMenuItem1 });
            размерToolStripMenuItem.Name = "размерToolStripMenuItem";
            размерToolStripMenuItem.Size = new Size(270, 34);
            размерToolStripMenuItem.Text = "Размер";
            // 
            // большеToolStripMenuItem
            // 
            большеToolStripMenuItem.Name = "большеToolStripMenuItem";
            большеToolStripMenuItem.Size = new Size(270, 34);
            большеToolStripMenuItem.Text = "Больше";
            большеToolStripMenuItem.Click += большеToolStripMenuItem_Click;
            // 
            // меньшеToolStripMenuItem1
            // 
            меньшеToolStripMenuItem1.Name = "меньшеToolStripMenuItem1";
            меньшеToolStripMenuItem1.Size = new Size(270, 34);
            меньшеToolStripMenuItem1.Text = "Меньше";
            меньшеToolStripMenuItem1.Click += меньшеToolStripMenuItem1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip);
            Controls.Add(picture);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "Form1";
            Text = "Form1";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picture).EndInit();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem нарисоватьToolStripMenuItem;
        private ToolStripMenuItem стартToolStripMenuItem;
        private ToolStripMenuItem стопToolStripMenuItem;
        private ToolStripMenuItem настройкиToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Timer timer;
        private PictureBox picture;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripMenuItem фигураToolStripMenuItem;
        private ToolStripMenuItem квадратToolStripMenuItem;
        private ToolStripMenuItem шарикToolStripMenuItem;
        private ToolStripMenuItem скоростьToolStripMenuItem;
        private ToolStripMenuItem увеличитьToolStripMenuItem;
        private ToolStripMenuItem меньшеToolStripMenuItem;
        private ToolStripMenuItem размерToolStripMenuItem;
        private ToolStripMenuItem большеToolStripMenuItem;
        private ToolStripMenuItem меньшеToolStripMenuItem1;
    }
}