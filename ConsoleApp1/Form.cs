using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form
{
    public class InvalidDataException : Exception
    {
        public InvalidDataException(string message) : base(message)
        {

        }
    }
    public class User
    {
        private int userId;
        private string name;
        private string email;
        private string mobile;

        public int UserId { get => userId; set => userId = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Mobile { get => mobile; set => mobile = value; }

        public User(int userId,string name,string email,string mobile)
        {
            if (userId <= 0)
            {
                throw new InvalidDataException($"Invalid User Id {userId}");
            }
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new InvalidDataException($"Invalid Name {name}");
            }
            if (!IsValidEmail(email))
            {
                throw new InvalidDataException($"Invalid Email {email}.Please enter valid email");
            }
            if (!IsValidMobile(mobile))
            {
                throw new InvalidDataException($"Invalid Mobile Number {mobile}");
            }
            this.UserId = userId;
            this.Name = name;
            this.Email = email;
            this.Mobile = mobile;
        }
        private bool IsValidEmail(string email)
        {
            string pattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            return Regex.IsMatch(email, pattern);
        }
        private bool IsValidMobile(string mobile)
        {
            string pattern = @"^(?:(?:\+|00)(?:[1-9]\d{0,2}))?[-.\s]?\(?(?:[1-9]\d{0,2})\)?[-.\s]?\d{3,4}[-.\s]?\d{4}$";
            return Regex.IsMatch(mobile, pattern);
        }
    }
}
