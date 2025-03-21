using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectLayout : MonoBehaviour
{
    public Vector3 offset;
    public float speed = 0.1f;
    private List<Transform> objs = new List<Transform>();

    public bool useX = true;
    public bool useY = true;
    public bool useZ = true;

    //--------------------------------------------------------------------------------------------

    private void Start()
    {
        foreach(Transform c in transform) objs.Add(c);
    }

    private void LateUpdate()
    {
        for(int i=0;i<objs.Count;i++) {
            if(objs[i] == null) objs.RemoveAt(i);
            Vector3 newPos = new Vector3(
                useX ? transform.position.x+(offset.x*i) : objs[i].position.x,
                useY ? transform.position.y+(offset.y*i) : objs[i].position.y,
                useZ ? transform.position.z+(offset.z*i) : objs[i].position.z
            );
            objs[i].position = Vector3.Lerp(objs[i].position, newPos, speed * Time.deltaTime);
        }
    }

}
