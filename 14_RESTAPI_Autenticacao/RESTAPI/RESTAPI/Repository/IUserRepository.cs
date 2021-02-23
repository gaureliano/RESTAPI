using RESTAPI.Data.VO;
using RESTAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTAPI.Repository
{
    public interface IUserRepository 
    {
        User ValidateCredentials(UserVO user);

        User ValidateCredentials(string username);

        bool RevokeToken(string username);

        User RefreshUserInfo(User user);
        
        //void RefreshUserInfo();
    }
}
