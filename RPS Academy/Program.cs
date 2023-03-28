namespace RPS_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var player1Score = 0;
            var selectableOpponents = new List<string> { "Novice Natalie", "Beginner Ben", "Junior Developer Julie", "Intermediate Isaac", "Advanced Amelia", "Senior Developer Sam", "Expert Ethan", "Masterful Morgan", "Guru Giselle", "Visionary Victor", "Legendary Lila" };
            var numOfPlayers = SelectionMethods.NumPlayersPicker();
            SelectionMethods.EnterClear();
            var player1 = new Player();
            switch (numOfPlayers)
            {
                case 1:
                    player1.Name = Player.NameGetter();
                    var opponentSelected = Opponent.OpponentSelecter(player1.Name);
                    var opponent = new Opponent();
                    opponent.Name = selectableOpponents[opponentSelected - 1 ];
                    var opponentScore = 0;
                    player1.WinPoint = Player.WinPointSetter(opponentSelected);
                    while (player1Score < player1.WinPoint && opponentScore < player1.WinPoint)
                    {
                        Battle.ScoreBoard(player1.WinPoint, player1.Name, player1Score, opponent.Name, opponentScore);
                        SelectionMethods.Instructions();
                        var attack = Battle.Player1Attack();
                        var opponentAttack = Battle.OpponentAttack();
                        var resultOfRound = Battle.Dual(opponentAttack, attack);
                        switch (resultOfRound)
                        {
                            case 1:
                                player1Score++;
                                SelectionMethods.EnterClear();
                                Battle.ScoreBoard(player1.WinPoint, player1.Name, player1Score, opponent.Name, opponentScore);
                                var player1Answer = Questions.Question1();
                                switch(player1Answer)
                                {
                                    case 1:
                                        player1Score++;
                                        break;
                                    default:
                                        Console.WriteLine("Your opponent will now attempt the question, good luck...");
                                        SelectionMethods.EnterClear();
                                        Battle.ScoreBoard(player1.WinPoint, player1.Name, player1Score, opponent.Name, opponentScore);
                                        var opponentAnswer_ = Questions.Question1_(opponentSelected);
                                        switch (opponentAnswer_)
                                        {
                                            case 1:
                                                opponentScore++;
                                                break;

                                            default:
                                                break;
                                        }
                                        break;
                                }
                                break;
                            case 0:
                                break;
                            case 2:
                                opponentScore++;
                                SelectionMethods.EnterClear();
                                Battle.ScoreBoard(player1.WinPoint, player1.Name, player1Score, opponent.Name, opponentScore);
                                var opponentAnswer = Questions.Question1_(opponentSelected);
                                switch (opponentAnswer)
                                {
                                    case 1:
                                        opponentScore++;
                                        break;

                                    default:
                                        Console.WriteLine("You now have the opportunity to answer the question for the chance to get an additional point.");
                                        SelectionMethods.EnterClear();
                                        Battle.ScoreBoard(player1.WinPoint, player1.Name, player1Score, opponent.Name, opponentScore);
                                        var player1Answer_ = Questions.Question1();
                                        switch(player1Answer_)
                                        {
                                            case 1:
                                                player1Score++;
                                                break;

                                            default:
                                                break;
                                        }
                                        break;
                                }
                                break;
                            default:
                                break;
                        }
                        SelectionMethods.EnterClear();
                    }
                    break;
                default:
                    break;
            }    
        }
    }
}