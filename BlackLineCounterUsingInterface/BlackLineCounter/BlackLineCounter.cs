using System.Drawing;

namespace BlackLineCounterUsingInterface.BlackLineCounter
{
    public class BlackLineCounter : IBlackLineCounter
    {
        /// <summary>
        /// Counts the number of vertical black lines in the image provided.
        /// </summary>
        /// <param name="bitmap">The image to analyze.</param>
        /// <returns>The number of vertical black lines in the image as an integer.</returns>
        public int CountVerticalBlackLines(Bitmap bitmap)
        {
            // Initialize the line count to 0.
            int verticalLineCount = 0;
            // Consider previous pixel as while initial case.
            bool wasPreviousPixelWhite = true;

            for (int x = 0; x < bitmap.Width; x++)
            {
                bool isCurrentPixelBlackLine = true;

                // Get middle of the image
                int imageMiddle = bitmap.Height / 2;

                // Check only the middle pixel in the current column as line will exist on both
                // the top half of the image and the bottom half as a continuous straight line.
                Color pixelColor = bitmap.GetPixel(x, imageMiddle);

                // Determine if the pixel is black based on the threshold (This threshold is set as the given example has black pixel with RGB value is 1,1,1) 
                if (!(pixelColor.R <= 30 && pixelColor.G <= 30 && pixelColor.B <= 30))
                {
                    isCurrentPixelBlackLine = false;
                    wasPreviousPixelWhite = true;
                }

                // Count the line if it's black and the previous pixel was white
                if (isCurrentPixelBlackLine && wasPreviousPixelWhite)
                {
                    verticalLineCount++;
                    wasPreviousPixelWhite = false;
                }
            }

            return verticalLineCount;
        }
    }
}
