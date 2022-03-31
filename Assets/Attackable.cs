using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Attackable
{

    int CurrentHealth {get;}

    void takeDamage(int damage);

}

