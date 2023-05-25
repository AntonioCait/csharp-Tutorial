using System;

namespace ConsoleApp1
{
    internal class Program
    {
        // This program is going to calculate your final grade based on all your final grades

        static void Main(string[] args)
        {
            Console.WriteLine("Hi, how many grades are we going to calculate?");

            // This is the number of grades that the user is going to input
            int numberOfGrades = Convert.ToInt32(Console.ReadLine());

            // This is the array that is going to hold all the grades
            int[] grades = new int[numberOfGrades];

            // This is the sum of all the grades
            int sum = 0;

            // This is the average of all the grades
            double average = 0;

            // This is the final grade
            double finalGrade = 0;

            // This is the loop that is going to ask the user for all the grades
            for (int i = 0; i < numberOfGrades; i++)
            {
                Console.WriteLine("Please enter grade number " + (i + 1));
                grades[i] = Convert.ToInt32(Console.ReadLine());
            }

            // This is the loop that is going to calculate the sum of all the grades
            for (int i = 0; i < numberOfGrades; i++)
            {
                sum += grades[i];
            }

            average = (double)sum / numberOfGrades;

            // This is the loop that is going to calculate the final grade
            // Final grade is the sum of all the grades multiplied by 100 divided by the maximum possible sum
            int maximumPossibleSum = numberOfGrades * 100;
            finalGrade = sum * 100.0 / maximumPossibleSum;

            Console.WriteLine("The final grade is " + finalGrade);
            Console.WriteLine("The average is " + average);
            Console.WriteLine("The sum is " + sum);
            Console.WriteLine("The number of grades is " + numberOfGrades);

            Console.ReadLine();
        }
    }
}
