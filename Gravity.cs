using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    float mass;
    bool mobile;
    Vector2 acceleration;
    Vector2 vel3;
    List<GameObject> BodiesInRange = new List<GameObject>();
    Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    Vector2 gravityCalc(List<GameObject> bodyList, GameObject forBody)
    {
        Vector2 accn = new Vector2(0f,0f);
        float accnMag;
        Vector2 dist = new Vector2(0f, 0f);
        float constant;
        constant = 0.5f;
        foreach(var item in bodyList)
        {
            dist = item.transform.position - forBody.transform.position;
            //accnMag = (constant * item.mass * forBody.mass)/Math.Pow((dist.x * dist.x + dist.y * dist.y), 1.5);
            //accn = accnMag*dist + accn;
        }
        return accn;
    }

    // Update is called once per frame
    void Update()
    {
        if(mobile == true)
        {
            //acceleration = gravityCalc(BodiesInRange);
            vel3 = vel3 + acceleration*Time.deltaTime;
            rb.transform.Translate(vel3*Time.deltaTime);
        }
    }
}