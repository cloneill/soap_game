/*
 * Author: Luke O'Neill
 * 
 * Handles the swapping of avatar and tail sprites that are purchased from the store
 * Gives the user the ability to change the look of their character
 * 
*/


using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;
using Soomla.Store;


public class AvatarTailSwap : MonoBehaviour {

    public Sprite[] avatar_sprite_list;     // Contains avatar sprite game objects
    public Sprite[] tail_sprite_list;       // Contains tail sprite game objects

    private SpriteRenderer avatar_sprite;   // The sprite that is assigned to the avatar
    private GameObject tail_grp;            // The parent game object that contains the tail elements
    private List<SpriteRenderer> tail_sprite = new List<SpriteRenderer>();      // List of tail elements sprites
    private Dictionary<string, Sprite> avatar_name_to_sprite_name = new Dictionary<string, Sprite>();   // Maps avatar names to sprite names
    private Dictionary<string, Sprite> tail_name_to_sprite_name = new Dictionary<string, Sprite>();     // Mpas tail names to avatar names


	// Set player preferences and initialize mapping
	void Start () 
    {
        bool avatar_key_exists = PlayerPrefs.HasKey("Avatar");
        bool tail_key_exists = PlayerPrefs.HasKey("Tail");

        if (!avatar_key_exists)
        {
            PlayerPrefs.SetString("Avatar", "default_avatar");
        }

        if (!tail_key_exists)
        {
            PlayerPrefs.SetString("Tail", "default_tail");
        }

        initialize_avatar_map();
        initialize_tail_map();

        DontDestroyOnLoad(this.gameObject);
	}


    // Apply saved avatar and tail from last play session
    void OnLevelWasLoaded(int level)
    {
        // 2 --> gamescreen
        if (level == 2)
        {
            refresh_sprites();
        }
    }


    // On every new play session set the avatar and tail according to the player pref values
    public void refresh_sprites()
    {   
        GameObject temp_1 = GameObject.Find("avatar_obj");
        if (temp_1 != null) { avatar_sprite = temp_1.GetComponent<SpriteRenderer>(); }

        tail_grp = GameObject.Find("tail_grp");

        setAvatarSprite();
        getTailSprites(tail_grp);
        setTailSprite();
    }


    // Populate the tail sprite list with a list of the sprite components of the tails
    private void getTailSprites(GameObject tail_group)
    {
        int tail_count = tail_group.transform.childCount;

        foreach (Transform child in tail_group.transform)
        {
            tail_sprite.Add(child.GetComponent<SpriteRenderer>());
        }
    }


    // Set the avatar sprite to the selected avatar sprite
    public void setAvatarSprite()
    {
        string selected_avatar = getAvatar();

        if (avatar_sprite != null)
        {
            avatar_sprite.sprite = avatar_name_to_sprite_name[selected_avatar];
            Debug.Log(string.Format("Avatar sprite set to: {0}", selected_avatar));
        }
    }


    // Set the tail sprites to the selected tail sprite
    public void setTailSprite()
    {
        string selected_tail = getTail();
        Debug.Log(string.Format("Tail sprite set to: {0}", selected_tail));

        foreach(SpriteRenderer tail in tail_sprite)
        {
            if (tail != null)
            {
                tail.sprite = tail_name_to_sprite_name[selected_tail];
            }
        }
    }


    // Maps the gameobject name to its sprite for avatars
    public void initialize_avatar_map()
    {
        avatar_name_to_sprite_name.Add("baby_avatar", avatar_sprite_list[0]);
        avatar_name_to_sprite_name.Add("cat_avatar", avatar_sprite_list[1]);
        avatar_name_to_sprite_name.Add("ironman_avatar", avatar_sprite_list[2]);
        avatar_name_to_sprite_name.Add("monster_avatar", avatar_sprite_list[3]);
        avatar_name_to_sprite_name.Add("mummy_avatar", avatar_sprite_list[4]);
        avatar_name_to_sprite_name.Add("ninja_avatar", avatar_sprite_list[5]);
        avatar_name_to_sprite_name.Add("nightman_avatar", avatar_sprite_list[6]);
        avatar_name_to_sprite_name.Add("nightmare_avatar", avatar_sprite_list[7]);
        avatar_name_to_sprite_name.Add("ohyeah_avatar", avatar_sprite_list[8]);
        avatar_name_to_sprite_name.Add("pirate_avatar", avatar_sprite_list[9]);
        avatar_name_to_sprite_name.Add("ranger_avatar", avatar_sprite_list[10]);
        avatar_name_to_sprite_name.Add("skull_avatar", avatar_sprite_list[11]);
        avatar_name_to_sprite_name.Add("superbman_avatar", avatar_sprite_list[12]);
        avatar_name_to_sprite_name.Add("tinker_avatar", avatar_sprite_list[13]);
        avatar_name_to_sprite_name.Add("webhead_avatar", avatar_sprite_list[14]);
        avatar_name_to_sprite_name.Add("vampire_avatar", avatar_sprite_list[15]);
        avatar_name_to_sprite_name.Add("default_avatar", avatar_sprite_list[16]);
        avatar_name_to_sprite_name.Add("orange_avatar", avatar_sprite_list[17]);
        avatar_name_to_sprite_name.Add("alien_avatar", avatar_sprite_list[18]);
        avatar_name_to_sprite_name.Add("cyborg_avatar", avatar_sprite_list[19]);
        avatar_name_to_sprite_name.Add("ghost_avatar", avatar_sprite_list[20]);
        avatar_name_to_sprite_name.Add("rocketman_avatar", avatar_sprite_list[21]);
        avatar_name_to_sprite_name.Add("star_avatar", avatar_sprite_list[22]);
    }


