using System;
using System.Collections.Generic;
using System.Linq;
using ModelLayer.DTO;

namespace BusinessLayer.Interface
{
    public interface IRegisterUserBL
    {
        string RegisterBL();
        bool RegisterUser(LoginDTO newUser);
        bool LoginUser(LoginDTO loginDTO);

    }
}
