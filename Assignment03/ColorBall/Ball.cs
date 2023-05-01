using System;
namespace ColorBall
{
    public class Ball
    {
        public int Size { get; set; }
        public Color Color { get; set; }
        public int ThrowCount { get; set; }

        public Ball(int size, Color color)
        {
            Size = size;
            Color = color;
            ThrowCount = 0;
        }

        public void Pop()
        {
            Size = 0;
        }

        public void Throw()
        {
            if (Size > 0)
            {
                ThrowCount++;
            }
        }

        public int GetThrowCount()
        {
            return ThrowCount;
        }
    }
}

