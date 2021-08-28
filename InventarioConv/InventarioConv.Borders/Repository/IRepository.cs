using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioConv.Borders.Repository
{
    interface IRepository <TEntity>
    {
        IEnumerable<TEntity> listaTodos();
    }
}
