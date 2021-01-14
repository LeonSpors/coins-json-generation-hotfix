namespace CoinsGenerator.Models
{
    public class Coin
    {
        public string symbol { get; set; }
        public string longoffset { get; set; }
        public string shortoffset { get; set; }
        public string lickvalue { get; set; }
        public bool var_enabled { get; set; }
        public bool var_staticList { get; set; }
        public bool var_whiteList { get; set; }
        public bool var_blackList { get; set; }
        public string tmp_onboarded { get; set; }
        public string tmp_color { get; set; }
    }
}
