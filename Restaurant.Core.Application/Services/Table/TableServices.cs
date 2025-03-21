using AutoMapper;
using Restaurant.Core.Application.Interfaces.IRepositories.Table;
using Restaurant.Core.Application.Interfaces.IServices.Table;
using Restaurant.Core.Application.ViewModels.Table;
using Restaurant.Core.Domain.Entities.Table;

namespace Restaurant.Core.Application.Services.Table
{
    public class TableServices : GenericServices<SaveTableViewModel, TableViewModel, Tables>, ITableServices
    {
        private readonly ITableRepository _tableRepository;
        private readonly IMapper _mapper;
        public TableServices(ITableRepository tableRepository, IMapper mapper) : base(tableRepository, mapper)
        {
            _tableRepository = tableRepository;
            _mapper = mapper;
        }
    }
}
