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

        public Guid? Token
        {
            get => token;
            set => token = value;
        }
    }
}