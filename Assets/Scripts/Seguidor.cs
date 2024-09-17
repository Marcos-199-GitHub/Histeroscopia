using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguidor : MonoBehaviour
{
    public Transform target;
    public Vector3 offset_pos = Vector3.zero;
    public Vector3 offset_rot = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + offset_pos;
        transform.rotation = target.rotation;
        transform.Rotate(offset_rot);
    }
}
