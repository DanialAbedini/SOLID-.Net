using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SOLID
{
    public class SRP
    {
        public class User
        {
            public string Email;
            public string Password;
        }
        public class UserServices
        {
            private Validation _validation;
            private User _user;

            public UserServices(User user)
            {
                _user = user;
                _validation = new Validation();
            }

            public void Register()
            {
                if (_validation.ValidateEmail(_user.Email)&& _validation.ValidatePassword(_user.Password))
                {
                    Console.WriteLine($"User With {_user.Email} Email {_user.Password} Password" +
                        $" Successfully Validate!");
                }                                
                else { throw new ValidationException("Password or Email is Not Correct"); }

            }
        }

        private class Validation
        {
            internal bool ValidateEmail(string email)
            {
                string patter = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
                Regex rg = new Regex(patter);
                var match = rg.Match(email);
                return match.Success;
            }

            internal bool ValidatePassword(string password)
            {
                string patter = @"^(?=.*[a-z])(?=.*[a-zA-Z]).{8,}$";
                Regex rg = new Regex(patter);
                var match = rg.Match(password);
                return match.Success;
            }
        }
    }
}
