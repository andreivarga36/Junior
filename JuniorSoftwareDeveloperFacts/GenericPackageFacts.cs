using JuniorSoftwareDeveloper;

namespace JuniorSoftwareDeveloperFacts
{
    public class GenericPackageFacts
    {
        private GenericPackage? package;

        [Fact]
        public void AddItem_SmallWeightIsAdded_ShouldReturnExpectedResult()
        {
            package = new GenericPackage("200", 141.5, "PC", "John");
            package.AddItem(15);


            Assert.Equal(156.5, package.Weight);
        }

        [Fact]
        public void CheckId_IdIsValid_ShouldReturnTrue()
        {
            package = new GenericPackage("9973102104", 680, "LAPTOP", "Markus");

            Assert.True(package.CheckId());
        }

        [Fact]
        public void CheckId_IdIsInvalid_ShouldReturnFalse()
        {
            package = new GenericPackage("101432", 0.22, "Phone", "Karl");

            Assert.False(package.CheckId());
        }

        [Fact]
        public void ComputeDetails_PackageIsOk_ShouldReturnExpectedResult()
        {
            package = new GenericPackage("9973102104", 680, "LAPTOP", "Markus");

            string expectedResult = "Pachetul LAPTOP avand codul 9973102104 si greutatea 680 apartine curierului Markus";

            Assert.Equal(expectedResult, package.ComputeDetails());
        }
    }
}