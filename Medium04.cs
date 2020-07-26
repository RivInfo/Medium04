using System;

abstract class LivingBeing
{
    public int Health;
    public abstract void TakeDamage(int damage);

    protected void HelthDetect()
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
        HelthDetect();
    }
}

class Human : LivingBeing
{
    public int Agility;

    public override void TakeDamage(int damage)
    {
        Health -= damage / Agility;
        HelthDetect();
    }
}