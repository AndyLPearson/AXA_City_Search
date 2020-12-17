using AXA_Code_Test.Classes;
using AXA_Code_Test.Interfaces;
using AXA_Code_Test.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class CityFinderUnitTests
    {
        private CityFinder sut;

        private readonly Mock<ICityRepository> CountryRepoistoryMock = new Mock<ICityRepository>();

        [TestInitialize]
        public void Setup()
        {
            sut = CreateCityFinderObject();
        }

        [DataTestMethod]
        [DynamicData(nameof(TestDataSource.TestDataSource.DynamicDataSources.CityFinder_BANG_Tests), typeof(TestDataSource.TestDataSource.DynamicDataSources))]
        public void GivenStringBang_CityFinder_Finds3CountriesAnd3Characters(
            string searchTerm,
            List<string> countries,
            ICityResult expectedCityResult)
        {
            CountryRepoistoryMock
                .Setup(x => x.GetCities())
                .Returns(countries);

            ICityResult result = sut.Search(searchTerm);

            Assert.AreEqual(JsonConvert.SerializeObject(expectedCityResult), JsonConvert.SerializeObject(result));

        }

        [DataTestMethod]
        [DynamicData(nameof(TestDataSource.TestDataSource.DynamicDataSources.CityFinder_LA_Tests),typeof(TestDataSource.TestDataSource.DynamicDataSources))]
        public void GivenStringLA_CityFinder_Finds3CountriesAnd2Characters(
            string searchTerm,
            List<string> countries,
            ICityResult expectedCityResult)
        {
            CountryRepoistoryMock
                .Setup(x => x.GetCities())
                .Returns(countries);

            ICityResult result = sut.Search(searchTerm);

            Assert.AreEqual(JsonConvert.SerializeObject(expectedCityResult), JsonConvert.SerializeObject(result));

        }

        [DataTestMethod]
        [DynamicData(nameof(TestDataSource.TestDataSource.DynamicDataSources.CityFinder_ZE_Tests), typeof(TestDataSource.TestDataSource.DynamicDataSources))]
        public void GivenStringZE_CityFinder_FindsNoResults(
            string searchTerm,
            List<string> countries,
            ICityResult expectedCityResult)
        {
            CountryRepoistoryMock
                .Setup(x => x.GetCities())
                .Returns(countries);

            ICityResult result = sut.Search(searchTerm);

            Assert.AreEqual(JsonConvert.SerializeObject(expectedCityResult), JsonConvert.SerializeObject(result));

        }

        protected CityFinder CreateCityFinderObject()
        {
            return new CityFinder(CountryRepoistoryMock.Object);
        }
    }
}
