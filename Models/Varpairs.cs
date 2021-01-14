using System.Collections.Generic;

namespace CoinsGenerator.Models
{
    public class Varpairs
    {
        public string botName { get; set; }
        public string maxPairs { get; set; }
        public string maxOpen { get; set; }
        public string openOrderIsolationPercentage { get; set; }
        public string tradingMode { get; set; }
        public string tradePairs { get; set; }
        public bool fundingRateThreshold { get; set; }
        public string maxFundingRate { get; set; }
        public string tradingAge { get; set; }
        public string refreshTime { get; set; }
        public string lhpcKey { get; set; }
        public List<Coin> coins { get; set; }
    }
}
