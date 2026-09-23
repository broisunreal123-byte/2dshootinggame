using SQLite4Unity3d;
public class player
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public int Score { get; set; }
}
