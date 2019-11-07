using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hashing
{
    class Program
    {
        // Dummy repository class for DB operations
        static MockUserRepository userRepo = new MockUserRepository();
        // Let us use the Password manager class to generate the password ans salt
        static PasswordManager pwdManager = new PasswordManager();
        static void Main(string[] args)
        {
            // Let us first test the password hash creation i.e. User creation
            string salt = SimulateUserCreation();
            // Now let is simualte the password comparison
            SimulateLogin(salt);
            Console.ReadLine();
        }
        public static string SimulateUserCreation()
        {
            string encodedSalt;
            Console.WriteLine("Let us first test the password hash creation i.e. User creation");
            Console.WriteLine("Please enter user id");
            string userid = Console.ReadLine();
            Console.WriteLine("Please enter password");
            

            SecureString securePassword = new SecureString();
            while (true)
            {
                ConsoleKeyInfo i = Console.ReadKey(true);
                if(i.Key == ConsoleKey.Enter)
                {
                    break;
                }
                else if(i.Key == ConsoleKey.Backspace)
                {
                    securePassword.RemoveAt(securePassword.Length - 1);
                    Console.Write(" ");
                }
                else
                {
                    securePassword.AppendChar(i.KeyChar);
                    Console.Write("*");
                }
            }


            using (var deriveBytes = new Rfc2898DeriveBytes(password, 20)) // 20-byte salt
            {
                byte[] salt2 = deriveBytes.Salt;
                encodedSalt = Convert.ToBase64String(salt2);
            }
            Console.WriteLine("Salt : "+encodedSalt+"\n");

            string salt = null;
            string passwordHash = pwdManager.GeneratePasswordHash(password, out salt);
            // Let us save the values in the database
            User user = new User
            {
                UserId = userid,
                PasswordHash = passwordHash,
                Salt = salt
            };
            // Lets Add the User to the database
            userRepo.AddUser(user);
            return salt;
        }
        public static void SimulateLogin(string salt)
        {
            Console.WriteLine("Now let is simulate the password comparison");
            Console.WriteLine("Please enter user id");
            string userid = Console.ReadLine();
            Console.WriteLine("Please enter password");
            string password = Console.ReadLine();
            // Let us retrieve the values from the database
            User user2 = userRepo.GetUser(userid);

            bool result = pwdManager.IsPasswordMatch(password, user2.Salt, user2.PasswordHash);
            if (result == true)
            {
                Console.WriteLine("Password Matched");
            }
            else
            {
                Console.WriteLine("Password not Matched");
            }
        }

    }
}
