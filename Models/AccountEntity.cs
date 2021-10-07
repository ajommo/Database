using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Game.Database.Models
{
    [Table("Account")]
    public class AccountEntity
    {
        private int id;
        private string username;
        private string password;
        private bool active;
        private Guid? token;

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Username
        {
            get => username;
            set => username = value;
        }

        public string Password
        {
            get => password;
            set => password = value;
        }

        public bool Active
        {
            get => active;
            set => active = value;
        }

        public Guid? Token
        {
            get => token;
            set => token = value;
        }
    }
}