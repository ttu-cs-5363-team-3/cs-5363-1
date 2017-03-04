﻿namespace Ttu.Domain
{
    public interface IServiceFactory
    {

        IAuthenticationService CreateAuthenticationService();

        IContactService CreateContactService(IUnitOfWork unitOfWork);

        IOrganizationService CreateOrganizationService(IUnitOfWork unitOfWork);

        IVolunteerProfileReviewService CreateVolunteerProfileReviewService(IUnitOfWork unitOfWork);
        IVolunteerProfileService CreateVolunteerProfileService(IUnitOfWork unitOfWork);

        IUserService CreateUserService(IUnitOfWork unitOfWork);

    }
}
