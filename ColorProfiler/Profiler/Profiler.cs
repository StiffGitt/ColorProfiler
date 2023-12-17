using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Drawing;
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

        public Bitmap Generate()
        {
            var rxM = MathUtils.TranformationMatrix(InProfile);
            var xrM = MathUtils.TranformationMatrix(OutProfile).Inverse();

            Bitmap outImg = new Bitmap(Image.Width, Image.Height);
            for(int x = 0; x < Image.Width; x++)
            {
                for(int y = 0; y < Image.Height; y++)
                {
                    Color color = Image.GetPixel(x, y);
                    Vector<float> c = Vector<float>.Build.Dense(new float[] {(float)color.R / 256, (float)color.G / 256, (float)color.B / 256 });

                    // in gamma
                    c = MathUtils.GammaTransform(c, InProfile.Gamma);
                    // rgb -> xyz
                    c = rxM * c;

                    // xyz -> rgb
                    c = xrM * c;

                    c = MathUtils.GammaTransform(c, 1.0f / OutProfile.Gamma);
                    c = c * 256;
                    NormalizeColor(c);

                    try
                    {
                        outImg.SetPixel(x, y, Color.FromArgb((int)c[0], (int)c[1], (int)c[2]));
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
            return outImg;
        }

        private void NormalizeColor(Vector<float> c)
        {
            bool shouldBlackOut = false;
            if(shouldBlackOut)
            {
                if (c[0] < 0 ||
                    c[1] < 0 ||
                    c[2] < 0 ||
                    c[0] > 255 ||
                    c[1] > 255 ||
                    c[2] > 255)
                {
                    c[0] = 0;
                    c[1] = 0;
                    c[2] = 0;
                }
            }
            else
            {
                if (c[0] < 0)
                    c[0] = 0;
                if (c[1] < 0)
                    c[1] = 0;
                if (c[2] < 0)
                    c[2] = 0;
                if (c[0] > 255)
                    c[0] = 255;
                if (c[1] > 255)
                    c[1] = 255;
                if (c[2] > 255)
                    c[2] = 255;
            }
        }

        //private Color ConvertColor(Color color)
        //{

        //}
    }
}
