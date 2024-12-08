using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    // здоровье NPC
    public int health = 5;

    // уровень NPC
    public int level = 1;

    // скорость NPS
    public float speed = 1.2f;

    public int direction = -1;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((transform.position.x < -29) || (transform.position.x > -1))
        {
            direction *= -1;
        } 


        transform.position += new Vector3(direction * speed, 0, 0);
    }
}
