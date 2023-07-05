using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permissoes
{
    class cl_utilizador
    {
        public string utilizador { get; set; }
        public string password { get; set; }
        public string permissoes { get; set; }

        public cl_utilizador () 
        {
            permissoes = "1111";
        }
    }
}
