/*
 * Author: Luke O'Neill
 * 
 * Controls the movement of the avatar
 * 
 * Add this script to the avatar game object
 * 
*/


using System.Collections;
using System.Collections.Generic;

using UnityEngine;


public class AvatarController : MonoBehaviour {

    private float min_distance = 0.70f;         // The minimum distance between elements in the snake
    private Vector3 previous_avatar_position;   // The avatars position before it travelled min_distance 
    private string avatar_direction;            // The direction the avatar is moving
    private Vector3 avatar_vector_direction;    // The avatar vector direction
    private Rigidbody2D rigid_body;             // Used to give avatar velocity

    public float avatar_speed;                          // The speed at which the avatar moves
    public Vector2 default_avatar_position;             // The avatars starting position
    public Vector3 previous_vector_avatar_direction;    // The avatars previous vector direction
    public TailMovement tail_movement_script;
    Dictionary<string, string> cw_movement = new Dictionary<string, string>();  // Defines the next direction for clockwise turn
    Dictionary<string, string> ccw_movement = new Dictionary<string, string>(); // Defines the next direction for counter-clockwise turn

    
	// Use this for initialization
	void Start () 
    {
        avatar_direction = "up";
        transform.position = default_avatar_position;
        previous_avatar_position = transform.position - new Vector3(0,min_distance,0);

        avatar_vector_direction = Vector3.up;
        previous_vector_avatar_direction = avatar_vector_direction;

        rigid_body = this.GetComponent<Rigidbody2D>();
	}


    // Moves the avatar every frame
	void Update()
	{
		moveAvatar();
	}


    // Have the tails follow the avatar 
    void FixedUpdate()
    {
        float current_distance = Vector3.Distance(transform.position, previous_avatar_position);

        // Update tails if the avatar has travelled greater than min_distance
        if (current_distance >= min_distance)
        {
            tail_movement_script.tailFollow(previous_avatar_position);
            previous_avatar_position = transform.position;
        }
    }


    // Rotate the avatar +/- 90 degrees
    // Angle provided must be in radians
    public void rotate_avatar(float angle)
    {
        float cos_angle = Mathf.Cos(angle);
        float sin_angle = Mathf.Sin(angle);
        avatar_vector_direction.x = previous_vector_avatar_direction.x * cos_angle - previous_vector_avatar_direction.y * sin_angle;
        avatar_vector_direction.y = previous_vector_avatar_direction.x * sin_angle + previous_vector_avatar_direction.y * cos_angle;
        
        // Rotate the sprite
        rotateSprite(previous_vector_avatar_direction, avatar_vector_direction);
    }


    // Can be used for the arrow control or the swipe control
    public void simpleRotateAvatar(string direction)
    {
        switch (direction)
        {
            case "right":
                if (previous_vector_avatar_direction == Vector3.left || avatar_vector_direction == Vector3.right)
                {
                    break;
                }
                avatar_vector_direction = Vector2.right;
                // Rotate the sprite
                rotateSprite(previous_vector_avatar_direction, avatar_vector_direction);
                break;

            case "left":
                if (previous_vector_avatar_direction == Vector3.right || avatar_vector_direction == Vector3.left)
                {
                    break;
                }
                avatar_vector_direction = Vector2.left;
                rotateSprite(previous_vector_avatar_direction, avatar_vector_direction);
                break;

            case "up":
                if (previous_vector_avatar_direction == Vector3.down || avatar_vector_direction == Vector3.up)
                {
                    break;
                }
                avatar_vector_direction = Vector2.up;
                rotateSprite(previous_vector_avatar_direction, avatar_vector_direction);
                break;

            case "down":
                if (previous_vector_avatar_direction == Vector3.up || avatar_vector_direction == Vector3.down)
                {
                    break;
                }
                avatar_vector_direction = Vector2.down;
                rotateSprite(previous_vector_avatar_direction, avatar_vector_direction);
                break;
        }
    }


    // Rotate the sprite image when the avatar turns
    public void rotateSprite(Vector3 previous_direction, Vector3 current_direction)
    {
        Vector3 cross_product = Vector3.Cross(previous_vector_avatar_direction, avatar_vector_direction);
        if (cross_product.z > 0)
        {
            this.transform.Rotate(0, 0, 90);
        }
        else
        {
            this.transform.Rotate(0, 0, -90);
        }
    }


    // Move the avatar in the direction specified
    public void moveAvatar()
    {
        rigid_body.velocity = avatar_vector_direction*avatar_speed;
        previous_vector_avatar_direction = avatar_vector_direction;
    }
}


