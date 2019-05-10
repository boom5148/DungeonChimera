using DungeonChimera.DataAccess;
using DungeonChimera.Models.Characters;
using NUnit.Framework;

namespace DungeonChimera.Tests.UtilTests.DataAccess
{
    [TestFixture]
    class CharacterDataAccessTests
    {
        private CharacterDataAccess _CaracterDataAccessor;
        [SetUp]
        public void Setup()
        {
            _CaracterDataAccessor = new CharacterDataAccess();
        }

        [Test]
        public void CanCreateANewCharacter()
        {
            // Given
            Character NewCharacter = new Character();
            // When
            _CaracterDataAccessor.Write(NewCharacter);
            Assert.Pass();
        }
    }
}
