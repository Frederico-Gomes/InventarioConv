using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioConv.Borders.UseCase
{
    public interface IUseCase <TRequest, TEntity>
    {
        TEntity Execute(TRequest request);
    }
}
 