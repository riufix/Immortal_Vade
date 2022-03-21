using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recall : MonoBehaviour
{
    public bool isRecalling = false;
    public float recordTime = 5f;
    List<PointInTime> PointsInTime;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        PointsInTime = new List<PointInTime>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            startRecalling();
        }  
        if (Input.GetKeyUp(KeyCode.Return))
        {
            stopRecalling();
        }  
    }

    private void FixedUpdate()
    {
        if (isRecalling)
        {
            //Recall();
        }
        else
        {
            Record();
        }

    }

    void Record()
    {
        if(PointsInTime.Count > Mathf.Round(recordTime / Time.fixedDeltaTime))
        {
            PointsInTime.RemoveAt(PointsInTime.Count - 1);
        }
        PointsInTime.Insert(0, new PointInTime(transform.position, transform.rotation, Life.instance.life));
    }

    void Recalled()
    {
        if (PointsInTime.Count > 0)
        {
            PointInTime pointInTime = PointsInTime[0];
            transform.position = pointInTime.position;
            transform.rotation = pointInTime.rotation;
            Life.instance.life = pointInTime.Life; //track la vie du perso dans le temps
            PointsInTime.RemoveAt(0);
        }
        else
        {
            stopRecalling();
        }
        
    }

    public void startRecalling()
    {
        isRecalling = true;
        rb.isKinematic = true;
    }

    public void stopRecalling()
    {
        isRecalling = false;
        rb.isKinematic = false; 
    }
}
