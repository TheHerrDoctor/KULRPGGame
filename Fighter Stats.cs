using UnityEngine;

public class FighterStats : MonoBehaviour 
{
    public Stat maxHealth; 
    public int currentHealth;
    public Stat atack;
    public Stat defence;
    public Stat magic;
    public Stat resistance;
    public Stat speed;
    public Stat move;
    //stat jest prywatn� klas� w tym folderze, powinno dzia���, nie dzia�a, trzyma�em si� tutorialu
    void Awake() 
    {
        currentHealth = maxHealth;
    }

    void Update() 
    { //Tylko do Debugowania, trzeba potem usun��
        if (Input.GetKeyDown(KeyCode.P))
        {
            TakeDamage(3);
        }

        if (Input.GetKeyDown(KeyCode.l))
        {
            TakeMagicDamage(4);
        }

    }

    public void TakeDamage(int damage) 
    {
        damage -= defence;
        damage = Mathf.Clamp(damage, 0, int.MaxValue);
        currentHealth -= damage;
        Debug.Log(transform.name + " takes " + damage + " damage.");

        if (currentHealth <=0) 
        {
            FighterDown();
        }
    }
    public void TakeMagicDamage(int damage)
    {
        damage -= resistance;
        damage = Mathf.Clamp(damage, 0, int.MaxValue);
        currentHealth -= damage;
        Debug.Log(transform.name + " takes " + damage + " damage.");

        if (currentHealth <= 0)
        {
            FighterDown();
        }
    }
    public virtual void FighterDown() 
    {
        //taki catch-all, trzeba b�dzie zrobi� override na bohater�w i przeciwnik�w
        Debug.Log(transform.name + " is down!");
    }
}
