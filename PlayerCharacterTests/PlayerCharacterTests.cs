using NUnit.Framework;
using NUnit.Framework.Internal;
using System.Collections.Generic;


namespace PlayerCharacterTests
{
    [TestFixture]
    public class PlayerCharacterTests
    {


        [Test]
        public void ShouldIncreaseHeathAfterSleeping_returnTrue()
        {
            var stu = new PlayerCharacter.PlayerCharacter {Health = 100};
            stu.Sleep();

            Assert.That(stu.Health, Is.GreaterThan(100));
        }

        [Test]
        public void ShouldIncreaseHeathAfterSleeping_InRange()
        {
            var stu = new PlayerCharacter.PlayerCharacter { Health = 100 };
            stu.Sleep();

            Assert.That(stu.Health, Is.InRange(101, 200));
        }

        //Also available:
        //  Is.GreaterThanOrEqualTo()
        //  Is.LessThan()
        //  Is.LessThanOrEqualTo()


        // test for random generated name
        [Test]
        public void ShouldHaveDefaultRandomGeneratedName()
        {
            var stu = new PlayerCharacter.PlayerCharacter();
            Assert.That(stu.Name, Is.Not.Empty);
        }



        [Test]
        public void ShouldNotHaveNickName() 
        {
            var stu = new PlayerCharacter.PlayerCharacter();
            Assert.That(stu.NickName, Is.Null);
        }

        [Test]
        public void ShouldBeNewbie()
        {
            var stu = new PlayerCharacter.PlayerCharacter();
            Assert.That(stu.IsNoob, Is.True);
        }

        ////////////// test to check the weapons//////////////

        [Test]
        public void ShouldHaveNoEmptyDeaultWeapons()
        {
            var stu = new PlayerCharacter.PlayerCharacter();
            Assert.That(stu.Weapons, Is.All.Not.Empty);
        }


        [Test]
        public void ShouldHaveALongBow()
        {
            var stu = new PlayerCharacter.PlayerCharacter();
            Assert.That(stu.Weapons, Contains.Item("Long bow"));
        }


        [Test]
        public void ShouldHaveAtLeastOneKingSword()
        {
            var stu = new PlayerCharacter.PlayerCharacter();

            Assert.That(stu.Weapons, Has.Some.Contains("sword"));

        }

        [Test]
        public void ShouldHaveTwoBows()
        {
            var stu = new PlayerCharacter.PlayerCharacter();

            Assert.That(stu.Weapons, Has.Exactly(2).EndsWith("bow"));

        }


        [Test]
        public void ShouldHaveNotMoreThanOneTypeOfAGivenWeapon()
        {
            var stu = new PlayerCharacter.PlayerCharacter();

            Assert.That(stu.Weapons, Is.Unique);

        }

        [Test]
        public void CheckForStaffOfWander_ReturnTrue()
        {
            var stu = new PlayerCharacter.PlayerCharacter();

            Assert.That(stu.Weapons,Has.None.EqualTo("staff of wander"));

        }


        [Test]
        public void ShouldHaveAllTheExpectedWeapon_ReturnTrue()
        {
          var stu = new PlayerCharacter.PlayerCharacter();

          var expectedWeapons = new List<string>()
            {
                "Short sword",
                "Short bow",
                "Long bow"

            };

            Assert.That(stu.Weapons, Is.EquivalentTo(expectedWeapons));

        }


        // checking for reference equality 

        [Test]
        public void ReferenceEqualityDemo_ReturnFalse()
        {
            var player1 = new PlayerCharacter.PlayerCharacter();
            var player2 = new PlayerCharacter.PlayerCharacter();


            //Assert.That(player1, Is.SameAs(player2)); // this test should fail

            var player3 = player1;
            Assert.That(player1, Is.SameAs(player3)); // this test should pass


        }







    }
}
