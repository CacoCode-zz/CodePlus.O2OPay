using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace CodePlus.O2OPay.Core
{
    public class HttpRequestUtil
    {
        public static async Task<string> PostAsync(string url, Dictionary<string, string> data)
        {
            var client = new HttpClient();
            var content = new FormUrlEncodedContent(data);
            var respMsg = await client.PostAsync(url, content);
            var msgBody = await respMsg.Content.ReadAsStringAsync();
            return msgBody;
        }
    }
}
