using AutoMapper;
using BabyCareProject.DataAccess.Entities;
using BabyCareProject.DataAccess.Settings;
using BabyCareProject.Dtos;
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace BabyCareProject.Services
{
    public class GenericRepository<TCDto, TUDto, TRDto, TEntity> : IRepository<TCDto, TUDto, TRDto, TEntity>
                          where TCDto : class where TUDto : class, IHasId where TRDto : class, IHasId where TEntity : IEntity
    {
        private readonly IMapper _mapper;
        private readonly IMongoCollection<TEntity> _collection;
        public GenericRepository(IMapper mapper, IDatabaseSettings databaseSettings)
        {
            _mapper = mapper;
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            string collectionName = typeof(TEntity).Name + "CollectionName";
            string collection = databaseSettings.GetType().GetProperty(collectionName)?.GetValue(databaseSettings)?.ToString();
            _collection = database.GetCollection<TEntity>(collection);
        }

        public async Task CreateAsync(TCDto model)
        {
            var value = _mapper.Map<TEntity>(model);
            await _collection.InsertOneAsync(value);
        }

        public async Task DeleteAsync(string id)
        {
            var filter = Builders<TEntity>.Filter.Eq(x=>x.Id,id);
            await _collection.DeleteOneAsync(filter);
        }

        public async Task<List<TRDto>> GetAllAsync()
        {
            var values = await _collection.AsQueryable().ToListAsync();
            return _mapper.Map<List<TRDto>>(values);
        }

        public async Task<TUDto> GetByIdAsync(string id)
        {
            var filter = Builders<TEntity>.Filter.Eq(x => x.Id, id);
            var value = await _collection.Find(filter).FirstOrDefaultAsync();
            return _mapper.Map<TUDto>(value);
        }

        public async Task UpdateAsync(TUDto model)
        {
            var filter = Builders<TEntity>.Filter.Eq(x => x.Id, model.Id);
            var value = _mapper.Map<TEntity>(model);
            await _collection.FindOneAndReplaceAsync(filter, value);
        }
    }
}

