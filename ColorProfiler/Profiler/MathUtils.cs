using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using MathNet;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;

namespace ColorProfiler.Profiler
{
    public static class MathUtils
    {
        public static Vector<float> Solve(float[] v, float[,] m)
        {
            var A = Matrix<float>.Build.DenseOfArray(m);
            var b = Vector<float>.Build.Dense(v);

            return A.Solve(b);
        }

        public static Matrix<float> TranformationMatrix(ColorProfile InProfile)
        {
            float Xw, Yw, Zw, zr, zg, zb;
            Xw = InProfile.W.x / InProfile.W.y;
            Yw = 1.0f;
            Zw = (1 - InProfile.W.x - InProfile.W.y) / InProfile.W.y;
            zr = (1 - InProfile.R.x - InProfile.R.y);
            zg = (1 - InProfile.G.x - InProfile.G.y);
            zb = (1 - InProfile.B.x - InProfile.B.y);

            var S = MathUtils.Solve(new float[] { Xw, Yw, Zw }, new float[,] {
                { InProfile.R.x, InProfile.G.x, InProfile.B.x},
                { InProfile.R.y, InProfile.G.y, InProfile.B.y},
                { zr, zg, zb }
            });

            var rxM = Matrix<float>.Build.DenseOfArray(new float[,]
            {
                {InProfile.R.x * S[0], InProfile.G.x * S[1], InProfile.B.x * S[2] },
                {InProfile.R.y * S[0], InProfile.G.y * S[1], InProfile.B.y * S[2] },
                {zr * S[0], zg * S[1], zb * S[2] }
            });
            return rxM;
        }
        public static Matrix<float> GetBradford(ColorProfile InProfile, ColorProfile OutProfile, Matrix<float> M1, Matrix<float> M2)
        {
            float Xw1, Yw1, Zw1, Xw2, Yw2, Zw2;
            Xw1 = InProfile.W.x / InProfile.W.y;
            Yw1 = 1.0f;
            Zw1 = (1 - OutProfile.W.x - OutProfile.W.y) / OutProfile.W.y;
            Xw2 = OutProfile.W.x / OutProfile.W.y;
            Yw2 = 1.0f;
            Zw2 = (1 - OutProfile.W.x - OutProfile.W.y) / OutProfile.W.y;

            var W1 = M1 * Vector<float>.Build.Dense(new float[] {Xw1, Yw1, Zw1});
            var W2 = M2 * Vector<float>.Build.Dense(new float[] {Xw2, Yw2, Zw2});

            var adtM = Matrix<float>.Build.DenseOfArray(new float[,]
            {
                {W2[0] / W1[0], 0, 0 },
                {0, W2[1] / W1[1], 0 },
                {0, 0, W2[2] / W1[2]},
            });

            return M2.Inverse() * adtM * M1;
        }
        public static Vector<float> GammaTransform(Vector<float> c, float gamma)
        {
            Vector<float> result = Vector<float>.Build.Dense(new float[] { 0, 0, 0 });
            result[0] = (float)Math.Pow(c[0], gamma);
            result[1] = (float)Math.Pow(c[1], gamma);
            result[2] = (float)Math.Pow(c[2], gamma);

            if (result[0] * result[1] * result[2] < 0)
                result[0] = 0;
            return result;
        }
    }
}
