using System;

abstract class LivingBeing
{
    private int Health;

    public virtual void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health <= 0)
        {
            Console.WriteLine("Я умер");
        }
    }
}

class Wombat : LivingBeing
{
    public int Armor{ get; private set; }

    public override void TakeDamage(int damage)
    {
        damage -= damage - Armor;
        base.TakeDamage(damage);
    }
}

class Human : LivingBeing
{
    public int Agility{ get; private set; }

    public override void TakeDamage(int damage)
    {
        damage -= damage / Agility;
        base.TakeDamage(damage);
    }
}