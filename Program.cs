//task1

//namespace Generic.Task
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Generic<int> numbers = new Generic<int>();
//            numbers.Print(0);
//        }

//    }

//    class Generic<T>
//    {
//        public void Print(int n)
//        {
//            Console.WriteLine(n);
//        }
//    }
//}




//task2


namespace Generic.task2
{
    internal class Program
    {


        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            Swap<int>(ref a, ref b);

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
    }
}



