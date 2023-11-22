using Axity.DataAccessEntity.Entities.Context;
using Axity.DataAccessEntity.Entities.Model.Actions;
using Axity.DataAccessEntity.Entities.Model.Menu;
using Axity.DataAccessEntity.Entities.Model.Rols;
using Axity.DataAccessEntity.Entities.Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Axity.DataAccessEntity.Entities.Data.DataInital
{
    public class DataQueries
    {
        public IDatabaseContext DatabaseContext { get; }

        public DataQueries(IDatabaseContext databaseContext)
        {
            DatabaseContext = databaseContext;
        }
        public static void Setup()
        {

        }

        public void UserTable()
        {
            var exist = this.DatabaseContext.Users.Any();
            if (!exist)
            {
                var list = new List<UserModel>
                {
                    new UserModel
                    {
                        LastName = "Last",
                        Mail = "Mail",
                        Name = "Name",
                        Password = "Password",
                        Phone = "123456789",
                        RegisterDate = new DateTime(2023, 11, 20),
                        SecondLastName = "SecondLastName",
                        Status = true,
                        UserName = "Mail",
                    },
                    new UserModel
                    {
                        LastName = "user1",
                        Mail = "user1",
                        Name = "user1",
                        Password = "user1",
                        Phone = "123456788",
                        RegisterDate = new DateTime(2023, 11, 20),
                        SecondLastName = "user1",
                        Status = true,
                        UserName = "user1",
                    },
                };
                this.DatabaseContext.Users.AddRange(list);
            }
        }
        public static List<RolModel> RolTable()
        {
            var list = new List<RolModel>
            {
                new RolModel
                {
                    Id = 1,
                    Name = "rol",
                    Description = "rol",
                    Code = "rol",
                    Status = true,
                },
                new RolModel
                {
                    Id = 2,
                    Name = "rol1",
                    Description = "rol1",
                    Code = "rol1",
                    Status = true,
                },
            };
            return new List<RolModel>();
        }
        public static List<UserRolModel> UserRolTable()
        {
            var list = new List<UserRolModel>()
            {
                new UserRolModel
                {
                    UserId = 1,
                    RolId = 1,
                },
                new UserRolModel
                {
                    UserId = 1,
                    RolId = 2,
                },
                new UserRolModel
                {
                    UserId = 2,
                    RolId = 1,
                },
            };
            return list;
        }
        public static List<MenuModel> MenuTable()
        {
            var list = new List<MenuModel>()
            {
                new MenuModel
                {
                    Id= 1,
                    Code = "menu",
                    Name = "menu",
                    Icon = "menu",
                    Status = true,
                },
                new MenuModel
                {
                    Id= 2,
                    Code = "menu 1",
                    Name = "menu 1",
                    Icon = "menu 1",
                    Status = true,
                },
                new MenuModel
                {
                    Id= 3,
                    Code = "menu 2",
                    Name = "menu 2",
                    Icon = "menu 2",
                    Status = true,
                },
                new MenuModel
                {
                    Id= 4,
                    Code = "menu 3",
                    Name = "menu 3",
                    Icon = "menu 3",
                    Status = true,
                },
                new MenuModel
                {
                    Id= 5,
                    Code = "menu 4",
                    Name = "menu 4",
                    Icon = "menu 4",
                    Status = true,
                },
            };

            return list;
        }
        public static List<SubMenuModel> SubMenuTable()
        {
            return new List<SubMenuModel>();
        }
        public static List<PageModel> PageTable()
        {
            return new List<PageModel>();
        }
        public static List<Action> ActionTable()
        {
            return new List<Action>();
        }
        public static List<ActSubPageModel> ActSubPageTable()
        {
            return new List<ActSubPageModel>();
        }

    }
}
