using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Changing.interFaces
{
    public interface IAccount
    {
        bool checkPssword(string password);
        void ShowingInfo();
    }
}
