using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorProfiler.Profiler
{
    public class ColorProfile
    {
        public static List<ColorProfile> Profiles = new List<ColorProfile>()
        {
            new ColorProfile() {
                 Name="sRGB",
                 R = (0.64f, 0.33f),
                 G = (0.30f, 0.63f),
                 B = (0.15f, 0.06f),
                 W = (0.312730f, 0.32902f),
                 Gamma = 2.20f
            },
            new ColorProfile() {
                 Name="Adobe RGB",
                 R = (0.64f, 0.33f),
                 G = (0.21f, 0.71f),
                 B = (0.15f, 0.06f),
                 W = (0.312730f, 0.32902f),
                 Gamma = 2.20f
            },
            new ColorProfile() {
                 Name="Apple RGB",
                 R = (0.625f, 0.34f),
                 G = (0.28f, 0.595f),
                 B = (0.155f, 0.07f),
                 W = (0.312730f, 0.32902f),
                 Gamma = 1.80f
            },
            new ColorProfile() {
                 Name="CIE RGB",
                 R = (0.735f, 0.265f),
                 G = (0.274f, 0.717f),
                 B = (0.167f, 0.007f),
                 W = (0.333333f, 0.333333f),
                 Gamma = 2.20f
            },
            new ColorProfile() {
                 Name="Wide Gamut",
                 R = (0.7347f, 0.2653f),
                 G = (0.1152f, 0.8264f),
                 B = (0.1566f, 0.0177f),
                 W = (0.34567f, 0.3585f),
                 Gamma = 1.20f
            },

        };
        public string Name { get; set; }
        public (float x, float y) W  { get; set; }
        public (float x, float y) R  { get; set; }
        public (float x, float y) G  { get; set; }
        public (float x, float y) B  { get; set; }
        public float Gamma { get; set; }
    }
}
