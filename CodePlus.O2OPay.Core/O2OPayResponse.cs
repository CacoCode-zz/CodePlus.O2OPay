using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace CodePlus.O2OPay.Core
{
    [Serializable]
    public class O2OPayResponse
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("data")]
        public O2OPayResponseDetail Data { get; set; }
    }

    [Serializable]
    public class O2OPayResponseDetail
    {
        [JsonProperty("qrcode")] public string QrCode { get; set; }

        [JsonProperty("type")] public string Type { get; set; }

        [JsonProperty("actual_price")] public string ActualPrice { get; set; }

        [JsonProperty("bill_no")] public string BillNo { get; set; }

        [JsonProperty("end_time")] public string EndTime { get; set; }

        [JsonProperty("return_url")] public string ReturnUrl { get; set; }

        [JsonProperty("orderid ")] public string OrderId { get; set; }
    }
}
