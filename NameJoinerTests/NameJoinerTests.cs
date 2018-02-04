using NUnit.Framework;

namespace NameJoinerTests
{
    [TestFixture]
    public class NameJoinerTests
    {


        [Test]
        public void ShouldJoinName()
        {
        var stu = new NameJoiner.NameJoiner();
            var fullName = stu.Join("Joao", "Romao");
            Assert.That(fullName, Is.EqualTo("Joao Romao"));

        }


        [Test]
        public void ShouldJoinNames_CaseInsensitiveAsseertDemo()
        {
            var stu = new NameJoiner.NameJoiner();
            var fullName = stu.Join("Joao", "Romao");
            Assert.That(fullName, Is.EqualTo("JOAO ROMAO").IgnoreCase);
        }


        [Test]
        public void ShouldJoinNames_NotEqualDemo()
        {
            var stu = new NameJoiner.NameJoiner();
            var fullName = stu.Join("Joao", "Romao");
            Assert.That(fullName, Is.Not.EqualTo("Joao Mario"));
        }



    }
}
