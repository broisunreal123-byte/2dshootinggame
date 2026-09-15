using SQLite4Unity3d;
public class Player
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public int Score { get; set; }
}
