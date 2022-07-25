using Entities.Concrete;

namespace Business.Interfaces
{
    public interface IAppUserService : IGenericService<AppUser>
    {
        /// <summary>
        /// Eğer user var ise true döner yok ise false döner.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        bool CheckUser(string userName, string password);
        AppUser FindByName(string userName);
    }
}
