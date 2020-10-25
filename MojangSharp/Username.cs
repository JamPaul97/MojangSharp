using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojangSharp
{
    public struct Username
    {
        private string username;
        public Username(string username)
        {
            this.username = username;
        }
        public static implicit operator string(Username user)
        {
            return user.username;
        }
        public static implicit operator Username(string user)
        {
            return new Username(user);
        }
        public static explicit operator UUID(Username user)
        {
            return Web.UsernameToUUID(user);
        }
    }
}
