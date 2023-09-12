using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTest
{
    [TestFixture]
    internal class UserAuthenticator
    {
        [Test]
        public void SigninTest()
        {
            string empResult = "user name and password must not be null";
            string failResult = "Invalid Credential";
            string sResult = "SignIn success";
            Assert.AreEqual(empResult, Program.SignIn(null, null));
            Assert.AreEqual(empResult, Program.SignIn("", ""));
            Assert.AreEqual(failResult, Program.SignIn("ravi", "ravi@123"));
            Assert.AreEqual(sResult, Program.SignIn("sam", "sam@1256@1256"));

        }
    }
}
