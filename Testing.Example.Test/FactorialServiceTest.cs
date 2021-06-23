﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Testing.Example.Test
{
    
   public  class FactorialServiceTest
    {
        [Fact]
        public void TestFactorialZero() {
            //Arrange
            FactorialService service = new FactorialService();
           //Act
            int result = service.Calculate(0);
            //Assert
            Assert.Equal(1, result);
        
        
        }

        [Fact]
        public void TestFactorialFive() {

            FactorialService service = new FactorialService();
            int result = service.Calculate(5);
            Assert.Equal(120, result);
        }



    }
}
