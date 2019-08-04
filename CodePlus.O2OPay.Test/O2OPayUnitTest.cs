using System;
using CodePlus.O2OPay.Core;
using Xunit;
using Shouldly;

namespace CodePlus.O2OPay.Test
{
    public class O2OPayUnitTest
    {
        [Fact]
        public void DefaultPay()
        {
            var client =new O2OPayDefaultClient("YOUR ID", "YOUR KEY");
            var result = client.DefaultPay(_o2OPayInput);
            result.ShouldNotBe(null);
        }

        [Fact]
        public void CustomPay()
        {
            var client = new O2OPayDefaultClient("YOUR ID", "YOUR KEY", "https://data.020zf.com/index.php?s=/api/pp/index_show.html");
            var result = client.CustomPay(_o2OPayInput);
            result.ShouldNotBe(null);
        }

        [Fact]
        public void ValidKey()
        {
            var client = new O2OPayDefaultClient("YOUR ID", "YOUR KEY", "https://data.020zf.com/index.php?s=/api/pp/debugging.html");
            var result = client.ValidKey(_o2OPayInput);
            result.ShouldNotBe(null);

        }

        private readonly O2OPayInput _o2OPayInput = new O2OPayInput()
        {
            GoodsName = "²âÊÔ",
            Amount = 100,
            NotifyUrl = "https://www.baidu.com",
            OrderId = Guid.NewGuid().ToString("N"),
            ReturnUrl = "https://www.baidu.com",
            Type = PayType.WeChat
        };
    }
}
