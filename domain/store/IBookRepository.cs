using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public interface IBookRepository
    {
        Book[] GetAllByIsbm(string isbm);
        Book[] GetAllByTitleOrAuthor(string titleOrAuthor);
    }
}
