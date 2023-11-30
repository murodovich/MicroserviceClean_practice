namespace NajotNur.Infrastructure.Services
{
    public interface IBaseService<Tmodel,TDto> where Tmodel : class
    {
        public ValueTask<int> Create(TDto dto);
        public ValueTask<int> Update(int id, TDto dto);
        public ValueTask<int> Delete(int id);
        public ValueTask<IList<Tmodel>> GetAll();
        public ValueTask<Tmodel> GetById(int id);


    }
}
