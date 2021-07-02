using Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Tests
{
    [TestClass]
    public class FakeDb
    {

        [TestMethod]
        public void InicializarBanco()
        {
            try
            {
                DbInitializer.Seed();
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
