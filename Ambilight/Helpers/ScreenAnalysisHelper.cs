using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace Ambilight.Helpers
{
    public class ScreenAnalysisHelper
    {
        
        unsafe static private Color GetColor(Bitmap image)
        {

            if (image.PixelFormat != PixelFormat.Format32bppRgb && image.PixelFormat != PixelFormat.Format24bppRgb) 
                throw new NotSupportedException(String.Format("Unsupported pixel format: {0}", image.PixelFormat));

            var pixelSize=0;

            if (image.PixelFormat == PixelFormat.Format32bppRgb)
                pixelSize = 4;

            if (image.PixelFormat == PixelFormat.Format24bppRgb)
                pixelSize = 3;


            var bounds = new Rectangle(0, 0, image.Width, image.Height);
            var data = image.LockBits(bounds, ImageLockMode.ReadOnly, image.PixelFormat);

            long r = 0;
            long g = 0;
            long b = 0;


            for (int y = 0; y < data.Height; ++y)
            {
                byte* row = (byte*)data.Scan0 + (y * data.Stride);
                for (int x = 0; x < data.Width; ++x)
                {
                    var pos = x * pixelSize;
                    b += row[pos];
                    g += row[pos + 1];
                    r += row[pos + 2];
                }
            }

            r = r / (data.Width * data.Height);
            g = g / (data.Width * data.Height);
            b = b / (data.Width * data.Height);
            image.UnlockBits(data);

            return Color.FromArgb((int)r, (int)g, (int)b);

        }
        public static Color  getAverageColor()
        {
         
            Bitmap myBitmap = Win32APICall.GetDesktop();
            Color screenColor = GetColor(myBitmap);
            myBitmap.Dispose();
            return screenColor;
        }
    }
}
