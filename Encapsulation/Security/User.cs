using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Security
{
    struct User
    {
        public string login;
        private string password;

        // on crée une méthode pour donner une valeur à cette variable privée
        public void SetPassword(string value)
        {
            password = value;
        }

        public bool CheckUser(string login, string password)
        {
            return this.login == login && this.password == password;
        }
    }
}
