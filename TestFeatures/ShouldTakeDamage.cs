using System;
using Xunit;
using FeaturesData;

namespace TestFeatures
{
    public class ShouldTakeDamage
    {
        // This testing class demostrate how to provide array data to TDD test methods
        [Theory]
        [MemberData(nameof(ProvideDataForSoldeirTakeDamage.TestData),
            MemberType = typeof(ProvideDataForSoldeirTakeDamage))]
        public void SoldeirTakeDamage(int damage, int expectedHeath)
        {
            Soldeir soldeir = new Soldeir();

            soldeir.TakeDamage(damage);

            Assert.Equal(expectedHeath, soldeir._Health);
        }
    }
}
