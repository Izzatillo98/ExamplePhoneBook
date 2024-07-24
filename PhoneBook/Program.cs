namespace PhoneBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter number");
            string number = Console.ReadLine();

            FileService fileService = new FileService();
            fileService.AddName(name,number);

        }
    }
}
