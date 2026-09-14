using SQLite4Unity3d;
public class PlayerInfo
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string Name { get; set; }
}
