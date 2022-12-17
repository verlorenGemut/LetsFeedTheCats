using Model.Entity;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Model.Service
{
    public class AuthService : IAuthService
    {
        SHA256 sha256Hash = SHA256.Create();

        private static Random random = new Random();

        private IRepository<User> userRepository;
       /* public AuthService(IRepository<User> userRepository)
        {
            this.userRepository = userRepository;
        }*/
        public short logIn(string username, string password)
        {
            if (username == null)
                return 0;

            User user = userRepository.getFeederFromDatabase(username);

            if (user == null)
                return 0;

            password += user.strPasswordSalt;

            
            if (verifyHash(sha256Hash, password, user.strPasswordHashed))
            {
                return user.shAccountTYpe; 
            }
            return 0; 
        }

        public short register(string username, string password, string confirmPassword)
        {

            if (username == null)
                return 1;

            User user = userRepository.getFeederFromDatabase(username);
            if (user != null)
                return 2;
            else if (password.Length < 8)
                return 3;

            string salt = getRandomString(5);

            password += salt;
            confirmPassword += salt;

            string passwordHash = getHash(sha256Hash, password);

            if (verifyHash(sha256Hash, confirmPassword, passwordHash))
            {
                short user_type = 1;
                if (username == "admin")
                    user_type = 2;
                User new_user = new User(username, passwordHash, salt, user_type);
                userRepository.addFeederToDatabase(new_user);
                return 0;
            }
            else
            {
                return 4; //hash did not match
            }

        }

        private static string getHash(HashAlgorithm hashAlgorithm, string input)
        {
            // Convert the input string to a byte array and compute the hash.
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));
            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            var sBuilder = new StringBuilder();
            // Loop through each byte of the hashed data
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        private static bool verifyHash(HashAlgorithm hashAlgorithm, string input, string hash)
        {
            var hashOfInput = getHash(hashAlgorithm, input);
            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            return comparer.Compare(hashOfInput, hash) == 0;
        }

        public static string getRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
