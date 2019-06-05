using System;
using System.Collections.Generic;
using System.Text;

namespace Javeriana.WebServiceResults
{
    public class LoginResult
    {
        public bool valido { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public string periodo { get; set; }
        public string emplid { get; set; }
        
        public long token_expire_in { get; set; }
        public List<string> rolesWS { get; set; }
    }
}
