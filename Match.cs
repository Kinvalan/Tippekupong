namespace Tippekupong
{
    class Match
    {
        /*
        Å skrive objekt-variablene "_enVariabel" for private og "EnVariabel" for public,
        er vanlige praksiser for å indikere tilgangsnivået til en variabel i C#.
        */

        private readonly string _bet;
        private int _homeGoals;
        private int _awayGoals; 
        public bool IsRunning { get; private set; }


        public Match(string bet)
        {
            _bet = bet;
            IsRunning = true;
        }

        public void AddGoal(bool isHomeTeam)
        {
            if (isHomeTeam) _homeGoals++;
            else _awayGoals++;
        }

        public bool IsBetCorrect()
        {
            var result = _homeGoals == _awayGoals ? "U" : _homeGoals > _awayGoals ? "H" : "B";
            return _bet.Contains(result);
        }

        public void Stop()
        {
            IsRunning = false;
        }

        public string GetScore()
        {
            return _homeGoals + "-" + _awayGoals;
        }
    }
}  

