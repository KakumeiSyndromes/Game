using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class enemyController : MonoBehaviour
{
    public int hp;
    //public SpriteRenderer hpBer;
    public Text HitPoint;

    private float oneDamage;
    // Start is called before the first frame update
    void Start()
    {
      //  oneDamage = hpBer.transform.localScale.x / hp;
    }

    // Update is called once per frame
    void Update()
    {

        //if (input.touchcount > 0)
        //{
        //    touch touch = input.gettouch(0);

        //    if (touch.phase == touchphase.began)
        //    {
        //        hp = hp - 1;
        //        debug.log("touch");
        //    }

        //    rect rect = hpber.rect;


        //}

        //if (input.getmousebutton(0))
        //{
        //    hp = hp - 1;
        //    main.instance.attack();
        //    debug.log("touch");
        //}



        // hitpoint.text = hp.tostring();

        /*Transform transform = hpBer.transform;

        Vector3 vec = new Vector3(oneDamage * hp, transform.localScale.y, transform.localScale.z);

        transform.localScale = vec;
        */
    }
}
