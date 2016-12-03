/*
 * Author: Luke O'Neill
 * 
 * Contains the backend logic for the tail movement
 * 
*/


using System.Collections;
using System.Collections.Generic;

using UnityEngine;


public class TailMovement : MonoBehaviour {

    public GameObject[] tail_sprites;   // Tail sprites to set active when a grow element has been eaten
    public bool grow_tail = false;      // True if the avatar has eaten a grow element since the last minimum distance covered
    
    private int tail_count = 0;         // The amount of tails collected. Used to access tail elements in tail_sprites array
    private List<GameObject> tail_elements = new List<GameObject>();    // Used to reorder tails to mimic snake movement
    private int start_tail_num = 3;                                     // Number of tails to start with
    private spawn_tiles spawn_tiles_script;                             // Used to get whether first tile is starter tile


    // Start with the specified amount of tails
    public void startWithTails()
    {
        for (int i = 0; i < start_tail_num; i++)
        {
            GameObject tail = tail_sprites[i];
            tail.SetActive(true);
            tail_elements.Insert(0, tail);
        }

        tail_count = start_tail_num;
    }


    // Place the last tail in the gap created when the avatar moves the minimum distance (specified in AvatarController)
    public void tailFollow(Vector3 position)
    {
        if (grow_tail)
        {
            GameObject tail = tail_sprites[tail_count];
            tail.SetActive(true);
            tail_elements.Insert(0, tail);
            tail.transform.position = position;
            grow_tail = false;
            tail_count++;
        }

        else if (tail_elements.Count != 0)
        {
            int last_index = tail_elements.Count - 1;
            GameObject last_tail = tail_elements[last_index];
            last_tail.transform.position = position;
            tail_elements.RemoveAt(last_index);
            tail_elements.Insert(0, last_tail);
        }
    }
}


