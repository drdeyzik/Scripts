using HelloWorld;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldUnitTest
{
    [TestClass]
    public class HelloTest
    {
        [TestMethod]
        public void Testmethod1Success()
        {
            var mt = new Translator();
            var h = new Hello(mt);
            string res = h.Greeting("ru", "John");
            Assert.AreEqual("Привет Джон", res);            
        }

        [TestMethod]
        public void TestMethod2Failed()
        {
            var mt = new Translator();
            var h = new Hello(mt);
            string res = h.Greeting("en", "John");
            Assert.AreEqual("Привет Джон", res);
        }
    }
}
