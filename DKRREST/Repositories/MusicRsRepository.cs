using DKRREST.Models;

namespace DKRREST.Repositories
{
    public class MusicRsRepository
    {
        private int _nextID;
        private List<MusicRecord> _records;

        public MusicRsRepository() 
        {
            _nextID = 1;
            _records = new List<MusicRecord>()
            {
                new MusicRecord() {Id = _nextID++, Title = "Bohemian Rhapsody", Artist = "Queen", Duration = 333, publicationYear = 1975},
                new MusicRecord() {Id = _nextID++, Title = "Mamma Mia", Artist = "Abba", Duration = 200, publicationYear = 1975},
                new MusicRecord() {Id = _nextID++, Title = "Ghost", Artist = "Justin Bieber", Duration = 200, publicationYear = 2021}
            };
        }

        public List<MusicRecord> GetAll()
        {
            return _records;
        }
    }
}
