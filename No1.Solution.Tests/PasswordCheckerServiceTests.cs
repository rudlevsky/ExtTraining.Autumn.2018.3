using No1.Solution.Repositories;
using NUnit.Framework;

namespace No1.Solution.Tests
{
    [TestFixture]
    public class PasswordCheckerServiceTests
    {
        [Test]
        public void SqlRepositoryTest_UsualFunctionality()
        {
            var service = new PasswordCheckerService(new SqlRepository());

            (bool, string) result = service.VerifyPassword("Password123");
        }

    }
}
