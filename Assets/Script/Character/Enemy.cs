using UnityEngine;

public class Enemy : Character
{
    [SerializeField] protected float spawnCooldown;
    

    protected void regenerate()
    {
        hp +=3;
    }
    
}
