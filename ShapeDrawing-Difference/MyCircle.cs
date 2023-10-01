using System;
using System.Collections.Generic;
using System.Text;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class MyCircle : Shape
    {
        private int _radius;

        public int Radius { get => _radius; set => _radius = value; }

        public MyCircle(Color clr, int radius) : base(clr)
        {
            _radius = radius;
        }

        public MyCircle() : this(Color.Blue, 50) { }

        // override the Draw method
        public override void Draw()
        {
            if (Selected)
                DrawOutline();
            SplashKit.FillCircle(Color, X, Y, _radius);
        }

        // override the DrawOutline method
        public override void DrawOutline()
        {
            SplashKit.FillCircle(Color.Black, X, Y, (_radius + 2));
        }

        // override the IsAt method
        public override bool IsAt(Point2D pt)
        {
            Circle circle = SplashKit.CircleAt(X, Y, _radius);
            // return a circleaccording given X,Y and Radius
            if (SplashKit.PointInCircle(pt, circle))
                return true;
            else
                return false;
        }
    }
}