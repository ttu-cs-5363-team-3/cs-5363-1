﻿namespace Ttu.Domain
{
    public interface IUnitOfWork
    {

        // attributes - authenticated
        string SessionId { get; }
        IUser User { get; }

        // attributes - repository
        IUnitOfWorkRepository<IContact> Contacts { get; }
        IUnitOfWorkRepository<IUser> Users { get; }

        // behavior
        void Abort();
        void Commit();
        void Release();

    }
}
