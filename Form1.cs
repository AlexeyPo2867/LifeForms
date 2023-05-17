using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Drawing.Drawing2D;
using System.Reflection.Metadata;
using static LifeForms.Form1;

namespace LifeForms
{
    public partial class Form1 : Form
    {
        public enum Figure { Circle, Box };
        public Figure Result { set; get; }

        readonly Color ColorRed = Color.DarkOrange;
        readonly Color ColorRed1 = Color.Orange;
        readonly Color ColorViolet = Color.DarkViolet;
        readonly Color ColorViolet1 = Color.Violet;

        Color ColorYellow = Color.Yellow;
        readonly SolidBrush solidBrush_POINT = new(Color.Lime);

        int H, W;
        int RADIUS_XY;
        int RADIUS = 30;
        int CENTER_POINT_X, CENTER_POINT_Y;
        int POINT_X, POINT_Y;

        readonly int dxy = 0;
        int X0, Y0;
        int xwidth, yheight;

        Color[,] matr;
        readonly Random rnd;

        int count = 0;

        bool DrawPoint = true;

        private int x = 100;
        private int y = 100;
        private float angle = 0;
        private float speed = 1;

        public Form1()
        {


            InitializeComponent();

            rnd = new Random();

            Result = Figure.Circle;

            timer.Interval = 100; // 1000 миллисекунд
            timer.Enabled = false; // при запуске формы таймер выключен, true - таймер сразу запускается

            timer.Tick += timer_Tick;

            this.BackColor = Color.Black;
            this.Width = 800;
            this.Height = 600;


            picture.Location = new Point(1, 34);
            picture.Size = new Size(this.Size.Width - 36, this.Size.Height - 50);
            picture.BackColor = Color.Beige;
            picture.Anchor = AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top;
            picture.Paint += new PaintEventHandler(picture_Paint);

            this.Resize += new EventHandler(Form1_Resize);
            this.Paint += new PaintEventHandler(Paint_Form);

            Init();
            init_matr();

            Text = "Игра Жизнь";

        }

        void Init()
        {
            X0 = 1;// picture.Location.X + 1;
            Y0 = 1;// picture.Location.Y + 1;// SystemInformation.CaptionHeight + 1;

            yheight = picture.Height - this.toolStripStatusLabel1.Height - this.statusStrip.Height -
                                      SystemInformation.VerticalResizeBorderThickness - 5;
            xwidth = picture.Width;// - 2 * SystemInformation.HorizontalResizeBorderThickness - 5;


            RADIUS_XY = RADIUS;

            W = xwidth / (RADIUS_XY + dxy) - 1;
            H = yheight / (RADIUS_XY + dxy) - 2;

            X0 += (xwidth - W * RADIUS_XY + (W - 1) * dxy) / 2;
            Y0 += (yheight - H * RADIUS_XY + (H - 1) * dxy) / 2;

            CENTER_POINT_X = W / 2;
            CENTER_POINT_Y = H / 2;

            POINT_X = X0 + CENTER_POINT_X * (RADIUS_XY - dxy);
            POINT_Y = Y0 + CENTER_POINT_Y * (RADIUS_XY - dxy);

            matr = new Color[H, W];
            //   init_matr();
        }

        Color get_color(int max_colors)
        {
            Color ret = ColorRed;

            int k = rnd.Next(0, max_colors);

            if (k == 0) ret = ColorRed;
            if (k == 1) ret = ColorViolet;
            if (k == 2) ret = ColorYellow;

            return ret;
        }

        void init_matr()
        {
            for (int i = 0; i < H; i++)
                for (int j = 0; j < W; j++)
                {

                    int val = rnd.Next(2);
                    if (val == 0)
                        matr[i, j] = ColorRed;
                    else
                        matr[i, j] = ColorViolet;
                }
        }

        void init_matr(int xW, int yH, int npoint)
        {
            matr = new Color[yH, xW];

            if (count > yH * xW) count = yH * xW;

            for (int i = 0; i < yH; i++)
                for (int j = 0; j < xW; j++) matr[i, j] = ColorViolet;

            for (int i = 0; i < npoint; i++)
            {
                int x = rnd.Next(0, yH - 0);
                int y = rnd.Next(0, xW - 0);

                matr[x, y] = ColorRed;
            }

        }

