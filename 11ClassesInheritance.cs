using UnityEngine;

public class ClassesInheritance : MonoBehaviour
{
    void Start()
    {
        Boss boss = new Boss();
        boss.Attack();
        boss.BossAttack();

        Debug.Log("Boss Health: " + boss.health);
        
    }

class Enemy
{
    public int health;
    public int damage = 10;

    public Enemy()
    {
        health = 100;
    }

    public void Attack()
    {
        Debug.Log("Enemy Attacking");
    }
}

class Boss : Enemy
{
    public Boss()
    {
        health = 400;
    }

    public void BossAttack()
    {
        Debug.Log("Boss Attacking");
    }
}

}
