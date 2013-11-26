using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTri
{
    [TestClass]
    public class TriangleUnitTest
    {

         //Equilateral och Scalene har blivit ihopblandade, det är anledningen till att de två testen failar
        [TestMethod]
        public void isIsoscelesTest()       //Likbent, 2 stycken lika sidor.
        {
            Triangle Tri = new Triangle(1, 2, 1);
            Assert.IsTrue(Tri.isIsosceles());
            Assert.IsFalse(Tri.isScalene());
            Assert.IsFalse(Tri.isEquilateral());
        }

        [TestMethod]
        public void isEquilateralTest()     //Liksidig, alla sidor är lika.
        {
            Triangle Tri = new Triangle(1.0, 1.0, 1.0);
            Assert.IsTrue(Tri.isEquilateral());
            Assert.IsFalse(Tri.isScalene());
            Assert.IsFalse(Tri.isIsosceles());
        }

        [TestMethod]
        public void isScaleneTest()             //Oliksidig, alla sidor är olika.
        {
            Triangle Tri = new Triangle(3, 4, 5);
            Assert.IsTrue(Tri.isScalene());
            Assert.IsFalse(Tri.isEquilateral());
            Assert.IsFalse(Tri.isIsosceles());
        }

        [TestMethod]
        public void triangleConstructorTest()       //Det som ligger i parametrarna i point är koordinater
        {
            Point a = new Point(2, 2);
            Point b = new Point(4, 6);
            Point c = new Point(10, 12);
            Triangle Tri = new Triangle(a, b, c);
            Assert.IsTrue(Tri.isScalene());
            Assert.IsFalse(Tri.isEquilateral());
            Assert.IsFalse(Tri.isIsosceles());
        }

        [TestMethod]
        public void triangleConstructorTest2()      //Testar arraykonstruktorn genom att skicka in 3 värden i arrayen
        {
            Triangle Tri = new Triangle(new double[] {3, 4, 5});    
            Assert.IsTrue(Tri.isScalene());
            Assert.IsFalse(Tri.isEquilateral());
            Assert.IsFalse(Tri.isIsosceles());
        }

        [TestMethod]
        public void triangleConstructorTest3()
        {
            Point a = new Point(2, 2);
            Point b = new Point(4, 6);
            Point c = new Point(10, 12);
            Triangle Tri = new Triangle(new Point[] { a, b, c });
            Assert.IsTrue(Tri.isScalene());
            Assert.IsFalse(Tri.isEquilateral());
            Assert.IsFalse(Tri.isIsosceles());
        }

    }
}
