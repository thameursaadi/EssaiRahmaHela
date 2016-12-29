using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essai.Model
{
    public class Publication
    {
        public String Id { get; set; }

        public String statut { get; set; }

        public String image { get; set; }

        public int like { get; set; }

        public int deslike { get; set; }

        public String commente { get; set; }
    }
}
