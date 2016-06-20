using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasterPassword
{
    [Serializable]
    class Password
    {
        public int ID { get; set; }
        public string password { get; set; }

        public string Details { get; set; }

        public string UserName { get; set; }

        public string LNK { get; set; }

    }
}
