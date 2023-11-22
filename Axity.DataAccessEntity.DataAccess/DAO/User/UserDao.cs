namespace Axity.DataAccessEntity.DataAccess.DAO.User
{
    using Axity.DataAccessEntity.DataAccess.DAO.Interface;
    using Axity.DataAccessEntity.DataAccess.Util;
    using Axity.DataAccessEntity.Entities.Context;
    using Axity.DataAccessEntity.Entities.Model.User;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class UserDao : ICatalogDao<UserModel>
    {
        private readonly IDatabaseContext databaseContext;

        public UserDao(IDatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        public async Task Create(UserModel model)
        {
            this.databaseContext.Users.Add(model);
            await ((DatabaseContext)this.databaseContext).SaveChangesAsync();
        }

        public Task Delete(UserModel model)
        {
            throw new System.NotImplementedException();
        }

        public async Task<UserModel> FindById(int id)
        {// select * from users as user
            var user = await this.databaseContext.Users.Include(e => e.UserRol).ThenInclude(e => e.Rol).Where(e => e.Id == id)
                .OrderBy(e => e.Id).ThenBy(e => e.Name).FirstOrDefaultAsync();

            // carga peresosa.
            //var result = (from userTable in this.databaseContext.Users
            //              where userTable.Id == id
            //              select userTable);

            var result = (from userTable in this.databaseContext.Users
                          join roluser in this.databaseContext.UserRols on userTable.Id equals roluser.UserId
                          where userTable.Id == id
                          select new UserModel
                          {
                              Id = user.Id,
                              Name = userTable.Name,
                              Password = userTable.Password,
                              Estado = "Activo",
                              UserRol = this.databaseContext.UserRols.Where(e => e.UserId == user.Id).ToList(),
                          });
            SqlValidationUtil<UserModel>.ValidateRow(user, id.ToString());
            return user;
        }

        public async Task<IEnumerable<UserModel>> GetAll()
        {
           var result = await this.databaseContext.Users.Include(e => e.UserRol).ThenInclude(e => e.Rol)
                .OrderBy(e => e.Id).ThenBy(e => e.Name).ToListAsync();
            return result;
        }

        public async Task Update(UserModel model)
        {
            var user = this.databaseContext.Users.Where(e => e.Id == model.Id).FirstOrDefault();
            this.databaseContext.Users.Update(model);
            await ((DatabaseContext)this.databaseContext).SaveChangesAsync();
        }

    }
}
