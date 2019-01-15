using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class main : SingletonMonoBehaviour<main>
{

    public SpriteRenderer enemy;
    public Text hitPoint;
    public int hp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hitPoint.text = hp.ToString();
    }

    public void attack()
    {
        hp--;
        Debug.Log("attack");

    }
}
