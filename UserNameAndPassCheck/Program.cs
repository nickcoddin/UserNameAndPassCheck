namespace UserNameAndPassCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PasswordAndUsername passwordAndUsername = new PasswordAndUsername();    
            string userName = "nick";
            string passwprd = "123Abc";

            Console.WriteLine("Welcome to my Project!");
            passwordAndUsername.UsernameAndPasswordCheck(userName, passwprd);
            Console.ReadKey();
        }
    }
}