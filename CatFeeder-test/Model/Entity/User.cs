namespace Model.Entity
{
    public class User
    {
        public User(string username, string passwordHashed, string passwordSalt, short accountType)
        {
            strUsername = username;
            strPasswordHashed = passwordHashed;
            shAccountTYpe = accountType;
            strPasswordSalt = passwordSalt;
        }

        public User() {}

        public string strPasswordHashed { get; set; }
        public string strUsername { get; set; }
        public string strPasswordSalt { get; set; }
        public short shAccountTYpe { get; set; }
    }
}
