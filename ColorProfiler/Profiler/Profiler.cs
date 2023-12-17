using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace ColorProfiler.Profiler
{
    public class Profiler
    {
        public ColorProfile InProfile { get; set; }
        public ColorProfile OutProfile { get; set; }
        public Bitmap Image { get; set; }

        public void Generate()
        {
            var rxM = MathUtils.TranformationMatrix(InProfile);
            var xrM = MathUtils.TranformationMatrix(OutProfile).Inverse();

            Bitmap outImg = new Bitmap(Image.Width, Image.Height);
            for(int x = 0; x < Image.Width; x++)
            {
                for(int y = 0; y < Image.Height; y++)
                {
                    Color color = Image.GetPixel(x, y);
                    Vector<float> c = Vector<float>.Build.Dense(new float[] {color.R, color.G, color.B});

                    outImg.SetPixel(x, y, );
                }
            }
        }

        //private Color ConvertColor(Color color)
        //{

        //}
    }
}
