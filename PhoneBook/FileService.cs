
namespace PhoneBook
{
    internal class FileService : IFileService
    {
        private const string filePath = "../../../phonebook.txt";
        private IloggingService loggingService;
        public FileService()
        {
            this.loggingService = new IloggingService();
            Console.WriteLine("phonebook.txt");
            EnsurefileExists();
        }
        public string AddName(string name)
        {
            File.AppendAllText(filePath, name);
            return name;
        }
        public string AddNumber(string number)
        {
            File.AppendAllText(filePath,number);
            return number;
        }

        internal void AddName(string? name, string? number)
        {
            Console.WriteLine($"{name},{number}");

        }

        private void EnsurefileExists()
        {
            var isFilePresent = File.Exists(filePath);
            if (isFilePresent is false)
            {
                File.Create(filePath).Close();
            }
        }
    }
}
