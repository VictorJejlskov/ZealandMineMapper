namespace ClockV10
{
    public class Clock
    {
        private int _currHour;
        private int _currMinute;


        public Clock()
        {
            _currHour = 12;
            _currMinute = 00;
        }
        public int CurrHour
        {
            get { return _currHour; }
        }

        public int CurrMinute
        {
            get { return _currMinute; }
        }

        public void AddHour()
        {
            _currHour = _currHour+1;
            if (_currHour == 24)
            {
                _currHour = 0;
            }
        }

        public void AddMinute()
        {
            _currMinute = _currMinute + 1;
            if (_currMinute == 61)
            {
                AddHour();
                _currMinute = 0;
            }
        }

        public void ShowClock()
        {

        }
    }
}