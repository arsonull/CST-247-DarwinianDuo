using MinesweeperCLC.Models;
using MinesweeperCLC.Services.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinesweeperCLC.Services.Business
{
    public class UserBusinessService
    {
        private UserDAO DAO = new UserDAO();

        public UserData login(UserData user)
        {
            user = DAO.login(user);
            return user;
        }
        public UserData register(UserData user)
        {
            user = DAO.register(user);
            return user;
        }

        public List<UserData> getAllUsers()
        {
            List<UserData> userList = new List<UserData>();
            userList = DAO.getAllUsers();
            return userList;
        }
    }
}
