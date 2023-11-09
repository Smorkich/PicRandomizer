namespace Picture2
{
    public static class BackGroundColors
    {
        public static Dictionary<BackColor, Color> BackColors = new Dictionary<BackColor, Color>()
        {
            { BackColor.Aquamarine, Color.Aquamarine },
            { BackColor.Azure, Color.Azure},
            {BackColor.burlywood, Color.BurlyWood},
            { BackColor.cadetblue, Color.CadetBlue },
            { BackColor.gainsboro, Color.Gainsboro },
            { BackColor.gold, Color.Gold },
            { BackColor.khaki, Color.Khaki },
            { BackColor.lawngreen, Color.LawnGreen },
            { BackColor.lightgreen, Color.LightGreen },
            { BackColor.lightskyblue, Color.LightSkyBlue },
            { BackColor.linen, Color.Linen },
            { BackColor.mediumorchid, Color.MediumOrchid },
            { BackColor.mediumpurple, Color.MediumPurple },
            { BackColor.mistyrose, Color.MistyRose },
            { BackColor.olive, Color.Olive },
            { BackColor.olivedrab, Color.OliveDrab },
            { BackColor.orange, Color.Orange },
            { BackColor.orangered, Color.OrangeRed },
            { BackColor.orchid, Color.Orchid },
            { BackColor.paleturquoise, Color.PaleTurquoise },
            { BackColor.peru, Color.Peru },
            { BackColor.pink, Color.Pink },
            { BackColor.plum, Color.Plum },
            { BackColor.royalblue, Color.RoyalBlue },
            { BackColor.sandybrown, Color.SandyBrown },
            { BackColor.seagreen, Color.SeaGreen },
            { BackColor.steelblue, Color.SteelBlue }
        };
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
