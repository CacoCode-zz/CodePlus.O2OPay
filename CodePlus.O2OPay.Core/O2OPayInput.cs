namespace CodePlus.O2OPay.Core
{
    public class O2OPayInput
    {
        /// <summary>
        ///     商户交易单号
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        ///     商户客户号
        /// </summary>
        public string OrderUId { get; set; }

        /// <summary>
        ///     商品名称
        /// </summary>
        public string GoodsName { get; set; }

        /// <summary>
        ///     交易金额(单位为分)
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        ///     通知回调网址
        /// </summary>
        public string NotifyUrl { get; set; }

        /// <summary>
        ///     跳转网址
        /// </summary>
        public string ReturnUrl { get; set; }

        /// <summary>
        ///     支付渠道
        /// </summary>
        public PayType Type { get; set; }
    }
}