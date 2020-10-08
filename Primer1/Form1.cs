using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primer1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random r = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            int a = r.Next(60, 100);
            int b = r.Next(20, 50);
            int x = r.Next(a / 2, ClientRectangle.Width - a / 2);
            int y = r.Next(b / 2, ClientRectangle.Width - b / 2);
            int R = r.Next(256);
            int G = r.Next(256);
            int B = r.Next(256);
            Color bojaOkvira = Color.FromArgb(R, G, B);
            Color bojaUnutrasnjosti = Color.FromArgb(150, R, G, B);
            Pen olovka = new Pen(bojaOkvira, 2);
            SolidBrush cetka = new SolidBrush(bojaUnutrasnjosti);
            Graphics g = CreateGraphics();
            g.FillRectangle(cetka, x - a / 2, y - b / 2, a, b);
            g.DrawRectangle(olovka, x - a / 2, y - b / 2, a, b);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
