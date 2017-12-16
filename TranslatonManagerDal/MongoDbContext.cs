using Microsoft.Extensions.Options;

namespace TranslatonManagerDal
{
    public class MonngoDbContext
    {
        private readonly IMongoDatabase _database = null;

        public MonngoDbContext(IOptions<Settings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            if (client != null)
                _database = client.GetDatabase(settings.Value.Database);
        }

        public IMongoCollection<Note> Notes
        {
            get
            {
                return _database.GetCollection<Note>("Note");
            }
        }
    }
}