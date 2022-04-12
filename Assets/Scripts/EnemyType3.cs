using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyType3 : MonoBehaviour
{
    public float speed;
    public float SpeedBullet;
    public float attackRate;
    public float attackTimer;
    public Transform target;
    public Animator _anime;
    Rigidbody2D rb;
    public int _Damage;
    public GameObject bullets;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            return;
        }
        turn();
        attackTimer += 1.0f * Time.deltaTime;

        if (Vector2.Distance(transform.position, target.position) <= attackRate)
        {
            if (attackTimer >= attackRate)
            {
                attackTimer = 0.0f;
                Attack();
            }
        }

    }
    private void Attack()
    {
        Vector3 dir = target.position - transform.position;
        dir.Normalize();
        var obj = Instantiate(bullets, transform.position, Quaternion.identity);
        obj.GetComponent<BulletsEnemy>().dir = dir;
        obj.GetComponent<BulletsEnemy>().Speed = SpeedBullet;
        obj.GetComponent<BulletsEnemy>()._Damage = _Damage;
    }
    void turn()
    {
        if (transform.position.x < target.position.x)
        {
            transform.localScale = new Vector2(0.7f, 0.7f);
        }
        else
        {
            transform.localScale = new Vector2(-0.7f, 0.7f);
        }
    }
}
