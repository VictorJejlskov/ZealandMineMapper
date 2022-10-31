using SpeedTrapREST.Models;

namespace SpeedTrapREST.Managers
{
    public class SpeedTrapsManager
    {
        private static List<SpeedTrap> _records = new List<SpeedTrap>()
        {
            new SpeedTrap(){SensorName = "VictorsSpeedTrap", Speed = 20 },
            new SpeedTrap(){SensorName = "VictorsSpeedTrap", Speed = 25 },
            new SpeedTrap(){SensorName = "VictorsSpeedTrap", Speed = 32 },
            new SpeedTrap(){SensorName = "VictorsSpeedTrap", Speed = 52 },
        };
        public List<SpeedTrap> speedTraps() => _records;
    }
}
