using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rtipo.Views;
using rtipo.Entities;

namespace rtipo.Presenters
{
    public class UserPresenter
    {
        IUser userView;

        public UserPresenter(IUser view)
        {
            userView = view;
        }

        public bool Auth(string login, string password)
        {
            User user = new User();
            user.Login = userView.LoginText;
            user.Password = userView.PasswordText;

            return user.Auth(login, password);
        }

    }
}
