﻿namespace TinyGameStore.Data
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public DateTime Birthdate { get; set; }
        public string Password { get; set; }

        public virtual List<UsersGame> UsersGames { get; set; } = new List<UsersGame>();

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            var usrObj = obj as User;
            return usrObj?.UserName == UserName;
        }
    }
}