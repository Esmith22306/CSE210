using System;
using System.Drawing;

class MandelbrotSetGenerator
{
    static void Main()
    {
        int width = 800; // Width of the image
        int height = 600; // Height of the image
        double minReal = -2.0; // Minimum real value
        double maxReal = 2.0; // Maximum real value
        double minImaginary = -1.5; // Minimum imaginary value
        double maxImaginary = 1.5; // Maximum imaginary value
        int maxIterations = 1000; // Maximum number of iterations
        double escapeRadius = 4.0; // Radius for escape

        Bitmap bitmap = new Bitmap(width, height);

        double realFactor = (maxReal - minReal) / (width - 1);
        double imaginaryFactor = (maxImaginary - minImaginary) / (height - 1);

        for (int y = 0; y < height; y++)
        {
            double cImaginary = maxImaginary - y * imaginaryFactor;

            for (int x = 0; x < width; x++)
            {
                double cReal = minReal + x * realFactor;
                double zReal = 0;
                double zImaginary = 0;
                int iteration = 0;

                while (zReal * zReal + zImaginary * zImaginary < escapeRadius && iteration < maxIterations)
                {
                    double temp = zReal * zReal - zImaginary * zImaginary + cReal;
                    zImaginary = 2 * zReal * zImaginary + cImaginary;
                    zReal = temp;
                    iteration++;
                }

                if (iteration < maxIterations)
                {
                    double logZn = Math.Log(zReal * zReal + zImaginary * zImaginary) / 2;
                    double nu = Math.Log(logZn / Math.Log(2)) / Math.Log(2);
                    iteration = iteration + 1 - nu;
                }

                int color = iteration * 255 / maxIterations;
                Color pixelColor = Color.FromArgb(color, color, color);
                bitmap.SetPixel(x, y, pixelColor);
            }
        }

        bitmap.Save("MandelbrotSet.bmp");
    }
}