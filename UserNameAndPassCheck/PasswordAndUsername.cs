using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserNameAndPassCheck
{
    public class PasswordAndUsername
    {
        public string InputPassword { get; set; } = string.Empty;
        public string InputUsername { get; set; } = string.Empty;


        private void UserInput()
        {
            Console.Write("Please input the Username: ");
            InputUsername = Console.ReadLine();
            Console.Write("Please input the Password: ");
            InputPassword = Console.ReadLine();
        }

        public void UsernameAndPasswordCheck(string username, string password)
        {
            for (int i = 0; i < 5; i++)
            {
                UserInput();

                if (InputPassword.Equals(password) && InputUsername.Equals(username))
                {
                    Console.WriteLine("Well Done!");
                    break;
                }
                else
                {
                    if (i == 4)
                        Console.WriteLine("Error! Invalid input!");
                    else 
                        Console.WriteLine("try again!");
                }
            }
        }
    }
}
