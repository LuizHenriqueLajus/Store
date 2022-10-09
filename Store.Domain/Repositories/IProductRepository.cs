using Store.Store.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Store.Store.Domain.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> Get(IEnumerable<Guid> ids);
    }
}
