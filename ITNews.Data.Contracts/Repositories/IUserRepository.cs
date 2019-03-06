using System.Collections.Generic;
using ITNews.Data.Contracts.Entities;

namespace ITNews.Data.Contracts.Repositories
{
    public interface IUserRepository
    {
        UserEntity Create(UserEntity entity);
        void Delete(UserEntity entity);
        UserEntity Read(UserEntity entity);
        IEnumerable<UserEntity> Read();
        void Update(UserEntity entity);
    }
}