using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picture2
{
    internal class ImagesPath
    {
        public static string[] fn = Directory.GetFiles(Application.StartupPath + "\\Picrures", "*.png");
        public static Image GetImage()
        {
            Random rand = new Random();

            return Image.FromFile(fn[rand.Next(0, fn.Length)]);
        }
    }
    
}
