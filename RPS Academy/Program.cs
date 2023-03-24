namespace RPS_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var numOfPlayers = SelectionMethods.NumPlayersPicker();
            SelectionMethods.EnterClear();
            var player1 = new Player();
            switch (numOfPlayers)
            {
                case 1:
                    player1.Name = Player.NameGetter();
                    var opponentSelected = Opponent.OpponentSelecter(player1.Name);
                    SelectionMethods.WinPointSetter(opponentSelected);
                    
                    break;

                default:
                    break;
            }    
        }
    }
}