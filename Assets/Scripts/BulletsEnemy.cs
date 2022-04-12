using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletsEnemy : MonoBehaviour
{
    public Vector3 dir;
    public float Speed;
    public int _Damage;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        transform.position += dir * Speed * Time.deltaTime ;
    }
    private void OnTriggerEnter2D(Collider2D other) {
            if(other.gameObject.tag == "Player"){
            other.GetComponent<Health>().takeDamage(_Damage);
            Destroy(gameObject);
            }else if(other.gameObject.tag != "Enemy")
            {
            Destroy(gameObject);
            }
        
    }
}
