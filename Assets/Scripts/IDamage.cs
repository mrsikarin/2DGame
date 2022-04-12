using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamage<T>
{
    void takeDamage(T damageTaken);
}