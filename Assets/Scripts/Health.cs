using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int HP;
    void Update()
    {
        
    }
        public void takeDamage(int _Damage)
    {
        HP -= _Damage;
        if(HP <= 0){
            Destroy(gameObject);
        }
        
    }
}
