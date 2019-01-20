using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tama : MonoBehaviour
{

    private bool attackFlag;

    // Start is called before the first frame update
    void Start()
    {
        attackFlag = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            if (!attackFlag)
            {
                attackFlag = true;
                //  hp = hp - 1;
                main.Instance.attack();
                // Debug.Log("touch");
            }
        } else
        {
            attackFlag = false;
        }
    }
}
