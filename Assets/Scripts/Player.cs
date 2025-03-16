using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public List<Transform> poses = new List<Transform>();
    public Transform cam;
    
    int currentPos = 0;

    private void Update() {
        if (Input.GetKeyDown(KeyCode.W)) {
            currentPos++;
        }
        if (Input.GetKeyDown(KeyCode.S)) {
            currentPos--;
        }
        cam.position=Vector3.Lerp(cam.position, poses[currentPos].position, 0.1f);
        cam.rotation=Quaternion.Lerp(cam.rotation, poses[currentPos].rotation, 0.1f);
    }
}
