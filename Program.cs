using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Vectors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

        }
        [Test]
        public void TestVectorAddition()
        {

            Vector vector1 = new Vector(2, 3);
            Vector vector2 = new Vector(1, 2);
            Vector expectedResult = new Vector(3, 5);
            Vector result = vector1.Add(vector2);
            Assert.AreEqual(expectedResult, result);
        }
    }
}