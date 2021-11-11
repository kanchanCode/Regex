using NUnit.Framework;
using regexPractice;

namespace TestProject
{
    public class Tests
    {
        public string patternforName="[A-Za-z]{3}";
       
        regexPattern obj;

        [SetUp]
        public void Setup()
        {
            obj = new regexPattern();
        }

        [Test]
        public void Test1()
        {
            var result = obj.NameCheck("Kan", patternforName);
            Assert.AreEqual(true,result.Success);
        }

       
    }
}
