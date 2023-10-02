using NUnit.Framework;
using TriangleSolver;

namespace PSTriangleSolverUnitTest

{
    [TestFixture]
    public class TriangleTst
    {
        [Test]
        public void Equilateral_Test()
        {
            int firstSide = 45;
            int secondSide = 45;     
            int thirdSide = 45;
            string testingResult = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
            Assert.AreEqual("A triangle is formed and it is an EQUILATERAL", testingResult);
        }

        [Test]
        public void Isosceles_Test1()
        {

            int firstSide = 105;
            int secondSide = 105;
            int thirdSide = 150;
            string testingResult = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
            Assert.AreEqual("A triangle is formed and it is an ISOSCELES", testingResult);
        }

        [Test]
        public void Isosceles_Test2()
        {
            int firstSide = 89;
            int secondSide = 98;
            int thirdSide = 98;
            string testingResult = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
            Assert.AreEqual("A triangle is formed and it is an ISOSCELES", testingResult);
        }

        [Test]
        public void Isosceles_Test3()
        {
            int firstSide = 98;
            int secondSide = 89;
            int thirdSide = 98;
            string testingResult = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.AreEqual("A triangle is formed and it is an ISOSCELES", testingResult);
        }

        [Test]
        public void Scalene_Test1()
        {
            int firstSide = 98;
            int secondSide = 99;
            int thirdSide = 100;
            string testingResult = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.AreEqual("A triangle is formed and it is a SCALENE", testingResult);
        }


        [Test]
        public void Scalene_Test2()
        {

            int firstSide = 3;
            int secondSide = 4;
            int thirdSide = 5;

            string testingResult = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
            Assert.AreEqual("A triangle is formed and it is a SCALENE", testingResult);
        }







        [Test]
        public void Scalene_Test3()
        {
            int firstSide = 70;
            int secondSide = 90;
            int thirdSide = 120;
            string testingResult = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.AreEqual("A triangle is formed and it is a SCALENE", testingResult);
        }

        [Test]
        public void Scalene_Test4()
        {
            int firstSide = 65;
            int secondSide = 76;
            int thirdSide = 34;
            string testingResult = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.AreEqual("A triangle is formed and it is a SCALENE", testingResult);
        }

        [Test]
        public void Scalene_Test5()
        {
            int firstSide = 55;
            int secondSide = 65;
            int thirdSide = 75;
            string testingResult = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.AreEqual("A triangle is formed and it is a SCALENE", testingResult);
        }

        [Test]
        public void ZeroLength_Test1()
        {
            int firstSide = 12;
            int secondSide = 0;
            int thirdSide = 15;
            string testingResult = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.AreEqual("INVALID triangle - a zero was entered", testingResult);
        }

        [Test]
        public void ZeroLength_Test2()
        {
            int firstSide = 1;
            int secondSide = 2;
            int thirdSide = 0;
            string testingResult = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.AreEqual("INVALID triangle - a zero was entered", testingResult);
        }

        [Test]
        public void ZeroLength_Test3()
        {
            int firstSide = 0;
            int secondSide = 52;
            int thirdSide = 25;
            string testingResult = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.AreEqual("INVALID triangle - a zero was entered", testingResult);
        }

        [Test]
        public void InvalidResponse_Test1()
        {
            int firstSide = 12;
            int secondSide = 12;
            int thirdSide = 24;
            string testingResult = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.AreEqual("A triangle is not formed based on the input values", testingResult);
        }

        [Test]
        public void InvalidResponse_Test2()
        {
            int firstSide = 24;
            int secondSide = 12;
            int thirdSide = 12;
            string testingResult = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.AreEqual("A triangle is not formed based on the input values", testingResult);
        }

        [Test]
        public void InvalidResponse_Test3()
        {
            int firstSide = 12;
            int secondSide = 24;
            int thirdSide = 12;
            string testingResult = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.AreEqual("A triangle is not formed based on the input values", testingResult);
        }





    }
}