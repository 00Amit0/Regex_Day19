﻿namespace RegexDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular Expressions");
            ValidUserRegistraton validUserRegistraton = new ValidUserRegistraton();
            //Console.WriteLine("Enter valid first name");
            //string frstname = Console.ReadLine();
            //validUserRegistraton.ValidateFName(frstname);
            //Console.WriteLine("Enter valid last name");
            //string lstname = Console.ReadLine();
            //validUserRegistraton.ValidateLName(lstname);
            //Console.WriteLine("Enter valid EmailId");
            //string mail = Console.ReadLine();
            //validUserRegistraton.ValidateEmail(mail);
            //Console.WriteLine("Enter mobile number");
            //string mnum = Console.ReadLine();
            //validUserRegistraton.ValidateMobile(mnum);
            Console.WriteLine("Enter password");
            string psswrd = Console.ReadLine();
            validUserRegistraton.ValidatePassword(psswrd);
        }
    }
}
