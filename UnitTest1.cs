using AutoFixture;
using AutoFixture.Xunit2;
using Moq;
using System;
using Xunit;
using Xunit.Abstractions;

namespace TestProject1
{
    public class UnitTest1
    {
        private readonly ITestOutputHelper _output;

        public UnitTest1(ITestOutputHelper output)
        {
            _output = output;
        }

        //[Theory, AutoMoqData]
        [Theory, AutoData]
        //[Theory]
        //[InlineData("testStr", null)]
        public void Test1(string inStr, [Frozen] Mock<IEquatable<string>> inStrArr)
        {
            var fixture = new Fixture();//.Create<string[]>();
            //fixture.Freeze<string[]>();
            var value=fixture.Create<string[]>();

            var fixtureStringArr= new Fixture().Create<string[]>();

            //var testString = new Mock<string[]>();

            _output.WriteLine(string.Join(" , ",fixture));
            _output.WriteLine(string.Join(" , ", value));
            _output.WriteLine(string.Join(" , ", fixtureStringArr));

            _output.WriteLine(string.Join(" , ", inStrArr));
            _output.WriteLine(inStr);



            //_output.WriteLine(string.Join(" , ", testString));


        }


    }
}
