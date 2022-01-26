using System.Drawing;

namespace lab7_yavorska
{
	class Settings
	{
        public Size Dimensions;
        public Color ColorFrom;
        public Color ColorTo;

        public static Settings Empty(Size pict)
        {
            return new Settings
            {//дефолтні значення кольору і розміру картинки
                Dimensions = new Size(pict.Width / 2, pict.Height / 2),
                ColorFrom = Color.Red,
                ColorTo = Color.White
            };
        }
    }
}
