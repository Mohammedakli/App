using System;
using System.Collections.Generic;
using ClassLibrary1;
using DAL;

namespace BLL
{
    public class UserBll
    {
       public List<APP_USER> GetUsers()
        {
            return UserDb.SelectUser();
        }

        public void addUser(APP_USER oModel) 
        {            
            UserDb.Add(oModel);
        }
        public void Update(APP_USER oModel, int ID)
        {
            UserDb.Update(oModel, ID);
        }
        public void Delete(int oId)
        {
            UserDb.Delete(oId);
        }
    }
}
