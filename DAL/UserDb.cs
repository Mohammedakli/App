using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DAL
{
    public class UserDb
    {
        public UserDb() { }

        public static List<APP_USER> SelectUser()
        {
            //get list of all persons
            List<APP_USER> persons = new List<APP_USER>();
            try
            {
                using (UserDbEntities context = new UserDbEntities())
                {
                    persons = context.APP_USER.ToList().Select(x => new APP_USER()
                    {
                        ID = x.ID,
                        FIRSTNAME = x.FIRSTNAME,
                        LASTNAME = x.LASTNAME,
                        BIRTHDATE = x.BIRTHDATE,
                        HEIGHT = x.HEIGHT,
                        

                    }).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("erreur", ex);

            }
            return persons;
        }
        public static APP_USER Add(APP_USER oModel)
        {
            try
            {
                using (UserDbEntities oContext = new UserDbEntities())
                {
                    oContext.APP_USER.Add(oModel);
                    oContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("erreur", ex);
            }
            return oModel;
        }
        public static APP_USER Update(APP_USER oModel, int ID)
        {
            try
            {
                using (UserDbEntities oContext = new UserDbEntities())
                {
                    APP_USER userInDb = new APP_USER();
                    userInDb = oContext.APP_USER.Find(ID);
                    userInDb.FIRSTNAME = oModel.FIRSTNAME;
                    userInDb.LASTNAME = oModel.LASTNAME;
                    userInDb.BIRTHDATE = oModel.BIRTHDATE;
                    userInDb.HEIGHT = oModel.HEIGHT;
                    oContext.SaveChanges();
                }

           }
            catch (Exception ex)
            {
                throw new Exception("erreur", ex);
            }
            
            return oModel;
        }
            
       

        public static List<APP_USER> Delete(int oId)
        {
            APP_USER oModel = new APP_USER();
            try
            {
                using (UserDbEntities oContext = new UserDbEntities())
                {
                    oModel = oContext.APP_USER.Find(oId);
                    oContext.APP_USER.Remove(oModel);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("erreur", ex);
            }

            return SelectUser();

        }

       
    }
   
}
