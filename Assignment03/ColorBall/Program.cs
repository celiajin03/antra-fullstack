using ColorBall;

public class Program
{
    public static void Main()
    {
        // Create a few balls.
        Ball ball1 = new Ball(10, new Color(255, 0, 0));
        Ball ball2 = new Ball(20, new Color(0, 255, 0));

        // Throw them around a few times.
        ball1.Throw();
        ball1.Throw();
        ball2.Throw();
        ball2.Throw();

        // Pop a few.
        ball1.Pop();

        // Try to throw them again.
        ball1.Throw(); // This should do nothing.
        ball2.Throw(); // This should work.

        // Print out the number of times that the balls have been thrown.
        Console.WriteLine("Ball 1 has been thrown " + ball1.GetThrowCount() + " times.");
        Console.WriteLine("Ball 2 has been thrown " + ball2.GetThrowCount() + " times.");
    }
}