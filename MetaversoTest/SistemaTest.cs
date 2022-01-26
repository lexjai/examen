using System;
using Xunit;

namespace Metaverso
{

    public class SistemaTest
    {

        [Fact]
        public void Multiplo5Test()
        {
            // Given
            var sis = new Sistema();
            var param = 5;
            var esperado = "Verso";
            // When
            var result = sis.multiplo(param);
            // Then
            Assert.Equal(result, esperado);
        }
        [Fact]
        public void Multiplo3Test()
        {
            // Given
            var sis = new Sistema();
            var param = 3;
            var esperado = "Meta";
            // When
            var result = sis.multiplo(param);
            // Then
            Assert.Equal(result, esperado);
        }
        [Fact]
        public void SinMultiploTest()
        {
            // Given
            var sis = new Sistema();
            var param = 11;
            var esperado = "11";
            // When
            var result = sis.multiplo(param);
            // Then
            Assert.Equal(result, esperado);
        }
          [Fact]
        public void igualMultiploTest()
        {
            // Given
            var sis = new Sistema();
            var param = 15;
            var esperado = "Metaverso";
            // When
            var result = sis.multiplo(param);
            // Then
            Assert.Equal(result, esperado);
        }

        [Fact]
        public void ArrayMultiploTest()
        {
            // Given
            var sis = new Sistema();
            int[] param = {5,3,11,15};
            var esperado = " Verso Meta 11 Metaverso";
            // When
            var result = sis.multiplosArray(param);
            // Then
            Assert.Equal(result, esperado);
        }
    }
}