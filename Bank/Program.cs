namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Customer customer = new Customer();
            Console.WriteLine("please enter your name");
            string name = Console.ReadLine();
            customer.name = name;
            Console.WriteLine("please enter your Bvn");
            int bvn = Convert.ToInt32(Console.ReadLine());
            customer.Bvn = bvn;
            Console.WriteLine("Please enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            customer.age = age;


            Console.WriteLine(customer.Openaccount());

        }
    }
}