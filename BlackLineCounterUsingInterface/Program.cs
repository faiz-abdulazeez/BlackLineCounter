using System.Drawing;
using BlackLineCounterUsingInterface.BlackLineCounter;

namespace VerticalLineCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter absolute path of the test image:");

            // Input Path to image file, remove " in case user inputs.
            string imagePath = Console.ReadLine().Replace("\"", string.Empty);

            // Validating the path
            if (string.IsNullOrWhiteSpace(imagePath) || !File.Exists(imagePath))
            {
                Console.WriteLine("File path is not valid or file does not exist.");
                return;
            }

            try
            {
                using (Bitmap bitmap = new Bitmap(imagePath))
                {
                    // Instantiate the line counter using the interface
                    IBlackLineCounter lineCounter = new BlackLineCounter();
                    int verticalLineCount = lineCounter.CountVerticalBlackLines(bitmap);
                    Console.WriteLine($"Number of vertical black lines: {verticalLineCount}");
                }
            }
            // exception if user inputs file type other than image
            catch (ArgumentException argEx)
            {
                Console.WriteLine($"Invalid image format: {argEx.Message}");
            }
            // exception if file does not exist (This is already checked before)
            catch (FileNotFoundException fnfEx)
            {
                Console.WriteLine($"File not found: {fnfEx.Message}");
            }
            // exception if any issue with inputting the file
            catch (IOException ioEx)
            {
                Console.WriteLine($"I/O error occurred: {ioEx.Message}");
            }
            // exception for any other issues
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}
