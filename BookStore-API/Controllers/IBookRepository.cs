using BookStore_API.Contracts;
using BookStore_API.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_API.Controllers
{
    public interface IBookRepository : IRepositoryBase<Book>
    {

    }
}
