using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace MiniCapstone_TechStoreApp.Helper
{
    public static class ImageHelper
    {
        public static Image ConvertBytesToImage(byte[] imageData)
        {
            if (imageData == null || imageData.Length == 0)
                return null;

            using (MemoryStream ms = new MemoryStream(imageData))
            using (Image original = Image.FromStream(ms))
            {
                return new Bitmap(original);
            }
        }

        public static byte[] ConvertImageToBytes(Image image)
        {
            if (image == null)
                return null;

            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
    }
}
