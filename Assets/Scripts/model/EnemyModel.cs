using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyModel {
    private int damage;
    private bool collide;
    private float movementSpeed;

    public int getDamage()
    {
        return damage;
    }
    public void setDamage(int damage)
    {
        this.damage = damage;
    }
    public bool isCollide()
    {
        return collide;
    }
    public void setCollide(bool collide)
    {
        this.collide = collide;
    }
    public float getMovementSpeed()
    {
        return movementSpeed;
    }
    public void setMovementSpeed(float movementSpeed)
    {
        this.movementSpeed = movementSpeed;
    } 
}
