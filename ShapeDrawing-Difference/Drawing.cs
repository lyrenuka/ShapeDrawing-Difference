using System.Collections.Generic;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class Drawing
    {
        public List<Shape> SelectedShapes { get; } = new List<Shape>();

        private Color _background;

        public Drawing(Color background)
        {
            SelectedShapes = new List<Shape>();
            _background = background;
        }

        public Drawing() : this(Color.White)
        {
        }

        public Color Background
        {
            get { return _background; }
            set { _background = value; }
        }

        public int ShapeCount
        {
            get { return SelectedShapes.Count; }
        }

        public void AddShape(Shape s)
        {
            SelectedShapes.Add(s);
        }

        public void Draw()
        {
            SplashKit.ClearScreen(_background);

            foreach (Shape s in SelectedShapes)
            {
                if (s.Selected)
                {
                    s.DrawOutline();
                }
                s.Draw();
            }

            SplashKit.RefreshScreen();
        }

        public int SelectShapeAt(Point2D pt)
        {
            for (int i = SelectedShapes.Count - 1; i >= 0; i--)
            {
                if (SelectedShapes[i].IsAt(pt))
                {
                    SelectedShapes[i].Selected = true;
                    return i; // Return the index of the selected shape
                }
            }
            return -1; // No shape was selected
        }

        public void RemoveShape(int index)
        {
            if (index >= 0 && index < SelectedShapes.Count)
            {
                SelectedShapes.RemoveAt(index);
            }
        }
    }
}
