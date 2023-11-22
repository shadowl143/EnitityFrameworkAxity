using Axity.DataAccessEntity.Dtos.User;
using Axity.DataAccessEntity.Facade.Interface;
using Axity.DataAccessEntity.Services.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Axity.DataAccessEntity.Facade.User
{
    public class UserFacade : ICatalogFacade<UserDto>
    {
        private readonly ICatalogService<UserDto> modelService;

        public UserFacade(ICatalogService<UserDto> modelService)
        {
            this.modelService = modelService;
        }

        public Task Create(UserDto model)
        {
            return this.modelService.Create(model);
        }

        public Task Delete(UserDto model)
        {
            return this.modelService.Delete(model);

        }

        public Task<UserDto> FindById(int id)
        {
            return this.modelService.FindById(id);
        }

        public Task<IEnumerable<UserDto>> GetAll()
        {
            return this.modelService.GetAll();

        }

        public Task Update(UserDto model)
        {
            return this.modelService.Update(model);

        }
    }
}
