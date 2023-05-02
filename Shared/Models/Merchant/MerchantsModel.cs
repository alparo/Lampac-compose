﻿using Lampac.Models.Merchant.LtcWallet;

namespace Lampac.Models.Merchant
{
    public class MerchantsModel
    {
        public int accessCost { get; set; }

        public int accessForMonths { get; set; } = 12;

        public int allowedDifference { get; set; }

        public B2payConf B2PAY { get; set; } = new B2payConf();

        public CryptoCloudConf CryptoCloud { get; set; } = new CryptoCloudConf();

        public FreekassaConf FreeKassa { get; set; } = new FreekassaConf();

        public LtcWalletConf LtcWallet { get; set; } = new LtcWalletConf();
    }
}
