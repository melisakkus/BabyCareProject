using AutoMapper;
using BabyCareProject.DataAccess.Entities;
using BabyCareProject.DataAccess.Settings;
using BabyCareProject.Dtos.AboutDtos;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace BabyCareProject.Services.AboutServices
{
    public class AboutService : IAboutService
    {
        private readonly IMapper _mapper;
        private readonly IMongoCollection<About> _aboutCollection;
        public AboutService(IMapper mapper,IDatabaseSettings databaseSettings)
        {
            _mapper = mapper;
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _aboutCollection = database.GetCollection<About>(databaseSettings.AboutCollectionName);
        }
        public async Task CreateAsync(CreateAboutDto dto)
        {
            var about = _mapper.Map<About>(dto);
            await _aboutCollection.InsertOneAsync(about);
        }

        public async Task DeleteAsync(string id)
        {
            await _aboutCollection.DeleteOneAsync(x=>x.AboutId == id);
        }

        public async Task<List<ResultAboutDto>> GetAllAsync()
        {
            var values = await _aboutCollection.AsQueryable().ToListAsync();
            return _mapper.Map<List<ResultAboutDto>>(values);
        }

        public async Task<UpdateAboutDto> GetById(string id)
        {
            var value = await _aboutCollection.FindAsync(x=>x.AboutId == id);
            return _mapper.Map<UpdateAboutDto>(value);
        }

        public async Task UpdateAsync(UpdateAboutDto dto)
        {
            var value = _mapper.Map<About>(dto);
            await _aboutCollection.FindOneAndReplaceAsync(x=>x.AboutId==value.AboutId,value);
        }
    }
}
