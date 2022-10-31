using SpeedTrapREST.Models;

namespace SpeedTrapREST.Managers
{
    public class SpeedTrapsManager
    {
        private static int _nextId = 1;
        private static List<SpeedTrap> _records = new List<SpeedTrap>()
        {
            new SpeedTrap(){Id = _nextId++, SensorName = "VictorsSpeedTrap", Speed = 20 },
            new SpeedTrap(){Id = _nextId++, SensorName = "VictorsSpeedTrap", Speed = 25 },
            new SpeedTrap(){Id = _nextId++, SensorName = "VictorsSpeedTrap", Speed = 32 },
            new SpeedTrap(){Id = _nextId++, SensorName = "VictorsSpeedTrap", Speed = 52 },
        };
        public List<SpeedTrap> GetAll() => _records;
        public SpeedTrap GetById(int id)
        {
            return _records.Find(record => record.Id == id);
        }

        public SpeedTrap Create(SpeedTrap record)
        {
            record.Id = _nextId++;
            _records.Add(record);
            return record;
        }

        public SpeedTrap Delete(int id)
        {
            SpeedTrap record = GetById(id);
            if (record == null) throw new NullReferenceException();
            _records.Remove(record);
            return record;
        }
        public SpeedTrap Update(int id, SpeedTrap update)
        {

            SpeedTrap record = GetById(id);
            if (record == null) throw new NullReferenceException("No such record was found");
            record.SensorName = update.SensorName;
            record.Speed = update.Speed;
            return record;
        }
    }
}
