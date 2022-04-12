using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public bullets bullets;
    public float Speed;
    public IsometricCharacterRenderer isoRenderer;
    Quaternion rotate;
    public int _Damage;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        setAngle();
    }
    public void Shooting()
    {


        var obj = Instantiate(bullets, transform.position, Quaternion.identity);
        //Quaternion rt = Vector2.Angle(dir,transform.position);
        obj.transform.rotation = rotate;
        obj.GetComponent<bullets>().Speed = Speed;
        obj.GetComponent<bullets>()._Damage =_Damage;
        //obj.GetComponent<Rigidbody2D>().AddForce(Speed * obj.transform.up);
        Destroy(obj.gameObject,0.8f);

    }

    public void setAngle()
    {
        if (isoRenderer.lastDirection == 0)
        {
            rotate = Quaternion.Euler(0, 0, 0);
        }
        else if (isoRenderer.lastDirection == 1)
        {
            rotate = Quaternion.Euler(0, 0, 45);
        }
        else if (isoRenderer.lastDirection == 2)
        {
            rotate = Quaternion.Euler(0, 0, 90);
        }
        else if (isoRenderer.lastDirection == 3)
        {
            rotate = Quaternion.Euler(0, 0, 135);
        }
        else if (isoRenderer.lastDirection == 4)
        {
            rotate = Quaternion.Euler(0, 0, 180);
        }
        else if (isoRenderer.lastDirection == 5)
        {
            rotate = Quaternion.Euler(0, 0, -135);
        }
        else if (isoRenderer.lastDirection == 6)
        {
            rotate = Quaternion.Euler(0, 0, -90);
        }
        else if (isoRenderer.lastDirection == 7)
        {
            rotate = Quaternion.Euler(0, 0, -45);
        }
    }
}
