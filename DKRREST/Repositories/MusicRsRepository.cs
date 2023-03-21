using DKRREST.Models;
using System.Globalization;

namespace DKRREST.Repositories
{
    public class MusicRsRepository
    {
        private static int _nextID = 1;

        private static readonly List<MusicRecord> Data = new List<MusicRecord>
        {
            new MusicRecord() {Id = _nextID++, Title = "Bohemian Rhapsody", Artist = "Queen", Duration = 333, publicationYear = 1975},
            new MusicRecord() {Id = _nextID++, Title = "Mamma Mia", Artist = "Abba", Duration = 200, publicationYear = 1975},
            new MusicRecord() {Id = _nextID++, Title = "Ghost", Artist = "Justin Bieber", Duration = 200, publicationYear = 2021}
        };

        public List<MusicRecord> GetAll(string title)
        {
            List<MusicRecord> record = new List<MusicRecord>(Data);

            if (title != null)
            {
                record = record.FindAll(record => record.Title != null && record.Title.StartsWith(title));
            }
            return record;
        }

        public MusicRecord? GetById(int id)
        {
            return Data.Find(record => record.Id == id);
        }

        public List<MusicRecord> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
