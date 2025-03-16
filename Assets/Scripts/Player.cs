using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public List<Transform> poses = new List<Transform>();
    public Transform cam;
    public Deck deck;
     
    int currentPos = 1;

    private void Update() {
        if(deck.hand != null && Input.GetKeyDown(KeyCode.Mouse0)) {
            currentPos = 2;
        }
        if (Input.GetKeyDown(KeyCode.W)) {
            currentPos++;
            if(currentPos > poses.Count - 1) {
                currentPos = poses.Count - 1;
            }
        }
        if (Input.GetKeyDown(KeyCode.S)) {
            currentPos--;
            if(currentPos < 0) {
                currentPos = 0;
            }
            if(deck.hand != null && currentPos < 2) {
                deck.DeselectCard(deck.hand);
            }
        }
        cam.position=Vector3.Lerp(cam.position, poses[currentPos].position, 0.1f);
        cam.rotation=Quaternion.Lerp(cam.rotation, poses[currentPos].rotation, 0.1f);
    }
}
