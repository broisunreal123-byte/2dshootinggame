using System;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] protected int hp;
    [SerializeField] protected int dmg;
    [SerializeField] protected float spawnCooldown;
    protected float lastAttack = -999f;
    void Start()
    {
        HealthManager.Instance.UpdateHealthUI(hp);
    }
    public virtual void TakeDamage(int dmg)
    {
        hp -= dmg;
        Debug.Log("It deals " + dmg + " dmg");
        HealthManager.Instance.UpdateHealthUI(hp);
        if (hp <= 0)
        {
            Die();
        }
    }
    protected void Die()
    {
        gameObject.SetActive(false);
        GameManagerMap2.Instance.showLoseMenu();
    }
}
