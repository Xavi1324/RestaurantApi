namespace Restaurant.Core.Application.Interfaces.IServices
{
    public interface IGenericService<SaveViewModel, ViewModel,Entity>
    where SaveViewModel : class
    where ViewModel : class
    where Entity : class
    {
        Task Update(SaveViewModel saveViewModel, int id);
        Task<SaveViewModel> Add(SaveViewModel saveViewModel);
        Task Delete(int id);
        Task<SaveViewModel> GetById(int id);
        Task<List<ViewModel>> GetAll();
    }
}
