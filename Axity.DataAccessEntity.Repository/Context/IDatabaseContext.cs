// <summary>
// <copyright file="IDatabaseContext.cs" company="Axity">
// This source code is Copyright Axity and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Axity (www.axity.com).
// </copyright>
// </summary>

namespace Axity.DataAccessEntity.Entities.Context
{
    using Axity.DataAccessEntity.Entities.Model;
    using Axity.DataAccessEntity.Entities.Model.Rols;
    using Axity.DataAccessEntity.Entities.Model.User;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Interface IDataBaseContext.
    /// </summary>
    public interface IDatabaseContext
    {

        DbSet<UserModel> Users { get; set; }
        DbSet<RolModel> Rols { get; set; }
        DbSet<UserRolModel> UserRols { get; set; }
    }
}
