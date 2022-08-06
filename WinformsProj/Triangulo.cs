using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformsProj
{
    public static class FormExtensions
    {
        public static void FillTriangle(this Graphics g, PaintEventArgs e, Point p, int size)
        {
            e.Graphics.FillPolygon(Brushes.Red, new Point[] { p,
                new Point(p.X - size, p.Y + (int)(size * Math.Sqrt(3))), 
                new Point(p.X + size, p.Y + (int)(size * Math.Sqrt(3)))
            });
        }
    }
    //Primero heredamos de la clase control 
    public class Triangulo:Control
    {
        // creamos una sobre carga de metodo OnPaint para decidir que es lo que se va a pintar en pantalla
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            // Aqui creamos un trinagulo.
            e.Graphics.FillTriangle(e, new Point(50, 20), 100);

        }
      
    }
}
