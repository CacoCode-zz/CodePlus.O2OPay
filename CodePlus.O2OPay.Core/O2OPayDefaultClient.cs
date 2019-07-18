using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CodePlus.O2OPay.Core
{
    public class O2OPayDefaultClient
    {
        private readonly string _apiGateWay;
        private readonly string _identification;

        private readonly string _token;

        public O2OPayDefaultClient(string identification, string token, string apiGateWay = "https://pay.020zf.com")
        {
            _identification = identification;
            _token = token;
            _apiGateWay = apiGateWay;
        }

        public string DefaultPay(O2OPayInput input)
        {
            var paramDic = BuildBasicParam(input);
            var result = HttpRequestUtil.PostAsync($"{_apiGateWay}", paramDic).Result;
            return result;
        }

        public O2OPayResponse CustomPay(O2OPayInput input)
        {
            var paramDic = BuildBasicParam(input);
            var result = HttpRequestUtil.PostAsync($"{_apiGateWay}", paramDic).Result;
            var response = JsonConvert.DeserializeObject<O2OPayResponse>(result);
            return response;
        }

        public string ValidKey(O2OPayInput input)
        {
            var paramDic = BuildBasicParam(input);
            var result = HttpRequestUtil.PostAsync($"{_apiGateWay}", paramDic).Result;
            //var response = JsonConvert.DeserializeObject<O2OPayResponse>(result);
            return result;
        }

        private Dictionary<string, string> BuildBasicParam(O2OPayInput input)
        {
            var paramDic = new Dictionary<string, string>
            {
                {"identification", _identification},
                {"price", input.Amount.ToString()},
                {"type", ((int) input.Type).ToString()},
                {"notify_url", input.NotifyUrl},
                {"return_url", input.ReturnUrl},
                {"orderid", input.OrderId},
                {"orderuid", input.OrderUId},
                {"goodsname", input.GoodsName}
            };
            paramDic.Add("key", O2OPayUtil.SignParam(paramDic, _token));
            //paramDic.Remove("token");
            return paramDic;
        }
    }
}