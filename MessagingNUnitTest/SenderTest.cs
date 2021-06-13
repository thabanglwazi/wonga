using NUnit.Framework;
using Sender;

namespace Tests
{
    [TestFixture]

    public class Tests
    {
        [Test]
        public void message_compiled_correctly()
        {
            //arrange
            var send = new Send("thabang", "hello my name is");

            //act
           var result= send.CompileMessage();
            //assert
            Assert.That(result=="hello my name is, thabang");
        }
        [Test]
        public void name_property_test()
        {
            //arrange

            var send = new Send();

            //act
            var result = send.Name = "Thabang";
            //assert
            Assert.That(result == "Thabang");
        }
        [Test]
        public void message_property_test()
        {
            //arrange

            var send = new Send();

            //act
            var result = send.Message = "hello";
            //assert
            Assert.That(result == "hello");
        }


    }
}