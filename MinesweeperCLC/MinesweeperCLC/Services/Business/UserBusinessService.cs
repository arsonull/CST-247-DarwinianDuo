using MinesweeperCLC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinesweeperCLC.Services.Business
{
    public class UserBusinessService
    {
        public UserData login(UserData user)
        {
            return user;
        }
        public UserData register(UserData user)
        {
            return user;
        }

        public List<UserData> getAllUsers()
        {
            List<UserData> userList = new List<UserData>();
            return userList;
        }
    }
}
