using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss : MonoBehaviour
{
    public float timerBtwTp;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = timerBtwTp;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer <= 0)
        {
            //section boss tp
            int plat = Random.Range(0, 4);
            switch (plat)
            {
                case 0:
                    //transform.position = new Vector2(Random.Range("xmin", "xmax"), "valeur de y");
                    break;
                case 1:
                    //tp platform 1
                    break;
                case 2:
                    //tp plat 2
                    break;
                case 3:
                    //tp plat 3
                    break;
            }
            timer = timerBtwTp;
            Debug.Log(plat);
        }
        else
        {
            timer -= Time.deltaTime;
        }
        
                
        
        //section boss end phase

    }
}
