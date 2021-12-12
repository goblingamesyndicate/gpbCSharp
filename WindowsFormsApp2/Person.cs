using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Person
    {
        private string vorname;
        private string nachname;
        private string email;

        public Person(string vorname, string nachname, string email)
        {
            this.vorname = vorname;
            this.nachname = nachname;
            this.email = email;
        }

        public string Vorname { get => vorname; set => vorname = value; }
        public string Nachname { get => nachname; set => nachname = value; }
        public string Email { get => email; set => email = value; }
    }
}
