using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MojangSharp
{
    public static class Web
    {
        //600 requests per 10 minutes
        public static UUID UsernameToUUID(Username user)
        {
            //https://api.mojang.com/users/profiles/minecraft/<username>?at=<timestamp>
            string url = "https://api.mojang.com/users/profiles/minecraft/" + user;
            string re = new WebClient().DownloadString(url);
            return new UUID(Newtonsoft.Json.JsonConvert.DeserializeObject<JUsernameToUUID>(re).id);
        }
        public static Username[] NameHistory(UUID uuid)
        {
            //https://api.mojang.com/user/profiles/<uuid>/names
            string url = "https://api.mojang.com/user/profiles/" + uuid + "/names";
            string re = new WebClient().DownloadString(url); List<Username> result = new List<Username>();
            var c = Newtonsoft.Json.JsonConvert.DeserializeObject<JNameHistory[]>(re);
            foreach (var x in c)
                result.Add(new Username(x.name));
            return result.ToArray();
            
        }
        private class JUsernameToUUID
        {
            public string id;
            public string name;
        }
        private class JNameHistory
        {
            public string name;
            public long? changedToAt;
        }
        private class JProfile
        {
            public string id;
            public string name;
            public JProperty[] properties;
            public class JProperty
            {
                public string name;
                public string value;
                public string signature;
            }
        }
    }
}
