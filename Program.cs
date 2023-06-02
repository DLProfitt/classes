namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company krustyKrab = new Company("Krusty Krab", new DateTime());
            Console.WriteLine($"Employees of the {krustyKrab.Name}: ");


            // Create three employees
            Employee spongeBob = new Employee("SpongeBob", "SquarePants", "Fry Cook", new DateTime());
            Console.WriteLine($"{spongeBob.FirstName} {spongeBob.LastName} is a {spongeBob.Title}.");

            Employee mrKrabs = new Employee("Eugene", "Krabs", "Restaurateur", new DateTime());
            Console.WriteLine($"{mrKrabs.FirstName} {mrKrabs.LastName} is a {mrKrabs.Title}.");

            Employee squidward = new Employee("Squidward", "Tentacles", "Cashier", new DateTime());
            Console.WriteLine($"{squidward.FirstName} {squidward.LastName} is a {squidward.Title}.");

            // Assign the employees to the company

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
        }
    }
}