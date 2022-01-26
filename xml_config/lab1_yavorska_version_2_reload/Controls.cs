using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace lab1_yavorska_version_2_reload
{
	class Controls
	{
        public string Name { get; private set; }
        public Point Location { get; private set; }
        public Size Size { get; private set; }
        public string Text { get; private set; }
        public int TabIndex { get; private set; }

        public Controls(string name, Point location, Size size, string text, int tabIndex)
        {
            Name = name;
            Location = location;
            Size = size;
            Text = text;
            TabIndex = tabIndex;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}

