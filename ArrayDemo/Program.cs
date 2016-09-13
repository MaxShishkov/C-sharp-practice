using System;


class ArrayDemo
{
    public static void Main()
    {
        const int SCORE_SIZE = 1000;
        int[] scores = new int[SCORE_SIZE];
        for (int i = 0; i < SCORE_SIZE; i++)
        {
            int score = int.Parse(Console.ReadLine());
            scores[i] = score;
        }
    }
}
