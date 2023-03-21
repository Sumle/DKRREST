using Microsoft.VisualStudio.TestTools.UnitTesting;
using DKRREST.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DKRREST.Models;

namespace DKRREST.Repositories.Tests
{
    [TestClass()]
    public class MusicRsRepositoryTests
    {
        MusicRsRepository repo = new MusicRsRepository();

        [TestMethod()]
        public void GetAllTest()
        {
            List<MusicRecord> records = repo.GetAll();
            Assert.AreEqual(records.Count, 3);
            Assert.AreEqual(records[2].Title, "Ghost");
        }
    }
}