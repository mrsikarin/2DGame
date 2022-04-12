using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManage : MonoBehaviour
{
    public Health _HP;
    public Text t_hp;
    public Slider _slidHP;

    // Start is called before the first frame update
    void Start()
    {
        _slidHP.maxValue  = _HP.HP;
    }

    // Update is called once per frame
    void Update()
    {
        if(_HP.HP <= 0){
            SceneManager.LoadScene("GameOver");
        }
        t_hp.text = "HP : " + _HP.HP;
        _slidHP.value =_HP.HP;
    }
}
