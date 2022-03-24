using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOTPISP1
{
    abstract class Figure:Spisok
    {
        public Color outLineColor { get; set; }
        public double outLineWidth { get; set; }
        public int A { get; set; }
        public int B { get; set; }
       

        public Figure(int a, int b)
        {
            outLineColor = Color.Black;
            outLineWidth = 1;
            B = b;
            A = a;
        }

     

   
        public abstract void Draw();
    }
}
