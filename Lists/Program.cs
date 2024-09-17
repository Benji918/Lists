namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = [2333, 24, 33355];

            integers.Sort();

            foreach (int i in integers)
            {
                Console.Write(i + " ");
            }

            Console.ReadKey();    
        }
    }
}
