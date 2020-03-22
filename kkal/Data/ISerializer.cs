using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kkal
{
    interface ISerializer
    {
        void Serialize(object obj, string path);
        object Deserialize(string path);
    }
}
