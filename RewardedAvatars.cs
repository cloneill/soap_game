/*
 * Author: Luke O'Neill
 * 
 * Logic for avatars that can only be unlocked by completing specific actions
 * 
*/


using System.Collections;
using System.Collections.Generic;

using UnityEngine;


public class RewardedAvatars : MonoBehaviour {

    // These are the game object names of the various avatars and tails that can be rewarded
    public const string alien_avatar_rwd = "alien_avatar";
    public const string alien_tail_rwd = "alien_tail";
    public const string cyborg_avatar_rwd = "cyborg_avatar";
    public const string cyborg_tail_rwd = "cyborg_tail";
    public const string ghost_avatar_rwd = "ghost_avatar";
    public const string ghost_tail_rwd = "ghost_tail";
    public const string rocketman_avatar_rwd = "rocketman_avatar";
    public const string rocketman_tail_rwd = "rocketman_tail";
    public const string star_avatar_rwd = "star_avatar";
    public const string star_tail_rwd = "star_tail";


    // Dictionary of reward avatar and tails with their position in the player prefs "Reward" key string
    public static readonly Dictionary<string, int> avatar_balance_index_map = new Dictionary<string, int>
    {   
        {"alien_avatar", 0},
        {"alien_tail", 1},
        {"cyborg_avatar", 2},
        {"cyborg_tail", 3},
        {"ghost_avatar", 4},
        {"ghost_tail", 5},
        {"rocketman_avatar", 6},
        {"rocketman_tail", 7},
        {"star_avatar", 8},
        {"star_tail", 9},
    };


    // Dictionary that explains how to earn each avatar
    public static readonly Dictionary<string, string> avatar_earn_text_map = new Dictionary<string, string>
    {   
        {"alien_avatar", "Pass the first challenge room to unlock."},
        {"alien_tail", "Pass the first challenge room to unlock."},
        {"cyborg_avatar", "Get a score of 20 to unlock."},
        {"cyborg_tail", "Get a score of 20 to unlock."},
        {"ghost_avatar", "Post to Facebook to unlock."},
        {"ghost_tail", "Post to Facebook to unlock."},
        {"rocketman_avatar", "Remove ads to unlock."},
        {"rocketman_tail", "Remove ads to unlock."},
        {"star_avatar", "Post to Twitter to unlock."},
        {"star_tail", "Post to Twitter to unlock."},
    };


	// Set player preferences
	void Start () 
    {
        bool reward_key_exists = PlayerPrefs.HasKey("Reward");

        if (!reward_key_exists)
        {
            PlayerPrefs.SetString("Reward", "0_0_0_0_0_0_0_0_0_0");
        }
	}
	

    // Checks the balance player prefs key to see if the avatar is unlocked
    public static bool isAvatarUnlocked(string name)
    {
        string reward_key = getRewardKey();
        string[] avatar_balance = reward_key.Split('_');
        int balance_position = avatar_balance_index_map[name];

        return avatar_balance[balance_position] == "1" ? true : false;
    }


    // Increments the balance contained in the player prefs "Reward" key
    public static void incrementAvatarBalance(string name)
    {
        string reward_key = getRewardKey();
        string[] avatar_balance = reward_key.Split('_');
        int balance_position = avatar_balance_index_map[name];

        avatar_balance[balance_position] = "1";

        string new_reward_key = string.Join("_", avatar_balance);

        setRewardKey(new_reward_key);
    }


    // Set the reward key - determines which avatars/tails have been unlocked
    public static void setRewardKey(string reward_index)
    {
        PlayerPrefs.SetString("Reward", reward_index);
    }


    // Return the string representing the balances of the rewarded avatars and tails
    public static string getRewardKey()
    {
        return PlayerPrefs.GetString("Reward");
    }
}


