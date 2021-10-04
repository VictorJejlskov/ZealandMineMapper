using System;

namespace DrawShapes
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            // SHAPE A (10 stars in a single row)
            //
            // **********
            //
            Console.WriteLine("Opgave A");
            for(int row = 0; row<10; row++)
            {
                DrawingTool.DrawOneStar();
            }

            Console.WriteLine();
            // SHAPE B (5 stars in a single row, separated by spaces)
            //
            // * * * * * 
            //
            Console.WriteLine("Opgave B");
            for(int row = 0; row<5; row++)
            {
                DrawingTool.DrawOneStar();
                DrawingTool.DrawOneSpace();
            }

            Console.WriteLine();

            // SHAPE C  (10 rows of 10 stars each)
            //
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            //
            Console.WriteLine("Opgave C");
            for(int row = 0; row < 10; row++)
            {
                for (int column = 0; column < 10; column++)
                {
                    DrawingTool.DrawOneStar();
                }
                DrawingTool.StartNewLine();
            }
            Console.WriteLine();
            // SHAPE D (a triangle, I guess...)
            //
            // *
            // **
            // ***
            // ****
            // *****
            // ******
            // *******
            // ********
            // *********
            // **********
            //
            Console.WriteLine("Opgave D");
            for (int row = 0; row < 10; row++)
            {
                for (int column = 0; column <= row; column++)
                {
                    DrawingTool.DrawOneStar();
                }
                DrawingTool.StartNewLine();
            }

            Console.WriteLine();

            // SHAPE E (X)
            //
            // *        *
            //  *      * 
            //   *    *   
            //    *  *    
            //     **     
            //     **     
            //    *  *    
            //   *    *   
            //  *      * 
            // *        *
            Console.WriteLine("Opgave E");
            for (int row = 0; row < 10; row++)
            {
                for (int column = 0; column < 10; column++)
                {
                    if (column == row || (column + row)==9)
                    {
                        DrawingTool.DrawOneStar();
                    }
                    else
                    {
                        DrawingTool.DrawOneSpace();
                    }
                }
                DrawingTool.StartNewLine();
            }


            // The LAST line of code should be ABOVE this line

        }
    }
}