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
        public bool ShowIncovertible { get; set; } = false;
        public bool UseBradford { get; set; } = false;

        public Bitmap Generate()
        {
            var rxM = MathUtils.TranformationMatrix(InProfile);
            var xrM = MathUtils.TranformationMatrix(OutProfile).Inverse();
            var bdfM = MathUtils.GetBradford(InProfile, OutProfile, rxM, xrM);

            Bitmap outImg = new Bitmap(Image.Width, Image.Height);
            for(int x = 0; x < Image.Width; x++)
            {
                for(int y = 0; y < Image.Height; y++)
                {
                    Color color = Image.GetPixel(x, y);
                    Vector<float> c = Vector<float>.Build.Dense(new float[] {(float)color.R / 256, (float)color.G / 256, (float)color.B / 256 });

                    c = MathUtils.GammaTransform(c, InProfile.Gamma);
                    // rgb -> xyz
                    c = rxM * c;
                    // bradford
                    if(UseBradford)
                        c = bdfM * c;
                    // xyz -> rgb
                    c = xrM * c;

                    NormalizeColor(c);
                    c = MathUtils.GammaTransform(c, 1.0f / OutProfile.Gamma);
                    c = c * 255;

                    outImg.SetPixel(x, y, Color.FromArgb((int)c[0], (int)c[1], (int)c[2]));
                }
            }
            return outImg;
        }
        public void GrayOut()
        {
            for (int x = 0; x < Image.Width; x++)
            {
                for (int y = 0; y < Image.Height; y++)
                {
                    Color color = Image.GetPixel(x, y);
                    int Y = (int)(0.299f * color.R + 0.587f * color.G + 0.114f * color.B);
                    Color newColor = Color.FromArgb(Y, Y, Y);
                    Image.SetPixel(x, y, newColor);
                }
            }
        }

        private void NormalizeColor(Vector<float> c)
        {
            if(ShowIncovertible)
            {
                if (c[0] < 0 ||
                    c[1] < 0 ||
                    c[2] < 0 ||
                    c[0] > 1 ||
                    c[1] > 1 ||
                    c[2] > 1)
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
                if (c[0] > 1)
                    c[0] = 1;
                if (c[1] > 1)
                    c[1] = 1;
                if (c[2] > 1)
                    c[2] = 1;
            }
        }
    }
}
