using AutoMapper;
using BabyCareProject.DataAccess.Entities;
using BabyCareProject.DataAccess.Settings;
using BabyCareProject.Dtos.InstructorDtos;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace BabyCareProject.Services.InstructorServices
{
    public class InstructorService : IInstructorService
    {
        private readonly IMongoCollection<Instructor> _instructorCollection;
        private readonly IMapper _mapper;

        public InstructorService(IDatabaseSettings databaseSettings, IMapper mapper)
        {
            _mapper = mapper;
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _instructorCollection = database.GetCollection<Instructor>(databaseSettings.InstructorCollectionName);
        }

        public async Task CreateInstructorAsync(CreateInstructorDto createInstructorDto)
        {
            var instructor = _mapper.Map<Instructor>(createInstructorDto);
            await _instructorCollection.InsertOneAsync(instructor);
        }

        public async Task DeleteInstructorAsync(string id)
        {
            await _instructorCollection.DeleteOneAsync(x => x.Id == id);
        }

        public async Task<UpdateInstructorDto> GetInstructorByIdAsync(string id)
        {
            var instructor = await _instructorCollection.Find(x => x.Id == id).FirstOrDefaultAsync();
            return _mapper.Map<UpdateInstructorDto>(instructor);
        }

        public async Task<List<ResultInstructorDto>> GetAllInstructorAsync()
        {
            var values = await _instructorCollection.AsQueryable().ToListAsync();
            return _mapper.Map<List<ResultInstructorDto>>(values);
        }

        public async Task UpdateInstructorAsync(UpdateInstructorDto updateInstructorDto)
        {
            var instructor = _mapper.Map<Instructor>(updateInstructorDto);
            await _instructorCollection.FindOneAndReplaceAsync(x=>x.Id==instructor.Id,instructor);
        }

        public async Task<int> CountInstructorAsync()
        {
            return (int)await  _instructorCollection.CountDocumentsAsync(FilterDefinition<Instructor>.Empty);
        }
    }
}
