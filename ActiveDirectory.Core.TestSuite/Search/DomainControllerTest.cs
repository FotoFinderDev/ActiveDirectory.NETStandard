﻿using ActiveDirectory.NETStandard.Object;
using ActiveDirectory.Core.TestFramework.Configuration;
using NUnit.Framework;

namespace ActiveDirectory.NETStandard.TestSuite.Search
{
    class DomainControllerTest : BaseTest
    {
        [TestCase]
        public void TestFindCurrentDomainController() {
            using (DomainController domainController = DomainController.GetCurrent())
            {
                Assert.IsNotNull(domainController);
            }
        }

        [TestCase]
        public void TestFindOneDomainController() {
            using (DomainController domainController = DomainController.FindOne())
            {
                Assert.IsNotNull(domainController);
                Assert.AreEqual(TF.PS["DomainControllerName"], domainController.Name);
            }
        }

        [TestCase]
        public void TestFindOneUser() {
            using (User user = User.FindOneByCN(TF.PS["UserName"]))
            {
                Assert.IsNotNull(user);
            }
        }
    }
}
