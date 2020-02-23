using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MoonSharp.Interpreter;

namespace CrosswordSolver
{
    public partial class Form1 : Form
    {
        int size = 10; //number of cells in the grid on the x and y axis
        int cellSize = 25;
        int padding = 2;
        int xOff = 70;
        int yOff = 60;
        bool[,] puzzle;
        Bitmap turtle;
        int turtle_x;
        int turtle_y;
        Script main;
        Game game;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Editor";
            this.MouseClick += mouseClick;
            puzzle = new bool[size,size];
            main = LuaInit.Start(this);
            game = LuaInit.game;
            main.Call(main.Globals["main"]);

            console.ScrollBars = ScrollBars.Both;
            console.Enabled = false;
            this.MouseMove += mouseMove;

            //var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
           // materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
           // materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void mouseMove(object sender, MouseEventArgs e)
        {
            this.toolStripStatusLabel1.Text = String.Format("Mouse Position: ({0},{1})", e.X, e.Y);
            this.statusStrip1.Refresh();
            
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            /*
            //Draw grid
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            System.Drawing.SolidBrush inactiveBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();

            //draw outline
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.DrawImage(Bitmap.FromFile("C:/Users/coda1/Desktop/Turtle.png"), turtle_x, turtle_y, 25, 25);

            using (Pen selPen = new Pen(Color.Gray, 5.0f))
            {
                int borderSize = (cellSize + padding) * size + padding; 
                g.DrawRectangle(selPen, xOff - padding, yOff - padding, borderSize, borderSize);
            }

            //draw cells
            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    int xPos = (cellSize + padding) * x + xOff;
                    int yPos = (cellSize + padding) * y + yOff;
                    if (puzzle[x, y])
                    {
                        formGraphics.FillRectangle(myBrush, new Rectangle(xPos, yPos, cellSize, cellSize));
                    }
                    else
                    {
                        formGraphics.FillRectangle(inactiveBrush, new Rectangle(xPos, yPos, cellSize, cellSize));
                    }
                }
            }
            myBrush.Dispose();
            formGraphics.Dispose();
            */
        }

        private void mouseClick(object sender, MouseEventArgs e)
        {
            int x = e.Location.X;
            int y = e.Location.Y;
            int[] pos = GridPosition(x, y);

            if (e.Button == MouseButtons.Left)
            {
                Console.WriteLine("x: " + pos[0]);
                Console.WriteLine("y: " + pos[1]);
                if (IsBounds(pos))
                {
                    puzzle[pos[0], pos[1]] = !puzzle[pos[0], pos[1]];
                    this.Invalidate();
                }
            }
        }

        private int[] GridPosition(int x, int y)
        {
            int[] pos = new int[2];
            double xPos = (x - xOff) / (cellSize + padding);
            pos[0] = (int)Math.Floor(xPos);
            double yPos = (y - yOff) / (cellSize + padding);
            pos[1] = (int)Math.Floor(yPos);
            return pos;
        }

        public bool IsBounds(int x, int y)
        {
            if (x < size && x >= 0 && y < size & y >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsBounds(int[] pos)
        {
            return IsBounds(pos[0], pos[1]);
        }

        private void Add_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click_1(object sender, EventArgs e)
        {
            if (!this.Dictionary.Items.Contains(textBox.Text) && textBox.Text != "")
            {
                Dictionary.Items.Add(textBox.Text);
                int t = TileDialog.ShowDialog("test", textBox.Text);
            }
        }

        private void Dictionary_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Remove_Click(object sender, EventArgs e)
        {
            int index = Dictionary.SelectedIndex;
            if (index != -1)
            {
                Dictionary.Items.RemoveAt(index);
            }
        }

        private void statusStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void windowToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pause_CheckedChanged(object sender, EventArgs e)
        {
            if (pause.Checked)
            {
                pause.Text = "Pause";
            }
            else
            {
                pause.Text = "Resume";
            }
        }
    }
}
