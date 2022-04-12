using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyType1 : MonoBehaviour
{
    public float speed;
    public float distanceRate;
    public float attackRate;
    public float attackTimer;
    public Transform target;
    public Animator _anime;
    Rigidbody2D rb;
    public int _Damage;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(target == null){
            return;
        }
        turn();
        attackTimer += 1.0f * Time.deltaTime;
        if (Vector2.Distance(transform.position, target.position) <= distanceRate)
        {
            if (Vector2.Distance(transform.position, target.position) <= attackRate)
            {
                if(attackTimer >= attackRate){
                attackTimer = 0.0f;
                Attack();
                }
            }
            else
            {
                followPlayer();
            }

        }else{
            transform.position = transform.position;
        }
    }
    public void followPlayer()
    {
        Debug.Log("Walk");
        _anime.SetBool("isWalk", true);
        Vector3 movement = target.position - transform.position;
        movement.Normalize();
        rb.MovePosition(transform.position + (movement * speed * Time.deltaTime));
    }
    private void Attack()
    {

        target.gameObject.GetComponent<Health>().takeDamage(_Damage);


    }
    void turn(){
        if(transform.position.x < target.position.x){
            transform.localScale = new Vector2(0.7f,0.7f);
        }else{
            transform.localScale = new Vector2(-0.7f,0.7f);
        }
    }
}
