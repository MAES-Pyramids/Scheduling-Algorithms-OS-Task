using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FCFS
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            Pen black_pen = new Pen(Color.Black);
            Brush black_brush = new SolidBrush(Color.Black);
            //process/resourse line
            //allocation string
            string st_alc = "Allocation";
            Font st_font = new Font("Arial", 20);
            PointF alc_points = new PointF(100, 22);
            gr.DrawString(st_alc, st_font, black_brush, alc_points);
            //Max string
            string st_max = "Max";
            PointF max_points = new PointF(367, 22);
            gr.DrawString(st_max, st_font, black_brush, max_points);
            //need string
            string st_need = "Need";
            PointF need_points = new PointF(554, 22);
            gr.DrawString(st_need, st_font, black_brush, need_points);
            //available string
            string st_avai = "Available";
            PointF avai_points = new PointF(741, 22);
            gr.DrawString(st_avai, st_font, black_brush, avai_points);
            //horizontal lines
            gr.FillRectangle(black_brush, 10, 10, 908, 10);
            gr.FillRectangle(black_brush, 10, 60, 908, 7);
            gr.FillRectangle(black_brush, 721, 350, 187, 7);//message 
            gr.FillRectangle(black_brush, 10, 505, 908, 10);
            //vertical lines
            gr.FillRectangle(black_brush, 10, 10, 10, 500);//first
            gr.FillRectangle(black_brush, 60, 10, 7, 500);//allocation
            gr.FillRectangle(black_brush, 304, 10, 7, 500);//max
            gr.FillRectangle(black_brush, 514, 10, 7, 500);//need
            gr.FillRectangle(black_brush, 721, 10, 7, 500);//available
            gr.FillRectangle(black_brush, 908, 10, 10, 500);//last
        }
    }
}
