using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rtipo.Views
{
    public interface IUser
    {
        string LoginText { get; set; }
        string PasswordText { get; set; }
        bool AuthText { get; set; }
    }
}
