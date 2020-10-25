/**     MojangSharp V0.0.0.1
 *          MojangStatus class Ver 0.1
 *          
 *          Last changes : Added full status parsers and check
 *                         Added cache and 5 minutes interval between checks *1
 *          
 *          Comments : *1   -   Currently no way to change the interval of force the check
 * 
 * Last author : JamPaul97 25-10-2020
 */


using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace MojangSharp
{
    public static class Status
    {
        /// <summary>
        /// Enum for Mojang Status
        /// </summary>
        public enum MojangStatus
        {
            /// <summary>
            /// Green color
            /// </summary>
            Good,
            /// <summary>
            /// Yellow color
            /// </summary>
            Problems,
            /// <summary>
            /// Red Color
            /// </summary>
            Down
        }
        const string url = "https://status.mojang.com/check";
        private static List<JStatus> lastStatus = null;
        private static DateTime? lastTimeChecked = null;
        public static MojangStatus MinecraftNet
        {
            get
            {
                check();
                var item = lastStatus.First(x => x.MinecraftNet != null);
                return item.MinecraftNet == "green" ? MojangStatus.Good : item.MinecraftNet == "yellow" ? MojangStatus.Problems : MojangStatus.Down;
            }
        }
        public static MojangStatus SessionMinecraftNet
        {
            get
            {
                check();
                var item = lastStatus.First(x => x.SessionMinecraftNet != null);
                return item.SessionMinecraftNet == "green" ? MojangStatus.Good : item.MinecraftNet == "yellow" ? MojangStatus.Problems : MojangStatus.Down;
            }
        }
        public static MojangStatus AccountMojangCom
        {
            get
            {
                check();
                var item = lastStatus.First(x => x.AccountMojangCom != null);
                return item.AccountMojangCom == "green" ? MojangStatus.Good : item.MinecraftNet == "yellow" ? MojangStatus.Problems : MojangStatus.Down;
            }
        }
        public static MojangStatus AuthserverMojangCom
        {
            get
            {
                check();
                var item = lastStatus.First(x => x.AuthserverMojangCom != null);
                return item.AuthserverMojangCom == "green" ? MojangStatus.Good : item.MinecraftNet == "yellow" ? MojangStatus.Problems : MojangStatus.Down;
            }
        }
        public static MojangStatus SessionserverMojangCom
        {
            get
            {
                check();
                var item = lastStatus.First(x => x.SessionserverMojangCom != null);
                return item.SessionserverMojangCom == "green" ? MojangStatus.Good : item.MinecraftNet == "yellow" ? MojangStatus.Problems : MojangStatus.Down;
            }
        }
        public static MojangStatus ApiMojangCom
        {
            get
            {
                check();
                var item = lastStatus.First(x => x.ApiMojangCom != null);
                return item.ApiMojangCom == "green" ? MojangStatus.Good : item.MinecraftNet == "yellow" ? MojangStatus.Problems : MojangStatus.Down;
            }
        }
        public static MojangStatus TexturesMinecraftNet
        {
            get
            {
                check();
                var item = lastStatus.First(x => x.TexturesMinecraftNet != null);
                return item.TexturesMinecraftNet == "green" ? MojangStatus.Good : item.MinecraftNet == "yellow" ? MojangStatus.Problems : MojangStatus.Down;
            }
        }
        public static MojangStatus MojangCom
        {
            get
            {
                check();
                var item = lastStatus.First(x => x.MojangCom != null);
                return item.MojangCom == "green" ? MojangStatus.Good : item.MinecraftNet == "yellow" ? MojangStatus.Problems : MojangStatus.Down;
            }
        }
        private static void check()
        {
            if (lastTimeChecked == null)
                forceCheck();
            else
            {
                if (DateTime.Now - lastTimeChecked > new TimeSpan(0, 5, 0))
                    forceCheck();
            }
        }
        private static void forceCheck()
        {
            var str = new WebClient().DownloadString(url);
            lastStatus = Newtonsoft.Json.JsonConvert.DeserializeObject<List<JStatus>>(str);
            lastTimeChecked = DateTime.Now;
        }
        private class JStatus
        {
            [JsonProperty("minecraft.net")]
            public string MinecraftNet { get; set; }
            [JsonProperty("session.minecraft.net")]
            public string SessionMinecraftNet { get; set; }
            [JsonProperty("account.mojang.com")]
            public string AccountMojangCom { get; set; }
            [JsonProperty("authserver.mojang.com")]
            public string AuthserverMojangCom { get; set; }
            [JsonProperty("sessionserver.mojang.com")]
            public string SessionserverMojangCom { get; set; }
            [JsonProperty("api.mojang.com")]
            public string ApiMojangCom { get; set; }
            [JsonProperty("textures.minecraft.net")]
            public string TexturesMinecraftNet { get; set; }
            [JsonProperty("mojang.com")]
            public string MojangCom { get; set; }


        }
    }
}
