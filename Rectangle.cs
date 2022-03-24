using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOTPISP1
{
    class Rectangle : Figure
    {
        public Rectangle(int a, int b,int c,int d) : base(a,b)
        {
            MessageBox.Show($"Rectangle({a}  {b} {c}  {d})");
        }
       
        public override void Draw()
        {
            
           
        }
    }
}
