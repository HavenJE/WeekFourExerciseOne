
// Exercise 1
// Write a program named TestScoreList that accepts eight int values representing student test scores. Display each of the values along with
// a message that indicates how far their score is from the average.

// Tips:

//To write the program for the exercise, you first need to understand the question and use pseudo-code or a flow chart to plan different steps
//to solve the problem.
//There are two main steps in writing this program.

//Step 1: Declare an array that can store 8 int values and input values for it.
//Step 2: Display each element of the array and a message shows the difference between score of each student and the average.

class TestScoreList
{
    static void Main(string[] args)
    {
        double[] eightValue = { 10, 30, 50.8, 70.2, 100, 130.7, 145.5, 170 };
        double average = 0;
        int x = 0;
        double difference;


        for (int i = 0; i < eightValue.Length; i++) 
        {
            // Calculating the average 
            average += eightValue[i] /8;
            
        }
        for (int i = 0;i < eightValue.Length; i++)
        {
            if (average > eightValue[i])
                difference = average - eightValue[i];
            else 
                difference = eightValue[i] - average;
                double roundDifference = Math.Round(difference, 1);
            Console.WriteLine("For an average of {0}, and a score of {1}, the difference is: {2}.", average, eightValue[i], roundDifference);

        }
        // Console.WriteLine(average);

        // Console.WriteLine(difference);
        // Console.WriteLine("For an eight scores average of {0}, and a score of {1}, the difference is: {2}.", average, eightValue[i], roundDifference);
    }
}