namespace NajotNur.Application.Repositories
{
    public interface IBaseRepository<TModel> where TModel : class
    {
        public ValueTask<int> CreateAsync(TModel user);
        public ValueTask<int> UpdateAsync(int Id, TModel user);
        public ValueTask<int> DeleteAsync(int id);
        public ValueTask<IList<TModel>> GetAllAsync();
        public ValueTask<TModel> GetByIdAsync(int id);

    }
}
