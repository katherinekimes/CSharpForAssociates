using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace OopDetails
{
    public class Methods
    {
        [Fact]
        public void OverloadingMethods()
        {
            string fullName = FormatName("Han", "Solo");

            Assert.Equal("Solo, Han", fullName);

            string fullName2 = FormatName("Han", "Solo", "D");

            Assert.Equal("Solo, Han D.", fullName2);

            var fn3 = FormatName(last: "Skywalker", first: "Luke");
            Assert.Equal("Skywalker, Luke", fn3);

            var p = new Person();
            p.Name = "Rey";
            p.IncreaseCreditLimit( 500);
            p.SaveToDatabase(makeBackup: false);
        }

        [Fact]
        public void DoingSomeMath()
        {
            Assert.Equal(10, Add(5, 5));
            Assert.Equal(6, Add(3));
            Assert.Equal(5, Add());
            Assert.Equal(10, Add(b: 8));
           
        }
        [Fact]
        public void Params()
        {
            Assert.Equal(4, Add2(2, 2));
            Assert.Equal(45, Add2(1, 2, 3, 4, 5, 6, 7, 8, 9));
            Assert.Equal(10, Add2(1, 2, 5, 2));
        }


        public int Add2(int a, int b, params int[] rest)
        {
            return a + b + rest.Sum();
        }

        public int Add(int a = 2 , int b = 3)
        {
            return a + b;
        }

        public string FormatName(string first, string last)
        {
            return $"{last}, {first}";
        }

        public string FormatName(string first, string last, string mi)
        {
            return FormatName(first, last) + $" {mi}.";
        }
    }
}
