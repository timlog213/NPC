using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //�������� NPC
    public int health = 5;

    //������� NPC
    public int level = 1;

    //�������� NPC
    public float speed = 1.2f;
    // Start is called before the first frame update
    void Start()
    {
        speed *= level * 10;
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + speed);
    }
}