    // Maps the gameobject name to its sprite for tails
    public void initialize_tail_map()
    {
        tail_name_to_sprite_name.Add("baby_tail", tail_sprite_list[0]);
        tail_name_to_sprite_name.Add("cat_tail", tail_sprite_list[1]);
        tail_name_to_sprite_name.Add("ironman_tail", tail_sprite_list[2]);
        tail_name_to_sprite_name.Add("monster_tail", tail_sprite_list[3]);
        tail_name_to_sprite_name.Add("mummy_tail", tail_sprite_list[4]);
        tail_name_to_sprite_name.Add("ninja_tail", tail_sprite_list[5]);
        tail_name_to_sprite_name.Add("nightman_tail", tail_sprite_list[6]);
        tail_name_to_sprite_name.Add("nightmare_tail", tail_sprite_list[7]);
        tail_name_to_sprite_name.Add("ohyeah_tail", tail_sprite_list[8]);
        tail_name_to_sprite_name.Add("pirate_tail", tail_sprite_list[9]);
        tail_name_to_sprite_name.Add("ranger_tail", tail_sprite_list[10]);
        tail_name_to_sprite_name.Add("skull_tail", tail_sprite_list[11]);
        tail_name_to_sprite_name.Add("superbman_tail", tail_sprite_list[12]);
        tail_name_to_sprite_name.Add("tinker_tail", tail_sprite_list[13]);
        tail_name_to_sprite_name.Add("webhead_tail", tail_sprite_list[14]);
        tail_name_to_sprite_name.Add("vampire_tail", tail_sprite_list[15]);
        tail_name_to_sprite_name.Add("default_tail", tail_sprite_list[16]);
        tail_name_to_sprite_name.Add("orange_tail", tail_sprite_list[17]);
        tail_name_to_sprite_name.Add("alien_tail", tail_sprite_list[18]);
        tail_name_to_sprite_name.Add("cyborg_tail", tail_sprite_list[19]);
        tail_name_to_sprite_name.Add("ghost_tail", tail_sprite_list[20]);
        tail_name_to_sprite_name.Add("rocketman_tail", tail_sprite_list[21]);
        tail_name_to_sprite_name.Add("star_tail", tail_sprite_list[22]);
    }


    // Set the avatar and tail player pref to the name of the selected (middle) avatar game object in the store scroll
    public void setAvatar(string avatar_name)
    {
        int virtual_item_balance = 0;
        int market_item_balance = 0;

        // Default avatar and tail balance is always 1
        if (avatar_name == "default_avatar" || avatar_name == "default_tail" || avatar_name == "orange_avatar" || avatar_name == "orange_tail")
        {
            virtual_item_balance = 1;
        }

        // Check balance of reward avatar
        else if (RewardedAvatars.avatar_balance_index_map.ContainsKey(avatar_name))
        {
            if (RewardedAvatars.isAvatarUnlocked(avatar_name))
            {
                virtual_item_balance = 1;
            }
        }
        
        // Look for balances on avatars and tails that are purchasable
        else
        {
            PurchasableVirtualItem virtual_item = (PurchasableVirtualItem)StoreInfo.GetItemByItemId(avatar_name);
            PurchasableVirtualItem market_item = (PurchasableVirtualItem)StoreInfo.GetItemByItemId("soap_" + avatar_name);
            virtual_item_balance = virtual_item.GetBalance();
            market_item_balance = market_item.GetBalance();
        }

        // Set the player pref if the item has been earned/purchased
        if (virtual_item_balance == 1 || market_item_balance == 1)
        {
            if (avatar_name.Contains("avatar"))
            {
                PlayerPrefs.SetString("Avatar", avatar_name);
                Debug.Log(string.Format("Avatar player pref set to: {0}", avatar_name));
            }

            else
            {
                PlayerPrefs.SetString("Tail", avatar_name);
                Debug.Log(string.Format("Tail player pref set to: {0}", avatar_name));
            }
        }
    }


    // Get the tail the player is currently using
    public string getTail()
    {
        return PlayerPrefs.GetString("Tail");
    }


    // Get the avatar the player is currently using
    public string getAvatar()
    {
        return PlayerPrefs.GetString("Avatar");
    }
}