        void life(Graphics g)
        {
            count = 0;

            if (matr[0, 1] == ColorRed) count++;
            if (matr[1, 1] == ColorRed) count++;
            if (matr[1, 0] == ColorRed) count++;
            if (count == 3) matr[0, 0] = ColorRed;
            if ((count > 3) || (count < 2)) matr[0, 0] = ColorViolet;

            count = 0;

            int col = W - 1;
            int row = H - 1;

            if (matr[row, col - 1] == ColorRed) count++;
            if (matr[row - 1, col - 1] == ColorRed) count++;
            if (matr[row - 1, col] == ColorRed) count++;
            if (count == 3) matr[row, col] = ColorRed;
            if ((count > 3) || (count < 2)) matr[row, col] = ColorViolet;

            count = 0;

            if (matr[row - 1, 0] == ColorRed) count++;
            if (matr[row - 1, 1] == ColorRed) count++;
            if (matr[row, 1] == ColorRed) count++;
            if (count == 3) matr[row, col] = ColorRed;
            if ((count > 3) || (count < 2)) matr[row, 0] = ColorViolet;

            count = 0;

            if (matr[0, col - 1] == ColorRed) count++;
            if (matr[1, col - 1] == ColorRed) count++;
            if (matr[1, col] == ColorRed) count++;
            if (count == 3) matr[row, col] = ColorRed;
            if ((count > 3) || (count < 2)) matr[0, col] = ColorViolet;

            for (int i = 1; i < W - 1; i++)
            {
                count = 0;
                if (matr[0, i - 1] == ColorRed) count++;
                if (matr[0, i + 1] == ColorRed) count++;
                if (matr[1, i - 1] == ColorRed) count++;
                if (matr[1, i + 1] == ColorRed) count++;
                if (matr[1, i] == ColorRed) count++;
                if (count == 3) matr[0, i] = ColorRed;
                if ((count > 3) || (count < 2)) matr[0, i] = ColorViolet;

                count = 0;
                if (matr[row, i - 1] == ColorRed) count++;
                if (matr[row, i + 1] == ColorRed) count++;
                if (matr[row - 1, i - 1] == ColorRed) count++;
                if (matr[row - 1, i + 1] == ColorRed) count++;
                if (matr[row - 1, i] == ColorRed) count++;
                if (count == 3) matr[row, i] = ColorRed;
                if ((count > 3) || (count < 2)) matr[row, i] = ColorViolet;
            }

            for (int i = 1; i < H - 1; i++)
            {
                count = 0;
                if (matr[i - 1, 0] == ColorRed) count++;
                if (matr[i + 1, 0] == ColorRed) count++;
                if (matr[i - 1, 1] == ColorRed) count++;
                if (matr[i + 1, 1] == ColorRed) count++;
                if (matr[i, 1] == ColorRed) count++;
                if (count == 3) matr[i, 0] = ColorRed;
                if ((count > 3) || (count < 2)) matr[i, 0] = ColorViolet;

                count = 0;
                if (matr[i - 1, col] == ColorRed) count++;
                if (matr[i + 1, col] == ColorRed) count++;
                if (matr[i - 1, col - 1] == ColorRed) count++;
                if (matr[i + 1, col - 1] == ColorRed) count++;
                if (matr[i, col - 1] == ColorRed) count++;
                if (count == 3) matr[i, col] = ColorRed;
                if ((count > 3) || (count < 2)) matr[i, col] = ColorViolet;
            }


            for (int x = 1; x < H - 1; x++)
            {
                for (int y = 1; y < W - 1; y++)
                {
                    count = 0;
                    if (matr[x + 1, y] == ColorRed) count++;
                    if (matr[x, y + 1] == ColorRed) count++;
                    if (matr[x - 1, y] == ColorRed) count++;
                    if (matr[x, y - 1] == ColorRed) count++;
                    if (matr[x + 1, y + 1] == ColorRed) count++;
                    if (matr[x - 1, y - 1] == ColorRed) count++;
                    if (matr[x + 1, y - 1] == ColorRed) count++;
                    if (matr[x - 1, y + 1] == ColorRed) count++;

                    if (count == 3) matr[x, y] = ColorRed;
                    if ((count > 3) || (count < 2)) matr[x, y] = ColorViolet;
                }
            }

            draw_matr(g);
        }

