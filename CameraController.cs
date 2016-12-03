/*
 * Author: Luke O'Neill
 * 
 * Controls how the camera follows the avatar
 * 
 * Add this script to the camera game object!
 * 
*/


using System.Collections;

using UnityEngine;


public class CameraController : MonoBehaviour {

    public GameObject avatar;           // Reference to the avatar gameobject
    public int camera_y_offset;         // The offset between the camera and the avatar
    public float camera_damp;           // Dampening effect for the camera's follow. Smaller = more dampening


    // Have the camera smoothly follow the avatar vertically
    void FixedUpdate()
    {   
        // Only move camera if the avatar is moving upwards
		if (avatar.transform.position.y >= transform.position.y + camera_y_offset)
        {
            // Set the cameras target position
            Vector3 target_pos = new Vector3(0, avatar.transform.position.y - camera_y_offset, -10);
            
            // Smoothly move the camera to the target position
            transform.position = Vector3.Lerp(transform.position, target_pos, camera_damp);

            //Debug.Log(string.Format("Target: {0}\nCurrent: {1}", target_pos, transform.position));
        }
    }
}


