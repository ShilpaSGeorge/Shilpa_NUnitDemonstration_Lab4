﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitDemonstration;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace TestClass
{
    public class TriangleTest
    {
        [TestFixture] 
        public class TriangleTest2
        {
        [Test]
        //Shilpa Triangle Test
        public void ValidTriangle60() 
            
         {
                //Arrange
                int firstAngle = 60;
                int secondAngle = 60;
                int thirdAngle = 60;
                
                string Expected = "The triangle is valid.";
                //Act
                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

                //Assert
                ClassicAssert.AreEqual(Expected, actual);
         }
        }


    }
}
