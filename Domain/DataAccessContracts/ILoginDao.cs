using Domain.ModelClasses;

namespace Domain.DataAccessContracts;

public interface ILoginDao
{
    public bool TryLogin(User user);
}