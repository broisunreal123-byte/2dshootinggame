using UnityEngine;
using SQLite4Unity3d;
using System.IO;
using System.Collections.Generic;
using System.Linq; 

public class DatabaseManager : MonoBehaviour
{
    private SQLiteConnection _connection;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
        string dbPath = Path.Combine(Application.persistentDataPath, "practice.db");

        // For now, always overwrite with the StreamingAssets version (dev convenience)
        string sourcePath = Path.Combine(Application.streamingAssetsPath, "practice.db");
        File.Copy(sourcePath, dbPath, true);

        _connection = new SQLiteConnection(dbPath);

        List<Player> players = _connection.Table<Player>().ToList();
        foreach (var p in players)
        {
            Debug.Log(p.Id + " - " + p.Score);
        }
    }
}