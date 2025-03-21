using Restaurant.Core.Application.ViewModels.Table;
using Restaurant.Core.Domain.Entities.Table;

namespace Restaurant.Core.Application.Interfaces.IServices.Table
{
    public interface ITableServices : IGenericService<SaveTableViewModel, TableViewModel, Tables>
    {
    }
}
