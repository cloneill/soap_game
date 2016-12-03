/*
 * Author: Luke O'Neill
 * 
 * Serve Chartboost ads after the player dies a certain number of times
 * Unlock acievements related to dying a consecutive number of times
 * 
 * Add this script to a gameobject that is never destroyed!
 * 
*/


using System.Collections;

using UnityEngine;
using ChartboostSDK;
using Soomla.Store;
using GooglePlayGames;


public class CBAds : MonoBehaviour {

    private int ad_frequency = 6;   // Ads appear after this many game overs have appeared
    private int go_count = 0;


	// Use this for initialization
	void Start () 
    {        
        DontDestroyOnLoad(this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // Show ads at the game over screen and unlock death achievements
    public void showGameOverAds()
    {
        go_count++;

        string death_count = go_count.ToString();

        // Unlock achievement for dying specific number of times
        #if UNITY_ANDROID
            switch (death_count)
            {
                case "10":
                    Achievements.unlockAchivement(GPGSIds.achievement_just_getting_the_hang_of_it);
                    break;
                case "20":
                    Achievements.unlockAchivement(GPGSIds.achievement_this_gets_easier_right);
                    break;
                case "30":
                    Achievements.unlockAchivement(GPGSIds.achievement_masochist);
                    break;
                case "50":
                    Achievements.unlockAchivement(GPGSIds.achievement_so_much_death);
                    break;
            }
        #endif

        if (go_count % ad_frequency == 0 && StoreInventory.GetItemBalance(SOAPStoreAssets.NO_ADS_LIFETIME_PRODUCT_ID) == 0)
        {
            Chartboost.showInterstitial(CBLocation.GameOver);
            Debug.Log("Show the ads now!");
        }
    }
}


