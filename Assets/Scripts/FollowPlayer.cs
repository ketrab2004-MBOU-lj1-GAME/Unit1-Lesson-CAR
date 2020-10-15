using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(0,0,0);
    public float smoothTime = .05f;
    Vector3 velocity; //for ref velocity because .SmoothDamp wants it that way
    
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.SmoothDamp(transform.position, player.transform.position + offset, ref velocity, smoothTime);
        //smoothDamp function for better camera, between current camera pos and player pos with offset in smoothTime seconds
    }
}
