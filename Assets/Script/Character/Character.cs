using System;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] protected int hp;
    [SerializeField] protected int dmg;
    [SerializeField] protected float spawnCooldown;
    protected float lastAttack = -999f;
    private bool isPoisoned;
    private float poisonDuration;
    private float tickInterval = 1f;
    private float lastPoisonTick;
    private int poisonDamagePerTick;

    void Start()
    {
        HealthManager.Instance.UpdateHealthUI(hp);
    }
    protected virtual void Update()
    {
        if (isPoisoned)
        {
            if (Time.time >= lastPoisonTick + tickInterval)
            {
                TakeDamage(poisonDamagePerTick);
                lastPoisonTick = Time.time;
                Debug.Log(poisonDamagePerTick + "poison dmg");
            }
            if (Time.time >= poisonDuration)
            {
                isPoisoned = false;
             
            }
        }
    }
    public void ApplyPoison(float duration, int dmgPerTick)
    {
        poisonDuration = duration + Time.time;
        poisonDamagePerTick = dmgPerTick;
        isPoisoned = true;
        lastPoisonTick = Time.time;
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
