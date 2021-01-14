using System;
using System.Collections.Generic;
using System.IO;
using CoinsGenerator.Models;
using Newtonsoft.Json;

namespace CoinsGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string appPath = AppDomain.CurrentDomain.BaseDirectory;
            string data = File.ReadAllText(Path.Combine(appPath, "varPairs.json"));

            Varpairs pairs = JsonConvert.DeserializeObject<Varpairs>(data);

            var coinList = new List<Models.Coins.Coin>();
            foreach (Coin coin in pairs.coins)
            {
                if(!coin.var_blackList)
                    coinList.Add(new Models.Coins.Coin()
                    {
                        symbol = coin.symbol,
                        lickvalue = coin.lickvalue,
                        longoffset = coin.longoffset,
                        shortoffset = coin.shortoffset
                    });
            }

            string newData = JsonConvert.SerializeObject(coinList);
            string coinsjsonPath = Path.Combine(appPath, "coins.json");

            if (File.Exists(coinsjsonPath))
            {
                if(File.Exists(coinsjsonPath + ".bck"))
                    File.Delete(coinsjsonPath + ".bck");
                File.Move(coinsjsonPath, coinsjsonPath + ".bck");
            }

            File.WriteAllText(coinsjsonPath, newData);
        }
    }
}
