namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.

            // Create three employees
            Employee spongeBob = new Employee("SpongeBob", "SquarePants", "Fry Cook", new DateTime());
            Console.WriteLine($"{spongeBob.FirstName} {spongeBob.LastName} is a {spongeBob.Title}.");

            Employee mrKrabs = new Employee("Eugene", "Krabs", "Restaurateur", new DateTime());
            Console.WriteLine($"{mrKrabs.FirstName} {mrKrabs.LastName} is a {mrKrabs.Title}");

            // Assign the employees to the company

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
        }
    }
}