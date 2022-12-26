namespace GU1222E.ChessBoard;

[Serializable]
public class Board
{
    private List<Chess> _whiteChess = new List<Chess>();
    private List<Chess> _blackChess = new List<Chess>();

    public Board()
    {
        _whiteChess.Add(new Pawn
        {
            Position = new Position<int> { X = 0, Y = 1 },
            Type = ChessType.Black
        });
        _whiteChess.Add(new Pawn());
        _whiteChess.Add(new Pawn());
        _whiteChess.Add(new Pawn());
        _whiteChess.Add(new Pawn());
        _whiteChess.Add(new Pawn());
        _whiteChess.Add(new Pawn());
        _whiteChess.Add(new Pawn());
        _whiteChess.Add(new Bishop());
        _whiteChess.Add(new Bishop());
        _whiteChess.Add(new Rook());
        _whiteChess.Add(new Rook());
        _whiteChess.Add(new Knight());
        _whiteChess.Add(new Knight());
        _whiteChess.Add(new King());
        _whiteChess.Add(new Queen());

        _blackChess.Add(new Pawn());
        _blackChess.Add(new Pawn());
        _blackChess.Add(new Pawn());
        _blackChess.Add(new Pawn());
        _blackChess.Add(new Pawn());
        _blackChess.Add(new Pawn());
        _blackChess.Add(new Pawn());
        _blackChess.Add(new Pawn());
        _blackChess.Add(new Bishop());
        _blackChess.Add(new Bishop());
        _blackChess.Add(new Rook());
        _blackChess.Add(new Rook());
        _blackChess.Add(new Knight());
        _blackChess.Add(new Knight());
        _blackChess.Add(new King());
        _blackChess.Add(new Queen());
    }

    public void PrintAllChess()
    {
        foreach (var chess in _whiteChess)
        {
            chess.PrintInfo();
        }
    }
}
