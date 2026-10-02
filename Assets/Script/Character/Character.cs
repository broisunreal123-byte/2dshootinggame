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
    private float lastPoisonTick = -999;
    private int poisonDamagePerTick;
    protected bool isFrozen;
    private float frozenDuration;


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

        if (isFrozen)
        {
            Debug.Log("the player is now frozen!");
            if (Time.time >= frozenDuration)
            {
                isFrozen = false;
                Debug.Log("Player is no longer frozen!");
            }
        }
        else
        {
        }
            


    }
    public void ApplyFrozen(float duration)
    {
        isFrozen = true;
        frozenDuration = duration + Time.time;
    }
    public void ApplyPoison(float duration, int dmgPerTick)
    {
        poisonDuration = duration + Time.time;
        poisonDamagePerTick = dmgPerTick;
        isPoisoned = true;
    }

    public virtual void TakeDamage(int dmg)
    {
        hp -= dmg;
        HealthManager.Instance.UpdateHealthUI(hp);
        Debug.Log("You deal " + dmg + " dmg");
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
