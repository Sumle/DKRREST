using Microsoft.VisualStudio.TestTools.UnitTesting;
using DKRREST.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKRREST.Repositories.Tests
{
    [TestClass()]
    public class MusicRsRepositoryTests
    {
        [TestMethod()]
        public void GetAllTest()
        {
            MusicRsRepository record = new();
            Assert.AreEqual(2, record.GetAll().Count);
        }
    }
}