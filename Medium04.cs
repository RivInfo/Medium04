﻿using System;

abstract class LivingBeing
{
    private int _health;

    public void TakeDamage(int damage)
    {
        _health -= CalculateDamage(damage);
        Console.WriteLine(_health);
        if (_health <= 0)
        {
            Console.WriteLine("Я умер");
        }
    }

    protected virtual int CalculateDamage(int damage)
    {
        return damage;
    }
}

class Wombat : LivingBeing
{
    public int Armor{ get; private set; }

    protected override int CalculateDamage(int damage)
    {
        return damage - Armor;
    }
}

class Human : LivingBeing
{
    public int Agility{ get; private set; }

    protected override int CalculateDamage(int damage)
    {
        return damage/ Agility;
    }
}