using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class IntersectionConfiguration
    {
        public MainRoad TopRoad { get; set; }
        public MainRoad BottomRoad { get; set; }
        public MinorRoad LeftRoad { get; set; }
        public MinorRoad RightRoad { get; set; }
        public int Duration { get; set; }

    }
    public class MainRoad
    {
        public int ForwardRight { get; set; }
        public int Left { get; set; }
        public int CrossWalk { get; set; }
    }

    public class MinorRoad
    {
        public int Main { get; set; }
        public int Right { get; set; }
        public int CrossWalk { get; set; }
    }
}
