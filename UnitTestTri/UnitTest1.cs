using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTri
{
    [TestClass]
    public class TriangleUnitTest
    {

         //Equilateral och Scalene har blivit ihopblandade, det är anledningen till att de två testen failar. Har rättat till felet så att det nu är korrekt
        [TestMethod]
        public void isIsoscelesTest()       //Likbent, 2 stycken lika sidor.
        {
            Triangle Tri = new Triangle(4, 2, 4);       //Skapar likbent triangel med sidorna 1 2 1
            Assert.IsTrue(Tri.isIsosceles());           //Om den är likbent blir det true, annars false
            Assert.IsFalse(Tri.isScalene());
            Assert.IsFalse(Tri.isEquilateral());
        }

        [TestMethod]
        public void isEquilateralTest()     //Liksidig, alla sidor är lika.
        {
            Triangle Tri = new Triangle(1.0, 1.0, 1.0);     //Skapar liksidig triangel med sidorna 1.0 1.0 1.0
            Assert.IsTrue(Tri.isEquilateral());             //Om den är liksidig blir det true, annars false
            Assert.IsFalse(Tri.isScalene());
            Assert.IsFalse(Tri.isIsosceles());
        }

        [TestMethod]
        public void isScaleneTest()             //Oliksidig, alla sidor är olika.
        {
            Triangle Tri = new Triangle(3, 4, 5);       //Skapar oliksidig triangel med sidorna 3 4 5
            Assert.IsTrue(Tri.isScalene());             //Om den är oliksidig blir det true, annars false
            Assert.IsFalse(Tri.isEquilateral());
            Assert.IsFalse(Tri.isIsosceles());
        }

        [TestMethod]
        public void triangleConstructorTest()       //Det som ligger i parametrarna i point är koordinater
        {
            Point a = new Point(2, 2);              //De kordinatererna som finns bildar en giltig oliksidig triangel
            Point b = new Point(4, 6);
            Point c = new Point(10, 12);
            Triangle Tri = new Triangle(a, b, c);       //Skapar en oliksidig triangel med de tre koordinaterna
            Assert.IsTrue(Tri.isScalene());             //Om den är oliksidig blir det true, annars false
            Assert.IsFalse(Tri.isEquilateral());
            Assert.IsFalse(Tri.isIsosceles());
        }

        [TestMethod]
        public void triangleConstructorTest2()      //Testar arraykonstruktorn genom att skicka in 3 värden i arrayen
        {
            Triangle Tri = new Triangle(new double[] {3, 4, 5});    //Skapar en triangel som innehåller tre arrayelement med värdena 3 4 5
            Assert.IsTrue(Tri.isScalene());
            Assert.IsFalse(Tri.isEquilateral());
            Assert.IsFalse(Tri.isIsosceles());
        }

        [TestMethod]
        public void triangleConstructorTest3()          //Testar skapa en triangel med 3 punkter.
        {
            Point a = new Point(2, 2);                  //De kordinatererna som finns bildar en giltig oliksidig triangel
            Point b = new Point(4, 6);
            Point c = new Point(10, 12);
            Triangle Tri = new Triangle(new Point[] { a, b, c });
            Assert.IsTrue(Tri.isScalene());
            Assert.IsFalse(Tri.isEquilateral());
            Assert.IsFalse(Tri.isIsosceles());
        }




















        ////Vet ej om dessa test är nödvändiga
        //[TestMethod]
        //[ExpectedException(typeof(IndexOutOfRangeException))]
        //public void triangleConstructor_Test_4_Less_Than_3_Points()       //Testar att skapa en triangel med fler än 3 punkter. Vet ej om detta är ett nödvändigt test
        //{
        //    new Triangle(new[] { new Point(0, 0), new Point(1, 1) });
        //}


        //[TestMethod]
        //[ExpectedException(typeof(IndexOutOfRangeException))]           //Testar att skapa en triangel med två stycken identiska punkter. Testar att undantag kastas.
        //public void triangleConstructorTest_5_Two_Identical_Points()
        //{
        //    new Triangle(new[] { new Point(1, 1), new Point(1, 1) });
        //}


        //[TestMethod]
        //[ExpectedException(typeof(NullReferenceException))]             //Testar att skapa en triangel där punkterna har värdet null.
        //public void triangleConstructorTest_6_Null_Points()
        //{
        //    Point[] i = null;
        //    Triangle target = new Triangle(i);
        //}

        //[TestMethod]
        //[ExpectedException(typeof(IndexOutOfRangeException))]                  //Testar att skapa en tom array.
        //public void triangleConstructorTest_7_Empty_Array()
        //{
        //    new Triangle(new Point[] { });
        //}
    }
}
