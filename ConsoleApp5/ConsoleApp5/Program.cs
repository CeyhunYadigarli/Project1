namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eded daxil edin");
            int a = Convert.ToInt32(Console.ReadLine());
            
            if(a%2==0)
            {
                Console.WriteLine("Cut ededdir");
            }
            else
            {
                Console.WriteLine("Tek ededdir");
            }
        }
    }
}
