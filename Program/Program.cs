class Program
{
    static void Main(string[] args)
    {
        var validator = new ValidatorPassword();

        Console.WriteLine("Digite sua senha: ");
        string password = Console.ReadLine();


        if (validator.isValid(password))
        {
            Console.WriteLine("Senha válida");
        }
        else
        {
            Console.WriteLine("Senha inválida");
        }

    }
}