using System;

namespace ProjetoAcessos
{
    class Program
    {
        static void Main(string[] args)
        {
            string permission = "Gerente Manager";
            int level = 50;

            if (permission.Contains("Admin") && level > 55)
            {
                Console.WriteLine("Welcome, Super Admin user.");
            }
            if (permission.Contains("Admin") && level <= 55)
            {
                Console.WriteLine("Welcome, Admin user.");
            }
            if (permission.Contains("Gerente") && level >= 20)
            {
                Console.WriteLine("Contact an Admin for access.");
            }
            if (permission.Contains("Gerente") && level < 20)
            {
                Console.WriteLine("You do not have sufficient privileges.");
            }
            else
            {
                Console.WriteLine("You do not have sufficient privileges.");
            }
        }
    }
}
