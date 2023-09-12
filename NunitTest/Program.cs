using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTest
{
    internal class Program
    {
 public static string SignIn(string userName, string userPwd)
        {
            string msg;
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(userPwd))
            {
                msg = "user name and password must not be null";

            }
            else
            {
                if ((userName == "sam") && (userPwd == "sam@1256@1256"))
                {
                    msg = "SignIn success";

                }
                else
                {
                    msg = "Invalid Credential";
                }
            }
            return msg;
        }
        static void Main(string[] args)
        {
        }
    }
}
