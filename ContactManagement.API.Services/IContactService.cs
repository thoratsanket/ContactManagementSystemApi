﻿using ContactManagement.API.Models.Request;
using ContactManagement.API.Models.Response;

namespace ContactManagement.API.Services
{
    public interface IContactService
    {
        IEnumerable<ContactResponseModel> GetAll();
        ContactResponseModel GetContactsById(int id);
        ContactResponseModel Create(CreateContactRequest model);
        Task<ContactResponseModel> Update(int id, CreateContactRequest model);
        void Delete(int id);
    }
}