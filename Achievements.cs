/*
 * Author: Luke O'Neill
 * 
 * Unlock achievements implemented by Google Play Games Services plugin
 * Contains a generic function called from: PointManager, CBAds, and SOAPStoreEvents classes 
 * 
 * Add this script to a gameobject that is never destroyed!
 * 
*/


using UnityEngine;
using System.Collections;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;



public class Achievements : MonoBehaviour
{

    // Log the user in to Google Play Games Services- Android specific functionality
    void Start()
    {  
        #if UNITY_ANDROID
            Social.localUser.Authenticate((bool success) =>
            {
                if (success)
                {
                    Debug.Log("Login success");
                }
                else
                {
                    Debug.Log("Login failed");
                }
            });
        #endif
    }


    // Generic implementation to unlock achievements (pass in the unique achievement ID)
    public static void unlockAchivement(string GPGS_ID)
    {
        Social.ReportProgress(GPGS_ID, 100.0f, (bool success) =>
        {
            if (success)
            {
                Debug.Log("Achievement unlocked! " + GPGS_ID);
            }

            else
            {
                Debug.Log("Failed to unlock achievement. GPGS failed me! " + GPGS_ID);
            }
        });
    }
}



