using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class NPC : MonoBehaviour
{


    // Start is called before the first frame update
    int level = 1;
    int healtl = 5;
    float speed = 1.5f;
    Vector3 new_pos;
    void Start()
    {
        healtl += level;
        print("Heath" + healtl);
    }
    // Update is called once per frame
    void Update()
    {
        new_pos = transform.position;
        new_pos.x += speed * Time.deltaTime;
        gameObject.transform.position = new_pos;
    }
}
