namespace RegexDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular Expressions");
            ValidUserRegistraton validUserRegistraton = new ValidUserRegistraton();
            Console.WriteLine("Enter valid first name");
            string frstname = Console.ReadLine();
            validUserRegistraton.ValidateFName(frstname);
        }
    }
}
