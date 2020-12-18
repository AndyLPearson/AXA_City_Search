using AXA_Code_Test.Classes;
using AXA_Code_Test.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.TestDataSource
{
    internal static class TestDataSource
    {
        public static class DynamicDataSources
        {
            public static IEnumerable<object[]> CityFinder_BANG_Tests
            {
                get
                {
                    yield return new object[]
                    {
                        "BANG", //Search Term
                        new List<string>
                        {
                            "BANDUNG",
                            "BANGUI",
                            "BANGKOK",
                            "BANGALORE",
                        }, //Country List for Repo return 
                        new CityResult
                        {
                            NextCities = new List<string> {"BANGUI", "BANGKOK", "BANGALORE" },
                            NextLetters = new List<string> {"U", "K", "A" }
                        } //Expected return result from CityFinder Search function
                    };
                }
            }

            public static IEnumerable<object[]> CityFinder_LA_Tests
            {
                get
                {
                    yield return new object[]
                    {
                        "LA", //Search Term
                        new List<string>
                        {
                            "LA PAZ",
                            "LA PLATA",
                            "LAGOS",
                            "LEEDS"
                        }, //Country List for Repo return 
                        new CityResult
                        {
                            NextCities = new List<string> 
                            {
                                "LA PAZ",
                                "LA PLATA",
                                "LAGOS"
                            },
                            NextLetters = new List<string> {" ","G" }
                        } //Expected return result from CityFinder Search function
                    };
                }
            }

            public static IEnumerable<object[]> CityFinder_ZE_Tests
            {
                get
                {
                    yield return new object[]
                    {
                        "ZE", //Search Term
                        new List<string>
                        {
                            "ZARIA",
                            "ZHUGHAI",
                            "ZIBO"
                        }, //Country List for Repo return 
                        new CityResult
                        {
                            NextCities = new List<string>
                            {

                            },
                            NextLetters = new List<string> 
                            {

                            }
                        } //Expected return result from CityFinder Search function
                    };
                }
            }

            public static IEnumerable<object[]> CityFinder_SameLength_Tests
            {
                get
                {
                    yield return new object[]
                    {
                        "City",
                        new List<string>
                        {
                            "CITY"
                        },
                        new CityResult
                        {
                            NextCities = new List<string>
                            {
                                "CITY"
                            },
                            NextLetters = new List<string>
                            {
                                
                            }
                        }
                    };
                    yield return new object[]
                    {
                        "NeWcAstlE",
                        new List<string>
                        {
                            "NEWCASTLE"
                        },
                        new CityResult
                        {
                            NextCities = new List<string>
                            {
                                "NEWCASTLE"
                            },
                            NextLetters = new List<string>
                            {

                            }
                        }
                    };
                    yield return new object[]
                    {
                        "Thornaby",
                        new List<string>
                        {
                            "Thornaby"
                        },
                        new CityResult
                        {
                            NextCities = new List<string>
                            {
                                "Thornaby"
                            },
                            NextLetters = new List<string>
                            {

                            }
                        }
                    };
                }
            }
        }
    }
}
