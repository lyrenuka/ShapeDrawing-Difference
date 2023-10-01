using System;
using System.Collections.Generic;
using System.Text;
using SplashKitSDK;

namespace ShapeDrawer
{
    public abstract class Shape
    {
        private Color _color; // variable for assign shapes color
        private float _x, _y; // variables for assign shapes postion
        private bool _selected = false;

        public Shape(Color color)
        {
            // initialise shape color to green
            _color = Color.Red;
            // initialise shape position
            _x = 0;
            _y = 0;
        }

        // Shape constructor
        public Shape() : this(Color.Yellow) { }

        // initialise Color property
        public Color Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }

        // initialise X property
        public float X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }

        // initialise Y property
        public float Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }

        public bool Selected { get => _selected; set => _selected = value; }

        public abstract void Draw();

        public abstract void DrawOutline();

        // initialise IsAt method
        public abstract bool IsAt(Point2D pt);
    }
}