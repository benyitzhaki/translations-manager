using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace TranslatonManagerDal
{
    public class MonngoDbContext
    {
        private IMongoDatabase _context;

        public MonngoDbContext(IOptions<Settings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            if (client != null)
                _context = client.GetDatabase(settings.Value.Database);        
        }
        
        /*public IMongoCollection<Note> Notes
        {
            get
            {
                return _database.GetCollection<Note>("Note");
            }
        }*/
        
    }
}