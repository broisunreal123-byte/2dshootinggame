using System;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] protected float hp;
    [SerializeField] protected float dmg;
    public virtual void TakeDamage(float dmg)
    {
        hp -= dmg;
        Debug.Log("It deals " + dmg + "dmg");
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
