using System;
using System.Collections.Generic;
using System.Text;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class MyLine : Shape
    {
        private float _endX;
        private float _endY;

        public MyLine(Color clr, float startX, float startY, float endX, float
       endY) : base(clr)
        {
            X = startX;
            Y = startY;
            _endX = endX;
            _endY = endY;
        }

        public MyLine() : this(Color.Red, 0, 0, 100, 100) { }

        public float EndX { get => _endX; set => _endX = value; }
        public float EndY { get => _endY; set => _endY = value; }

        // override the Draw method
        public override void Draw()
        {
            SplashKit.DrawLine(Color, X, Y, _endX, _endY);
        }

        // override the DrawOutline method
        public override void DrawOutline()
        {
            SplashKit.FillCircle(Color.Black, X, Y, 4);
            SplashKit.FillCircle(Color.Black, _endX, _endY, 4);
        }

        // override the IsAt method
        public override bool IsAt(Point2D pt)
        {
            Line line = SplashKit.LineFrom(X, Y, _endX, _endY);
            // return a line according to given X,Y, EndX, and EndY
            if (SplashKit.PointOnLine(pt, line))
                return true;
            else
                return false;
        }
    }
}