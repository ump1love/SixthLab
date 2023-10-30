class Circle : GraphicPrimitive
{
    private float radius;

    public float Radius
    {
        get { return radius; }
        set { radius = value; }
    }

    public override void Draw()
    {
        for (int i = 0; i <= 2 * Radius; i++)
        {
            for (int j = 0; j <= 2 * Radius; j++)
            {
                float dx = Radius - j;
                float dy = Radius - i;

                if (dx * dx + dy * dy <= Radius * Radius)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write(' ');
                }
            }
            Console.WriteLine();
        }
    }

    public override void Scale(float factor)
    {
        Radius = factor;
    }
    public override void Scale(float factor, float f) { }
    public override void Move(int y, int x)
    {
        for (int temp = 0; temp < y; temp++)
        {
            Console.WriteLine();
        }
        for (int i = 0; i <= 2 * Radius; i++)
        {
            for (int temp = 0; temp < x; temp++)
            {
                Console.Write(' ');
            }

            for (int j = 0; j <= 2 * Radius; j++)
            {
                float dx = Radius - j;
                float dy = Radius - i;

                if (dx * dx + dy * dy <= Radius * Radius)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write(' ');
                }
            }
            Console.WriteLine();
        }
    }
}