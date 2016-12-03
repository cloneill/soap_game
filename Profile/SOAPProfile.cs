/*
 * Author: Luke O'Neill
 * 
 * Implementation of Soomla social framework to post to facebook and twitter
 * 
*/


using System.Collections;

using UnityEngine;
using UnityEngine.UI;
using Soomla.Profile;
using Soomla;


public class SOAPProfile : MonoBehaviour {

    public bool logged_in_fb = false;
    public bool logged_in_twitter = false;
    public Image[] twitter_button_img;
    public Image[] facebook_button_img;
    public Sprite facebook_posted_sprite;
    public Sprite twitter_posted_sprite; 


    // Provide form so user can login in to Facebook
    public void FBLogin()
    {
        if(!SoomlaProfile.IsLoggedIn(Provider.FACEBOOK))
        {
            SoomlaProfile.Login(Provider.FACEBOOK, "facebook");
        }
        else
        {
            // If the user is already logged in and presses the button then post to facebook (auto-login scenario)
            postToWall();
        }
    }


    // Post to Facebook wall
    public void postToWall()
    {
        SoomlaProfile.UpdateStory(
            Provider.FACEBOOK,
            "Scored 1000 points in Snake and Tails!",  // Message
            "Red Tape Studios",                        // Name
            "RTS FTW!",                                // Caption
            "rts_snake_tails",                         // Desc
            "https://play.google.com/store/apps/details?id=com.RedTapeStudios.MatchMayhem_01&hl=en",           // Link
            "https://lh3.googleusercontent.com/VZA4sJmj4Gw1SHzJQJredvGtQeDbUzMdyGykSA1MJW35yWN1-06ve6YuED_sbV1u2a4=h900-rw",     // Image
            "facebook"
            );

        swap_to_fb_posted_img();
    }


    // Provide form so user can login in to Twitter
    public void twitterLogin()
    {
        if (!SoomlaProfile.IsLoggedIn(Provider.TWITTER))
        {
            SoomlaProfile.Login(Provider.TWITTER, "twitter");
        }
        else
        {
            // If the user is already logged in and presses the button then post to twitter (auto-login scenario)
            postToTwitter();
        }
    }


    // Post to Twitter
    public void postToTwitter()
    {
        SoomlaProfile.UpdateStory(
            Provider.TWITTER,
            "Scored 1000 points in Snake and Tails!",  // Message
            "Red Tape Studios",                        // Name
            "RTS FTW!",                                // Caption
            "rts_snake_tails",                         // Desc
            "https://play.google.com/store/apps/details?id=com.RedTapeStudios.MatchMayhem_01&hl=en",           // Link
            "https://lh3.googleusercontent.com/VZA4sJmj4Gw1SHzJQJredvGtQeDbUzMdyGykSA1MJW35yWN1-06ve6YuED_sbV1u2a4=h900-rw",     // Image
            "twitter"
            );

        swap_to_twitter_posted_img();
    }


    // When user has successfully posted swap the image to the posted image
    public void swap_to_fb_posted_img()
    {
        foreach (Image img in facebook_button_img)
        {
            img.sprite = facebook_posted_sprite;
        }
    }


    // When user has successfully posted swap the image to the posted image
    public void swap_to_twitter_posted_img()
    {
        foreach (Image img in twitter_button_img)
        {
            img.sprite = twitter_posted_sprite;
        }
    }


}


