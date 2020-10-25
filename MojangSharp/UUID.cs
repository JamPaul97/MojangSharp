using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojangSharp
{
    public struct UUID
    {
        private string uuid;
        public UUID(string value)
        {
            if (value.Length != 32)
                throw new Exceptions.UUIDException("Invalid UUID", "UUID is a 32-char long string");
            this.uuid = value;
        }
        public static implicit operator string(UUID uuid)
        {
            return uuid.uuid;
        }
        public static implicit operator UUID(string str)
        {
            return new UUID(str);
        }
    }
}
