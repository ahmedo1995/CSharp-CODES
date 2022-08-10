namespace INEC_APP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            SortedList<string, int> sortList = new SortedList<string, int>();

            string[] inecArray = { "bola", "mide", "nas", "odini", "emma", "nas", "ayo", "mac", "john", "ayo" };



            foreach (var name in inecArray)
            {
                int noOfTimes = 0;
                if (sortList.ContainsKey(name))
                {
                    continue;
                }
                for (int i = 0; i < inecArray.Length; i++)
                {
                    if (name == inecArray[i])
                    {
                        noOfTimes++;
                    }
                }
                if (noOfTimes > 1)
                {
                    sortList.Add(name, noOfTimes);
                }
            }
            foreach (var item in sortList)
            {
                Console.WriteLine(item);

            }
        }
    }
}