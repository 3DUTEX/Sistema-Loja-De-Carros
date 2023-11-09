using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace SistemaLojaDeCarros
{
    public class EstilizacaoButton : Button
    {
        private int borderSize = 0;
        private int borderRadius = 30;
        private Color borderColor = Color.Black;

        public EstilizacaoButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = Color.LightGray;
        }

        private GraphicsPath GetFigurinePath(RectangleF retangle, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(retangle.X, retangle.Y, radius, radius, 180, 90);
            path.AddArc(retangle.Width - radius, retangle.Y, radius, radius, 270, 90);
            path.AddArc(retangle.Width - radius, retangle.Height - radius, radius, radius, 0, 90);
            path.AddArc(retangle.X, retangle.Height - radius, radius, radius, 90, 80);
            path.CloseFigure();

            return path;
        }
        //protected override void onPaint(PaintEventArgs paint)
        //{
        //    base.OnPaint(paint);
        //    paint.Graphics.SmoothingMode = SmoothingMode.HighQuality;

        //    RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
        //    RectangleF rectBorder = new RectangleF(1, 1, this.Width-0.8F, this.Height-1);

        //    if(borderRadius > 2) //Botão com borderradius
        //    {
        //        using (GraphicsPath pathSurface = GetFigurinePath(rectSurface, borderRadius))
        //        using (GraphicsPath pathBorder = GetFigurinePath(rectBorder, borderRadius-1F))
        //        using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
        //        using (Pen penBorder = new Pen(borderColor, borderSize))
        //        {
        //            penBorder.Alignment = PenAlignment.Inset;
        //            this.Region = new Region(pathSurface);
        //        }
        //    }
        //}
    }
}
