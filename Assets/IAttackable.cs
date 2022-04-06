using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAttackable
{
    int currentHealth { get; }

    void takeDamage(int damage);
}
