using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picture2
{
    public class BackGroundColors
    {
        public static Dictionary<BackColor, Color> BackColors = new Dictionary<BackColor, Color>();
        public BackGroundColors() 
        {
            BackColors.Add(BackColor.Aquamarine, Color.Aquamarine);
            BackColors.Add(BackColor.Azure, Color.Azure);
            BackColors.Add(BackColor.burlywood, Color.BurlyWood);
            BackColors.Add(BackColor.cadetblue,Color.CadetBlue);
            BackColors.Add(BackColor.gainsboro, Color.Gainsboro);
            BackColors.Add(BackColor.gold, Color.Gold);
            BackColors.Add(BackColor.khaki, Color.Khaki);
            BackColors.Add(BackColor.lawngreen, Color.LawnGreen);
            BackColors.Add(BackColor.lightgreen, Color.LightGreen);
            BackColors.Add(BackColor.lightskyblue, Color.LightSkyBlue);
            BackColors.Add(BackColor.linen, Color.Linen);
            BackColors.Add(BackColor.mediumorchid, Color.MediumOrchid);
            BackColors.Add(BackColor.mediumpurple, Color.MediumPurple);
            BackColors.Add(BackColor.mistyrose, Color.MistyRose);
            BackColors.Add(BackColor.olive, Color.Olive);
            BackColors.Add(BackColor.olivedrab,Color.OliveDrab);
            BackColors.Add(BackColor.orange, Color.Orange);
            BackColors.Add(BackColor.orangered, Color.OrangeRed);
            BackColors.Add(BackColor.orchid, Color.Orchid);
            BackColors.Add(BackColor.paleturquoise, Color.PaleTurquoise);
            BackColors.Add(BackColor.peru, Color.Peru);
            BackColors.Add(BackColor.pink, Color.Pink);
            BackColors.Add(BackColor.plum, Color.Plum);
            BackColors.Add(BackColor.royalblue, Color.RoyalBlue);
            BackColors.Add(BackColor.sandybrown, Color.SandyBrown);
            BackColors.Add(BackColor.seagreen, Color.SeaGreen);
            BackColors.Add(BackColor.steelblue,Color.SteelBlue);
        }
        public enum BackColor
        {
            Aquamarine,
            Azure,
            burlywood,
            cadetblue,
            gainsboro,
            gold,
            khaki,
            lawngreen,
            lightgreen,
            lightskyblue,
            linen,
            mediumorchid,
            mediumpurple,
            mistyrose,
            olive,
            olivedrab,
            orange,
            orangered,
            orchid,
            paleturquoise,
            peru,
            pink,
            plum,
            royalblue,
            sandybrown,
            seagreen,
            steelblue,
        }
        public static BackColor SetColor()
        {
            Array values = Enum.GetValues(typeof(BackColor));
            Random rnd = new Random();
            BackColor randomBar = (BackColor)values.GetValue(rnd.Next(values.Length));
            return randomBar;
        }
    }
}
