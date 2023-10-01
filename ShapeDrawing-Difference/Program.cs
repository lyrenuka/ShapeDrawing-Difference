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
                   
                }

                // change shape kind according to user input
                if (SplashKit.KeyTyped(KeyCode.RKey))
                {
                    
                }
                else if (SplashKit.KeyTyped(KeyCode.CKey))
                {
                    
                }
                else if (SplashKit.KeyTyped(KeyCode.LKey))
                {
                    
                }

                if (SplashKit.KeyTyped(KeyCode.SpaceKey)) // check if the user presses the spacebar
                {
                    // changes shapes color to random color
                }

                if (SplashKit.MouseClicked(MouseButton.RightButton))
                {
                    //myDrawing.SelectShapeAt(SplashKit.MousePosition());
                    
                }

                if (SplashKit.KeyTyped(KeyCode.BackspaceKey) || SplashKit.KeyTyped(KeyCode.DeleteKey))
                {
                     myDrawing.RemoveShape(selectedShapeIndex);
                     selectedShapeIndex = -1;
                     Console.WriteLine("Successfully Deleted Selected Shape");
                }

                SplashKit.ClearScreen(myDrawing.Background);

                // call Draw method

                SplashKit.RefreshScreen(60);
            }
        }
    }
}