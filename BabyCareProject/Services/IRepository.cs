namespace BabyCareProject.Services
{
    public interface IRepository<TCDto,TUDto,TRDto,TEntity> where TCDto : class
    {
        Task<List<TRDto>> GetAllAsync();
        Task<TUDto> GetByIdAsync(string id);
        Task CreateAsync(TCDto model);
        Task UpdateAsync(TUDto model);
        Task DeleteAsync(string id);
    }
}
