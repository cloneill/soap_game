/*
 * Author: Luke O'Neill
 * 
 * This script registers to listen for the specified subset of events 
 * fired by Soomla events relating to the store. It then handles these events
 * 
 * IMPORTANT: Put this class on a gameobject that is always active, 
 * never destroyed, and only loads once (SPLASH SCREEN)
*/


using UnityEngine;
using System.Collections;
using Soomla.Profile;
using UnityEngine.UI;


public class SOAPProfileEvents : MonoBehaviour {

    private SOAPProfile soap_profile_script;

	// Register to listen to the following Soomla events
	void Start () 
    {
        // These event catchers need to be on a gameobject that is never turned off, 
        ProfileEvents.OnLoginFinished += onLoginFinished;
        ProfileEvents.OnSocialActionFinished += onSocialActionFinished;
        //ProfileEvents.OnUserProfileUpdated += OnUserProfileUpdated;
        DontDestroyOnLoad(this.gameObject);
	}


    // Handle this event with your game-specific behavior:
    public void onLoginFinished(UserProfile userProfileJson, bool autoLogin, string payload)
    {
        // autoLogin will be "true" if the user was logged in using the AutoLogin functionality
        // payload is an identification string that you can give when you initiate the login operation and want to receive back upon its completion

        if (!autoLogin)
        {
            GameObject temp_1 = GameObject.Find("start_ui_gr");
            if (temp_1 != null) { soap_profile_script = temp_1.GetComponent<SOAPProfile>(); }

            string social_provider = payload;

            if (social_provider == "facebook")
            {
                soap_profile_script.postToWall();
            }
            else if (social_provider == "twitter")
            {
                soap_profile_script.postToTwitter();
            }
            Debug.Log(userProfileJson);
        }
    }


    // Give reward avatars when successfully posting to facebook or twitter
    public void onSocialActionFinished(Provider provider, SocialActionType action, string payload)
    {
        // provider is the social provider
        // action is the social action (like, post status, etc..) that finished
        // payload is an identification string that you can give when you initiate the social action operation and want to receive back upon its completion

        string social_provider = payload;

        Debug.Log(provider);

        if (social_provider == "facebook")
        {
            RewardedAvatars.incrementAvatarBalance(RewardedAvatars.ghost_avatar_rwd);
            RewardedAvatars.incrementAvatarBalance(RewardedAvatars.ghost_tail_rwd);
        }
        else if (social_provider == "twitter")
        {
            RewardedAvatars.incrementAvatarBalance(RewardedAvatars.star_avatar_rwd);
            RewardedAvatars.incrementAvatarBalance(RewardedAvatars.star_tail_rwd);
        }
    }
}


