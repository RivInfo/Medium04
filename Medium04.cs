using System;

abstract class LivingBeing
{
    protected int Health;

    public virtual void TakeDamage(int damage)
    {
        if (Health <= 0)
        {
            Console.WriteLine("Я умер");
        }
    }
}

class Wombat : LivingBeing
{
    public int Armor;

    public override void TakeDamage(int damage)
    {
        Health -= damage - Armor;
        base.TakeDamage(damage);
    }
}

class Human : LivingBeing
{
    public int Agility;

    public override void TakeDamage(int damage)
    {
        Health -= damage / Agility;
        base.TakeDamage(damage);
    }
}