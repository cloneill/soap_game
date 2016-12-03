/*
 * Author: Luke O'Neill
 * 
 * This script registers to listen for the specified subset of events fired by Soomla events. 
 * It then handles these events.
 * 
 * IMPORTANT: Put this class on a gameobject that is always active, 
 * never destroyed, and only loads once (SPLASH SCREEN)
 * 
*/


using System.Collections;

using UnityEngine;
using UnityEngine.UI;
using Soomla.Store;


public class SOAPStoreEvents : MonoBehaviour {

    private SOAPStoreManager store_manager_script;

	// Register to listen to the following Soomla events
	void Start () 
    {
        // These event catchers need to be on a gameobject that is never turned off
        StoreEvents.OnItemPurchased += onItemPurchased;
        StoreEvents.OnGoodBalanceChanged += OnGoodBalanceChanged;
        StoreEvents.OnCurrencyBalanceChanged += OnCurrencyBalanceChanged;
        StoreEvents.OnRestoreTransactionsStarted += OnRestoreTransactionsStarted;
        StoreEvents.OnRestoreTransactionsFinished += OnRestoreTransactionsFinished;
        DontDestroyOnLoad(this.gameObject);
	}


    // Update the prices when an item is bought with real money in the store
    public void onItemPurchased(PurchasableVirtualItem pvi, string payload)
    {
        GameObject temp_1 = GameObject.Find("store_ui_gr");
        if (temp_1 != null) { store_manager_script = temp_1.GetComponent<SOAPStoreManager>(); }

        string avatar_id = pvi.ItemId;

        // To prevent erroring out when an item is bought with real money 
        // (store manager will attempt to look up "soap_soap_" without this check and fail)
        if (avatar_id.Contains("soap_"))
        {
            avatar_id = avatar_id.Replace("soap_", "");
        }

        // Unlock achievement for buying an avatar or tail with real money
        #if UNITY_ANDROID
            unlockStoreAchievements(avatar_id)
        #endif

        // Give rocketman avatar and tail for removing ads
        if (avatar_id == "soap_no_ads")
        {
            RewardedAvatars.incrementAvatarBalance(RewardedAvatars.rocketman_avatar_rwd);
            RewardedAvatars.incrementAvatarBalance(RewardedAvatars.rocketman_tail_rwd);
        }
    }


    // Update the prices when an item is bought with virtual currency in the store
    public void OnGoodBalanceChanged(VirtualGood vg, int balance, int amountAdded)
    {
        GameObject temp_1 = GameObject.Find("store_ui_gr");
        if (temp_1 != null) { store_manager_script = temp_1.GetComponent<SOAPStoreManager>(); }

        string avatar_id = vg.ItemId;

        // To prevent erroring out when an item is bought with real money 
        // (store manager will attempt to look up "soap_soap_" without this check and fail)
        if (avatar_id.Contains("soap_"))
        {
            avatar_id = avatar_id.Replace("soap_", "");
        }

        // Update avatar and tail prices in the store
        if (avatar_id.Contains("avatar"))
        {
            store_manager_script.updatePrices(avatar_id);
        }
        else if (avatar_id.Contains("tail"))
        {
            store_manager_script.updatePrices(avatar_id);
        }

        // Unlock achievement for buying an avatar or tail with virtual currency
        #if UNITY_ANDROID
            unlockStoreAchievements(avatar_id)
        #endif
    }


    // Unlock achivements for purchasing a tail or avatar from the store with real or virtual currency
    public void unlockStoreAchievements(string avatar_id)
    {
        if (avatar_id.Contains("avatar"))
        {
            store_manager_script.updatePrices(avatar_id);
            Achievements.unlockAchivement(GPGSIds.achievement_massive_facial_reconstruction);
        }
        else if (avatar_id.Contains("tail"))
        {
            store_manager_script.updatePrices(avatar_id);
            Achievements.unlockAchivement(GPGSIds.achievement_shedding_season);
        }
    }


    // Change the currency balance text when the balance changed
    public void OnCurrencyBalanceChanged(VirtualCurrency vc, int balance, int amountAdded)
    {
        GameObject temp_1 = GameObject.Find("store_ui_gr");
        if (temp_1 != null) { store_manager_script = temp_1.GetComponent<SOAPStoreManager>(); }

        store_manager_script.setStoreCoinText();
        store_manager_script.setGameOverCoinText();
        store_manager_script.setPauseCoinText();

        // Unlock achievement for accumulating coins
        #if UNITY_ANDROID
            if (balance >= 20000 && balance < 100000)
            {
                Achievements.unlockAchivement(GPGSIds.achievement_for_a_rainy_day);
            }

            if (balance > 100000)
            {
                Achievements.unlockAchivement(GPGSIds.achievement_must_have_them_all);
            }
        #endif
    }


    // Print message saying transactions are being restored (necessary for iOS)
    public void OnRestoreTransactionsStarted()
    {
        Debug.Log("The transactions are being restored.");
    }


    // Print message saying transactions are restored (necessary for iOS)
    public void OnRestoreTransactionsFinished(bool success)
    {
        Debug.Log("The transactions are now restored.");
    }
}


