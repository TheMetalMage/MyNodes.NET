﻿/*  MyNetSensors 
    Copyright (C) 2015 Derwish <derwish.pro@gmail.com>
    License: http://www.gnu.org/licenses/gpl-3.0.txt  
*/

using System.Collections.Generic;

namespace MyNetSensors.Users
{
    public interface IUsersRepository
    {
        int AddUser(User user);
        void UpdateUser(User user);
        User GetUser(int id);
        List<User> GetAllUsers();
        void RemoveUser(int id);
        void RemoveAllUsers();
    }
}