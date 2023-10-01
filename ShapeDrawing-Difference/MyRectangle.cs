using System;
using System.Collections.Generic;
using System.Text;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class MyRectangle : Shape
    {
        private int _width, _height; // variables for assign shapes size

        public MyRectangle(Color clr, float x, float y, int width, int height) :
       base(clr)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public MyRectangle() : this(Color.Green, 0, 0, 100, 100) { }

        // initialise Width property
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }
        // initialise Height property
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }

        // override the Draw method
        public override void Draw()
        {
            SplashKit.FillRectangle(Color, X, Y, _width, _height);
        }
        // override the DrawOutline method
        public override void DrawOutline()
        {
            SplashKit.FillRectangle(Color.Black, (X - 2), (Y - 2), (_width + 4),
           (_height + 4));
        }

        // override the IsAt method
        public override bool IsAt(Point2D pt)
        {
            Rectangle rectangle = SplashKit.RectangleFrom(X, Y, _width, _height);
            //return a rectangle according to given X,Y, Width, and Height
            if (SplashKit.PointInRectangle(pt, rectangle))
                return true;
            else
                return false;
        }
    }
}