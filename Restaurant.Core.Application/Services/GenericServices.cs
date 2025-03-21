using AutoMapper;
using Restaurant.Core.Application.Interfaces.IRepositories;
using Restaurant.Core.Application.Interfaces.IServices;

namespace Restaurant.Core.Application.Services
{
    public class GenericServices<SaveViewModel, ViewModel, Entity> : IGenericService<SaveViewModel, ViewModel, Entity>
        where SaveViewModel : class
        where ViewModel : class
        where Entity : class
    {
        private readonly IGenericRepository<Entity> _genericRepository;
        private readonly IMapper _mapper;

        public GenericServices(IGenericRepository<Entity> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        public virtual async Task<SaveViewModel> Add(SaveViewModel saveViewModel)
        {
            Entity entity = _mapper.Map<Entity>(saveViewModel);
            entity = await _genericRepository.AddAsync(entity);

            SaveViewModel saveVm= _mapper.Map<SaveViewModel>(entity);
            return saveVm;
        }

        public virtual async Task Delete(int id)
        {
            Entity entity = await _genericRepository.GetByIdAsync(id);
            await _genericRepository.DeleteAsync(entity);
        }

        public virtual async Task<List<ViewModel>> GetAll()
        {
            var entityList = await _genericRepository.GetAllAsync();
            return _mapper.Map<List<ViewModel>>(entityList);
        }

        public virtual async Task<SaveViewModel> GetById(int id)
        {
            Entity entity = await _genericRepository.GetByIdAsync(id);
            SaveViewModel saveVm = _mapper.Map<SaveViewModel>(entity);
            return saveVm;
        }

        public virtual async Task Update(SaveViewModel saveViewModel,int id)
        {
            Entity entity = _mapper.Map<Entity>(saveViewModel);
            await _genericRepository.EditAsync(entity, id);
        }
    }
}
