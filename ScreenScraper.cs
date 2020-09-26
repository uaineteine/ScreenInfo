using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uaine.Coord;

namespace ScreenScraper
{
    public class ScreenInfo
    {
        public ScreenInfo(coord UpperLeftPos, coord Size)
        {
            size = Size;
            pos = UpperLeftPos;
        }
        public coord size;
        public coord pos;
    }
    public static class scraper
    {
        public static int NoMonitors()
        {
            return Screen.AllScreens.Length;
        }
        public static ScreenInfo[] GetScreenInfo()
        {
            int n = NoMonitors();
            ScreenInfo[] info = new ScreenInfo[n];
            for (int i = 0; i < n; i++)
            {
                info[i] = GetScreen(i);
            }
            return info;
        }
        public static ScreenInfo GetScreen(int screenNo)
        {
            Rectangle bounds = Screen.AllScreens[screenNo].Bounds;
            return new ScreenInfo(new coord(bounds.X, bounds.Y), new coord(bounds.Width, bounds.Height));
        }
    }
}