        void draw_matr(Graphics gr)
        {
            int x0 = X0;
            int y0 = Y0;

            //  timer.Stop();
            Color Color1;

            for (int i = 0; i < H; i++)
            {
                x0 = X0;
                for (int j = 0; j < W; j++)
                {
                    Rectangle r = new(x0, y0, RADIUS_XY - 1, RADIUS_XY - 1);

                    if (Result == Figure.Box)
                    {
                        //    gr.FillRectangle(new SolidBrush(matr[i, j]), x0, y0, RADIUS_XY - 1, RADIUS_XY - 1);
                        //    if (DrawPoint) gr.FillRectangle(solidBrush_POINT, POINT_X - 1, POINT_Y, RADIUS_XY - 1, RADIUS_XY - 1);

                        if (matr[i, j] == ColorViolet) Color1 = ColorViolet1;
                        else Color1 = ColorRed1;

                        LinearGradientBrush myBrush = new LinearGradientBrush(r, matr[i, j], Color1, LinearGradientMode.BackwardDiagonal);
                        gr.FillRectangle(myBrush, x0, y0, RADIUS_XY - 1, RADIUS_XY - 1);

                        if (DrawPoint) gr.FillRectangle(solidBrush_POINT, POINT_X - 1, POINT_Y, RADIUS_XY - 1, RADIUS_XY - 1);

                    }
                    else
                    {
                        //   gr.FillEllipse(new SolidBrush(matr[i, j]), x0, y0, RADIUS_XY - 1, RADIUS_XY - 1);
                        //  if (DrawPoint) gr.FillEllipse(solidBrush_POINT, POINT_X, POINT_Y, RADIUS_XY - 1, RADIUS_XY - 1);

                        if (matr[i, j] == ColorViolet) Color1 = ColorViolet1;
                        else Color1 = ColorRed1;

                        LinearGradientBrush myBrush = new LinearGradientBrush(r, Color1, matr[i, j], LinearGradientMode.Vertical);
                        gr.FillEllipse(myBrush, x0, y0, RADIUS_XY - 1, RADIUS_XY - 1);

                        if (DrawPoint) gr.FillEllipse(solidBrush_POINT, POINT_X - 1, POINT_Y, RADIUS_XY - 1, RADIUS_XY - 1);
                    }

                    x0 += RADIUS_XY - dxy;
                }
                y0 += RADIUS_XY - dxy;
            }

            // timer.Start();
            /*
                        if (Result == Figure.Box)
                        {
                            gr.FillRectangle( solidBrush_POINT, POINT_X, POINT_Y, RADIUS_XY - 1, RADIUS_XY - 1);
                        }
                        else
                        {
                            gr.FillEllipse(new SolidBrush(matr[CENTER_POINT_Y, CENTER_POINT_X]), POINT_X, POINT_Y, RADIUS_XY - 1, RADIUS_XY - 1);
                        }
            */
        }

        private void DrawShape(Graphics g)
        {
            // Создаем фигуру (квадрат) с заданными координатами и размерами
            Rectangle rect = new Rectangle(x, y, 50, 50);

            // Поворачиваем фигуру на заданный угол
            g.TranslateTransform(rect.X + rect.Width / 2, rect.Y + rect.Height / 2);
            g.RotateTransform(angle);
            g.TranslateTransform(-rect.X - rect.Width / 2, -rect.Y - rect.Height / 2);

            // Отрисовываем фигуру на графическом контексте
            g.FillRectangle(Brushes.Red, rect);
        }

        private void picture_Paint(object? sender, PaintEventArgs e)
        {
            life(e.Graphics);
            //  DrawShape(e.Graphics);
        }

        private void Paint_Form(object? sender, PaintEventArgs e)
        {
            // life(e.Graphics);
        }

        private void timer_Tick(object? sender, EventArgs e)
        {
            //  angle += speed;

            picture.Invalidate();
        }

        private void нарисоватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picture.Invalidate();
        }

        private void стартToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void стопToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            timer.Stop();
            this.Dispose();
            this.Close();
        }

        private void Form1_Resize([AllowNull] object sender, EventArgs e)
        {
            //код, который будет выполнен при изменении размера формы
            timer.Stop();
            Init();
            init_matr();
            timer.Start();
            picture.Invalidate();
        }

        private void квадратToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Result = Figure.Box;
            picture.Invalidate(true);
        }

        private void шарикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Result = Figure.Circle;
            picture.Invalidate();
        }

        private void увеличитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Interval -= 50;
        }

        private void меньшеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Interval += 50;
        }

        private void большеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RADIUS += 1;
            timer.Stop();
            Init();
            init_matr();
            timer.Start();
            picture.Invalidate();

        }

        private void меньшеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RADIUS -= 1;
            timer.Stop();
            Init();
            init_matr();
            timer.Start();
            picture.Invalidate();
        }
    }
}