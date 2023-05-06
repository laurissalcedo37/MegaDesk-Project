using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Project
{
    enum DesktopMaterial
    {
        Oak = 200,
        Laminate = 100,
        Pine = 50,
        Rosewood = 300,
        Veneer = 125,
    }
    class Desk
    {
        public const int DESK_WIDTH_MINIMUM = 24;
        public const int DESK_WIDTH_MAXIMUM = 96;
        public const int DESK_DEPTH_MINIMUM = 12;
        public const int DESK_DEPTH_MAXIMUM = 48;

        public int Width;
        public int Depth;
        public int Drawers;
        public DesktopMaterial Material;

        public Desk(int _width, int _depth, int _drawers, DesktopMaterial _material)
        {
            Width = _width;
            Depth = _depth;
            Drawers = _depth;
            Material = _material;
        }
    }
}
