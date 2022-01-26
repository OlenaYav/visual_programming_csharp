using System.Drawing;
using System.IO;
using Svg;

namespace lab7_yavorska
{
	class svg
	{
        //починаємо рисувавати,як відомо, з лівого верхнього кута, тому нам треба його координати
        private Point getTopLeft(Settings settings, int width, int height)
        {
            return new Point(
                (width - settings.Dimensions.Width) / 2,
                (height - settings.Dimensions.Height) / 2
            );
        }
        public SvgDocument RectangleToSVG(Settings settings, int width, int height, string filepath)
        {
            SvgDocument svg = new SvgDocument();
            svg.Width = width;
            svg.Height = height;

            SvgLinearGradientServer gradientFill = new SvgLinearGradientServer
            {
                ID = "lgradient"
            };
            SvgGradientStop from = new SvgGradientStop();
            from.Offset = new SvgUnit(SvgUnitType.Percentage, 0.0f);
            from.StopColor = new SvgColourServer(settings.ColorFrom);

            SvgGradientStop to = new SvgGradientStop();
            to.Offset = new SvgUnit(SvgUnitType.Percentage, 100.0f);
            to.StopColor = new SvgColourServer(settings.ColorTo);

            gradientFill.Children.Add(from);
            gradientFill.Children.Add(to);

            //побудова прямокутника(з верхнього лівого кута) і його заливка
            SvgRectangle rectangle = new SvgRectangle();
            rectangle.SetRectangle(new RectangleF(getTopLeft(settings, width, height), settings.Dimensions));
            rectangle.Fill = gradientFill;


            SvgDefinitionList defs = new SvgDefinitionList();
            defs.Children.Add(gradientFill);

            svg.Children.Add(defs);
            svg.Children.Add(rectangle);
            //збереження прямокутника
            File.WriteAllText(filepath, svg.GetXML());

            return svg;
        }

        public void RenderRectangle(Graphics gr, SvgDocument document)
        {
            using (ISvgRenderer renderer = SvgRenderer.FromGraphics(gr))
            {
                document.RenderElement(renderer);
            }
        }
    }
}
