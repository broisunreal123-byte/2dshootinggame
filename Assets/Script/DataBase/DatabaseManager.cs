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
    }
    public void saveScore(int score)
    {
        Player savescore = new Player
        {
            Score = score
        };
        _connection.Insert(savescore);
        Debug.Log("Successfully save " + score + " gold");
    }
}