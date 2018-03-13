using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratePasswords
{
    class Passwords
    {
        // Пароль
        private string _pass;
        public string Pass { get => _pass; set => _pass = value; }
    }

    class ListPasswords: List<Passwords>
    {

    }
}
