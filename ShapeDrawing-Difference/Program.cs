using System;
using System.Collections.Generic;
using System.Text;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class Program
    {
        private enum ShapeKind
        {
            Rectangle,
            Circle,
            Line
        }
        public static void Main()
        {
            new Window("Shape Drawer", 800, 600);
            Drawing myDrawing = new Drawing(Color.White);
            ShapeKind kindToAdd = ShapeKind.Circle;

            int selectedShapeIndex = -1;

            while (!SplashKit.WindowCloseRequested("Shape Drawer"))
            {
                SplashKit.ProcessEvents();

                // when the user clicks the left button on their mouse, changes shapes x,y to mouse's position.
                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    Shape newShape;

                    if (kindToAdd == ShapeKind.Circle)
                    {
                        newShape = new MyCircle();
                    }
                    else if (kindToAdd == ShapeKind.Rectangle)
                    {
                        newShape = new MyRectangle();
                    }
                    else
                    {
                        newShape = new MyLine();
                    }

                    newShape.X = SplashKit.MouseX();
                    newShape.Y = SplashKit.MouseY();
                    myDrawing.AddShape(newShape); // add shape to the collection
                }

                // change shape kind according to user input
                if (SplashKit.KeyTyped(KeyCode.RKey))
                {
                    kindToAdd = ShapeKind.Rectangle;
                }
                else if (SplashKit.KeyTyped(KeyCode.CKey))
                {
                    kindToAdd = ShapeKind.Circle;
                }
                else if (SplashKit.KeyTyped(KeyCode.LKey))
                {
                    kindToAdd = ShapeKind.Line;
                }

                if (SplashKit.KeyTyped(KeyCode.SpaceKey)) // check if the user presses the spacebar
                {
                    myDrawing.Background = SplashKit.RandomColor(); // changes shapes color to random color
                }

                if (SplashKit.MouseClicked(MouseButton.RightButton))
                {
                    //myDrawing.SelectShapeAt(SplashKit.MousePosition());
                    Point2D mousePos = SplashKit.MousePosition();
                    selectedShapeIndex = myDrawing.SelectShapeAt(mousePos);
                    Console.WriteLine(selectedShapeIndex != -1 ? "Shape Selected" : "No Shape Selected");
                }

                if (SplashKit.KeyTyped(KeyCode.BackspaceKey) || SplashKit.KeyTyped(KeyCode.DeleteKey))
                {
                     myDrawing.RemoveShape(selectedShapeIndex);
                     selectedShapeIndex = -1;
                     Console.WriteLine("Successfully Deleted Selected Shape");
                }

                SplashKit.ClearScreen(myDrawing.Background);

                myDrawing.Draw(); // call Draw method

                SplashKit.RefreshScreen(60);
            }
        }
    }
}
