using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    void Start()
    {
        Vector3 pos = NPCMain.randomPos();
        gameObject.transform.position = pos;
    }


    void Update()
    {

    }
}
