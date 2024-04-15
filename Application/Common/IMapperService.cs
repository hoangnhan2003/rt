using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common
{
    public interface IMapperService
    {
        TDestination Map<T, TDestination>(T source);
        // Các phương thức khác nếu cần
    }
}
