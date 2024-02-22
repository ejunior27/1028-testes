using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using _1028_testes;
using FluentAssertions.Types;
using _1028_testes.Services;

namespace _1028_teste.Tests.FluentAssertions
{
    public class FluentAssertionsTests
    {
        [Fact]
        public void Test_String_Should_Be_Equal()
        {
            string esperada = "Hello, world!";
            string resultado = "Hello, world!";

            resultado.Should().Be(esperada, "Hello, world! é a frase esperada");            
        }

        [Fact]
        public void Test_String_Should_Star_With()
        {
            string resultado = "FluentAssertions";

            resultado.Should().StartWith("Fluent");            
        }

        [Fact]
        public void Test_Number_Should_Be_Greater_Than()
        {
            int resultado = 10;

            resultado.Should().BeGreaterThan(5);
            resultado.Should().BeGreaterThanOrEqualTo(10);            
        }

        [Fact]
        public void Test_Number_Should_Be_Close_To()
        {
            double resultado = 3;

            resultado.Should().BeApproximately(4, 1);
        }

        [Fact]
        public void Test_Object_Should_Be_Type_Of()
        {
            var resultado = new Calculadora();

            resultado
                .Should()
                .BeOfType(typeof(Calculadora))
                .And.BeAssignableTo<ICalculadora>();            
        }

        [Fact]
        public void Test_Date_Should_Be_After()
        {
            DateTime resultado = new DateTime(2024, 2, 20);

            resultado.Should().BeAfter(DateTime.MinValue);
            resultado.Should().BeBefore(DateTime.MaxValue);
        }

        [Fact]
        public void Test_Date_Should_Be_Between()
        {
            DateTime resultado = new DateTime(2024, 2, 21);

            resultado
                .Should()
                .BeAfter(DateTime.MinValue)
                .And.BeBefore(DateTime.MaxValue);

            
        }


    }
}
