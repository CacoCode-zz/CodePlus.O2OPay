using System;
using CodePlus.O2OPay.Core;
using Xunit;

namespace CodePlus.O2OPay.Test
{
    public class O2OPayUnitTest
    {
        [Fact]
        public void DefaultPay()
        {
            var client =new O2OPayDefaultClient("JHAMPVA0BXE9T36V", "PFFHTWWK97BE9YD5MQH73AMPZ0K7P7SO");
            var result = client.DefaultPay(_o2OPayInput);
            return;
        }

        [Fact]
        public void CustomPay()
        {
            var client = new O2OPayDefaultClient("JHAMPVA0BXE9T36V", "PFFHTWWK97BE9YD5MQH73AMPZ0K7P7SO", "https://data.020zf.com/index.php?s=/api/pp/index_show.html");
            var result = client.CustomPay(_o2OPayInput);
            return;
        }

        [Fact]
        public void ValidKey()
        {
            var client = new O2OPayDefaultClient("JHAMPVA0BXE9T36V", "PFFHTWWK97BE9YD5MQH73AMPZ0K7P7SO", "https://data.020zf.com/index.php?s=/api/pp/debugging.html");
            var result = client.ValidKey(_o2OPayInput);
            return;
        }

        private readonly O2OPayInput _o2OPayInput = new O2OPayInput()
        {
            GoodsName = "����",
            Amount = 99,
            NotifyUrl = "https://www.baidu.com",
            OrderId = Guid.NewGuid().ToString("N"),
            ReturnUrl = "https://www.baidu.com",
            Type = PayType.WeChat
        };
    }
}