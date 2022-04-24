﻿using Domain.ModelClasses;

namespace Domain.DataAccessContracts;

public interface IRegisterDao
{
   
    public Task<User> AddUserAsync(User user);
    public Task DeleteUserAsync(string userName);
    public Task UpdateUserAsync(User user);
    public Task<User> GetUserByIdAsync(int id);
    
    // the Add method returns a User this is because the User object is finalized when storing it, i.e. it gets an Id assigned from the FileData
    // component, at some later point. We return it, so the finalized object can be displayed to the user, should we want to.

}