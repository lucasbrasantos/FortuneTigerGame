using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTigerGame.Services
{
    public static class UpgradeManager
    {
        private static Dictionary<string, UpgradeData> _upgrades = new Dictionary<string, UpgradeData>();

        public static void SaveUpgradeState(string upgradeName, UpgradeData data)
        {
            _upgrades[upgradeName] = data;
        }

        public static UpgradeData GetUpgradeState(string upgradeName)
        {
            if (_upgrades != null && _upgrades.TryGetValue(upgradeName, out var data))
            {
                return data;
            }
            return null;
        }

    }

    public class UpgradeData
    {
        public int UpgradeLevel { get; set; }
        public int UpgradeCost { get; set; }
        public int UpgradeMultiplier { get; set; }
        public bool IsBuyable { get; set; }
    }
}
