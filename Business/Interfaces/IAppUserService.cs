﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
