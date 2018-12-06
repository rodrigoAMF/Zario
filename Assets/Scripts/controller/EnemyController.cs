using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController {
    EnemyModel enemyModel;

    public EnemyController()
    {
        enemyModel = new EnemyModel();
    }

    public int getDamage()
    {
        return enemyModel.getDamage();
    }
    public void setDamage(int damage)
    {
        enemyModel.setDamage(damage);
    }
    public bool isCollide()
    {
        return enemyModel.isCollide();
    }
    public void setCollide(bool collide)
    {
        enemyModel.setCollide(collide);
    }
    public float getMovementSpeed()
    {
        return enemyModel.getMovementSpeed();
    }
    public void setMovementSpeed(float movementSpeed)
    {
        enemyModel.setMovementSpeed(movementSpeed);
    }
}
