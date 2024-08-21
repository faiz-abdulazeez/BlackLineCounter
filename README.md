Vertical Black Line Counter Application

Description:
The Vertical Line Counter app is a C# console application to count the number of vertical black lines in the given image.
This app reads given image file, processes it, and outputs the count of vertical black lines detected in the given image.
This app limited to counting black lines with white background. The solution has two project files. One has simple coding to run the
functionality without any issues. Second project demonstrates the use of interfaces for better security, modularity and maintainability.

Prerequisites:
1. .NET Core SDK: Make sure that the .NET Core SDK installed in the machine. This can be downloaded from the .NET website.
2. Image File: Have an image file ready for counting number of black lines.
3. Installation of Nuget Package System.Drawing.Common.
4. Clone or Download the Repository from the GitHub

Steps:

1. Clone the repository from GitHub:

Use following commands to clone code from GitHub.
git clone https://github.com/faiz-abdulazeez/BlackLineCounter.git
cd BlackLineCounter

2. Build the Application

Open a terminal or command prompt and navigate to the application directory. Build the application using the following command:
dotnet build

Or Build the application from Visual Studio. 

3. Usage

**Run the application

After building the application, you can run it using the following command:
dotnet run

Or Run the application from Visual Studio. 

**Provide the Image Path

When prompted with the message, enter the absolute path to the image file. For example:
Enter absolute path of the test image:
C:\Users\User\Downloads\img_3.jpg

**View Results

The application will process the image and display the number of vertical black lines detected in the console as below.
Number of vertical black lines: 5


Example
Example of running the application:

Enter absolute path of the test image:
C:\Users\User\Downloads\example-image.jpg
Number of vertical black lines: 8

Notes
Image Requirements: Ensure that the image is in a supported format (e.g., JPG, PNG) and is accessible from the provided path.
Black Line Detection: The application identifies vertical black lines based on a threshold of RGB values. Adjustments may be needed for different lighting conditions or image qualities.
Performance: The time taken to process the image may vary based on its size and complexity.

Troubleshooting
File Not Found Error: Ensure that the path to the image file is correct and the file exists.
Invalid Image Format: Verify that the image file format is supported by the application.
Unhandled Exceptions: Check the console output for error messages that may indicate what went wrong.

Contact
For further assistance or to report issues, please contact abdulazeez.faiz1996@gmail.com.