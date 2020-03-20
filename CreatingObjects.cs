using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace OopDetails
{
    public class CreatingObjects
    {
        [Fact]
        public void InitializingAnObject()
        {
            var bob = new Person()
            {
                Name = "Bob Smith"
            };
            Assert.Equal("Bob Smith", bob.Name);

        }
    }
}
