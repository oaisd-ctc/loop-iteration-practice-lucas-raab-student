public class Program
{

    public static void Main(string[] args)
    {
        Write1ThroughN_While(-1);
        Write1ThroughN_While(5);
        Write1ThroughN_While(0);
        Write1ThroughN_For(-1);
        Write1ThroughN_For(5);
        Write1ThroughN_For(0);
        WriteNThrough1_While(-1);
        WriteNThrough1_While(5);
        WriteNThrough1_While(0);
        Write1Through1_For(-1);
        Write1Through1_For(5);
        Write1Through1_For(0);
        WriteEvensThourgh100();

        FindSum(5);
        FindSum(1);
        FindSum(-3);

        FindSum(100);
        FindSumOfEvenNumbers(10);
        FindSumOfEvenNumbers(-5);
        FindSumOfEvenNumbers(2);
        FindSumOfEvenNumbers(1);
        FindSumOfEvenNumbers(0);
        FindSumOfEvenNumbers(25);
        FindSumOfEvenNumbers(-25);

        FindSumOfOddNumbers(10);
        FindSumOfOddNumbers(-5);
        FindSumOfOddNumbers(1);
        FindSumOfOddNumbers(2);
        FindSumOfOddNumbers(25);
        FindSumOfOddNumbers(-25);






        OutputRightTriangle(4);
        OutputRightTriangle(6);
        OutputRightTriangle(-4);
        OutputRightTriangle(-6);
        OutputRightTriangle(0);








    }
    public static void Write1ThroughN_While(int n)
    {
        if (n <= 0)
        {
            OutOfRangeMessage(n);



        }
        else
        {
            int count = 1;
            while (count <= n)
            {
                Console.Write(count + " ");
                count++;
            }
            Console.WriteLine();
        }
    }
    public static void Write1ThroughN_For(int n)

    {
        if (n <= 0)
        {
            OutOfRangeMessage(n);

        }
        else
        {

            for (int i = 1; i < 6; i++)
            {
                Console.Write(i + " ");


            }
            Console.WriteLine();

        }




    }
    public static void WriteNThrough1_While(int n)

    {
        if (n <= 0)
        {
            OutOfRangeMessage(n);

        }
        else
        {
            int count = 1;
            while (n >= count)
            {
                Console.Write(n + " ");
                n--;


            }
            Console.WriteLine();

        }


    }
    public static void Write1Through1_For(int n)
    {
        if (n <= 0)
        {
            OutOfRangeMessage(n);
        }
        else
        {
            for (int i = 5; i > 0; i--)
            {
                Console.Write(i + " ");


            }
            Console.WriteLine();

        }
    }
    public static void WriteEvensThourgh100()
    {
        for (int i = 2; i <= 100; i += 2)
        {
            Console.Write(i + " ");

        }
        Console.WriteLine();
    }
    public static void FindSum(int n)
    {
        int sum = 0;


        if (n > 0)
        {
            for (int i = 0; i <= n; i++)
            {

                sum = sum + i;

            }
            Console.WriteLine(sum);
        }
        else
        {
            for (int i = n; i <= 1; i++)
            {
                sum = sum + i;

            }
            Console.WriteLine(sum);


        }

    }
    public static void FindSumOfEvenNumbers(int n)
    {
        int sum = 0;
        if (n > 1)
        {
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                    sum = sum + i;



            }
            Console.WriteLine(sum);

        }
        else
        {
            for (int i = n; i <= 1; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;

                }
            }
            Console.WriteLine(sum);


        }





    }
    public static void FindSumOfOddNumbers(int n)
    {
        int sum = 0;
        if (n > 1)
        {
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 1)
                {
                    sum = sum + i;

                }

            }

        }
        else
        {
            for (int i = n; i <= 1; i++)
                if (i % 2 == -1 || i % 2 == 1)
                {

                    sum = sum + i;



                }
        }
        Console.WriteLine(sum);


    }
    public static void OutputRightTriangle(int _base)
    {
        if (_base == 0)
        {
            OutOfRangeMessage(_base);

        }
        else if (_base > 0)
        {
            for (int i = 0; i < _base; i++)
            {

                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


        }
        else
        {
            for (int i = _base; i < 0; i++)
            {



                for (int j = i; j < 0; j++)
                {

                    Console.Write("*");
                }
                Console.WriteLine();


            }
            Console.WriteLine();

        }



    }









    public static void OutOfRangeMessage(int n)
    {
        Console.WriteLine(n + " is out of range");
    }





}






