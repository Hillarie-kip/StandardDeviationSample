using System;

class Program
{
    static void Main(string[] args)
    {
        // Define the quantities
        int electricQuantity = 0;
        int manualQuantity = 5;
        int cashQuantity = 2000;

        // Calculate the standard deviation
        double standardDeviation = CalculateStandardDeviation(electricQuantity, manualQuantity, cashQuantity);

        // Display the standard deviation
        Console.WriteLine("Standard Deviation: {0}", standardDeviation);
    }

    static double CalculateStandardDeviation(int electricQuantity, int manualQuantity, int cashQuantity)
    {
        int count = 0;
        double sum = 0;
        double mean = 0;

        if (electricQuantity != 0)
        {
            sum += electricQuantity;
            count++;
        }

        if (manualQuantity != 0)
        {
            sum += manualQuantity;
            count++;
        }

        if (cashQuantity != 0)
        {
            sum += cashQuantity;
            count++;
        }

        if (count == 0)
        {
            Console.WriteLine("No valid quantities provided.");
            return 0;
        }

        mean = sum / count;

        double sumOfSquaredDifferences = 0;

        if (electricQuantity != 0)
            sumOfSquaredDifferences += Math.Pow(electricQuantity - mean, 2);

        if (manualQuantity != 0)
            sumOfSquaredDifferences += Math.Pow(manualQuantity - mean, 2);

        if (cashQuantity != 0)
            sumOfSquaredDifferences += Math.Pow(cashQuantity - mean, 2);

        double variance = sumOfSquaredDifferences / count;
        double standardDeviation = Math.Sqrt(variance);

        return standardDeviation;
    }
}
