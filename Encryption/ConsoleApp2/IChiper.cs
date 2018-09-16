using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public interface IChiper
    {
        string Encode(string unencrypted);
        string Decode(string unencrypted);
    }
}
