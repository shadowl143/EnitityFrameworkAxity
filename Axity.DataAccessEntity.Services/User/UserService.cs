using AutoMapper;
using Axity.DataAccessEntity.DataAccess.DAO.Interface;
using Axity.DataAccessEntity.DataAccess.DAO.User;
using Axity.DataAccessEntity.Dtos.User;
using Axity.DataAccessEntity.Entities.Model.User;
using Axity.DataAccessEntity.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axity.DataAccessEntity.Services.User
{
    public class UserService : ICatalogService<UserDto>
    {
        private readonly ICatalogDao<UserModel> modelDao;
        private readonly IMapper mapper;

        public UserService(ICatalogDao<UserModel> modelDao, IMapper mapper)
        {
            this.modelDao = modelDao;
            this.mapper = mapper;
        }
        public async Task Create(UserDto model)
        {
            var userDto = this.mapper.Map<UserModel>(model);
            await this.modelDao.Create(userDto);
        }

        public async Task Delete(UserDto model)
        {
            var userDto = this.mapper.Map<UserModel>(model);
            await this.modelDao.Delete(userDto);
        }

        public async Task<UserDto> FindById(int id)
        {
            var userDto = this.mapper.Map<UserDto>(await this.modelDao.FindById(id));
            return userDto;
        }

        public async Task<IEnumerable<UserDto>> GetAll()
        {
            var userDto = this.mapper.Map<ICollection<UserDto>>(await this.modelDao.GetAll());
            return userDto;
        }

        public async Task Update(UserDto model)
        {
            var userDto = this.mapper.Map<UserModel>(model);
            await this.modelDao.Update(userDto);
        }
    }
}
