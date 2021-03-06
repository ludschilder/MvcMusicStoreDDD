﻿using MvcMusicStore.Data.Repository.EntityFramework.Common;
using MvcMusicStore.Domain.Entities;
using MvcMusicStore.Domain.Interfaces.Repository;

namespace MvcMusicStore.Data.Repository.EntityFramework
{
    public class CartRepository : Repository<Cart>, ICartRepository
    {
    }
}
