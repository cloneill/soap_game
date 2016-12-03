/*
 * Author: Luke O'Neill
 * 
 * Implements all the assets for purchase with virtual or real currency using
 * Soomla store framework
 * 
 * IMPORTANT: Increment "GetVersion" each time a change in made to this file!
 * 
*/


using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using Soomla.Store;


public class SOAPStoreAssets : IStoreAssets {

    // You need to bump the version after ANY change in this file for the local
    // database to realize it needs to refresh its data
    public int GetVersion()
    {
        return 3;
    }


    // Retrieves the array of your game's virtual currencies.
    public VirtualCurrency[] GetCurrencies()
    {
        return new VirtualCurrency[] { SOAP_CURRENCY };
    }


    // Retrieves the array of all virtual goods served by your store (all kinds in one array).
    public VirtualGood[] GetGoods()
    {
        return new VirtualGood[] {  NO_ADS_LTVG, 
                                    CAT_AVATAR_C, CAT_AVATAR_M, CAT_TAIL_M, CAT_TAIL_C,
                                    BABY_AVATAR_C, BABY_AVATAR_M, BABY_TAIL_C, BABY_TAIL_M,
                                    IRONMAN_AVATAR_C, IRONMAN_AVATAR_M, IRONMAN_TAIL_C, IRONMAN_TAIL_M,                                   
                                    MONSTER_AVATAR_C, MONSTER_AVATAR_M, MONSTER_TAIL_C, MONSTER_TAIL_M,
                                    MUMMY_AVATAR_C, MUMMY_AVATAR_M, MUMMY_TAIL_C, MUMMY_TAIL_M, 
                                    NIGHTMAN_AVATAR_C, NIGHTMAN_AVATAR_M, NIGHTMAN_TAIL_C, NIGHTMAN_TAIL_M,
                                    NIGHTMARE_AVATAR_C, NIGHTMARE_AVATAR_M, NIGHTMARE_TAIL_C, NIGHTMARE_TAIL_M,
                                    NINJA_AVATAR_C, NINJA_AVATAR_M, NINJA_TAIL_C, NINJA_TAIL_M,
                                    OHYEAH_AVATAR_C, OHYEAH_AVATAR_M, OHYEAH_TAIL_C, OHYEAH_TAIL_M,
                                    PIRATE_AVATAR_C, PIRATE_AVATAR_M, PIRATE_TAIL_C, PIRATE_TAIL_M,
                                    RANGER_AVATAR_C, RANGER_AVATAR_M, RANGER_TAIL_C, RANGER_TAIL_M,
                                    SKULL_AVATAR_C, SKULL_AVATAR_M, SKULL_TAIL_C, SKULL_TAIL_M, 
                                    SUPERBMAN_AVATAR_C, SUPERBMAN_AVATAR_M, SUPERBMAN_TAIL_C, SUPERBMAN_TAIL_M,
                                    TINKER_AVATAR_C, TINKER_AVATAR_M, TINKER_TAIL_C, TINKER_TAIL_M,
                                    WEBHEAD_AVATAR_C, WEBHEAD_AVATAR_M, WEBHEAD_TAIL_C, WEBHEAD_TAIL_M,
                                    VAMPIRE_AVATAR_C, VAMPIRE_AVATAR_M, VAMPIRE_TAIL_C, VAMPIRE_TAIL_M,
                                };
    }


    // Retrieves the array of all virtual currency packs served by your store
    public VirtualCurrencyPack[] GetCurrencyPacks()
    {
        return new VirtualCurrencyPack[] { };
    }


    // Retrieves the array of all virtual categories handled in your store
    public VirtualCategory[] GetCategories()
    {
        return new VirtualCategory[] { GENERAL_CATEGORY };
    }


    /** Static Final Members **/

    public const string SOAP_CURRENCY_ITEM_ID = "soap_coins";
    public const string NO_ADS_LIFETIME_PRODUCT_ID = "soap_no_ads";

    public const string BABY_AVATAR_ITEM_ID = "baby_avatar";
    public const string BABY_AVATAR_PRODUCT_ID = "soap_baby_avatar";
    public const string BABY_TAIL_ITEM_ID = "baby_tail";
    public const string BABY_TAIL_PRODUCT_ID = "soap_baby_tail";

    public const string CAT_AVATAR_ITEM_ID = "cat_avatar";
    public const string CAT_AVATAR_PRODUCT_ID = "soap_cat_avatar";
    public const string CAT_TAIL_ITEM_ID = "cat_tail";
    public const string CAT_TAIL_PRODUCT_ID = "soap_cat_tail";

    public const string IRONMAN_AVATAR_ITEM_ID = "ironman_avatar";
    public const string IRONMAN_AVATAR_PRODUCT_ID = "soap_ironman_avatar";
    public const string IRONMAN_TAIL_ITEM_ID = "ironman_tail";
    public const string IRONMAN_TAIL_PRODUCT_ID = "soap_ironman_tail";

    public const string MONSTER_AVATAR_ITEM_ID = "monster_avatar";
    public const string MONSTER_AVATAR_PRODUCT_ID = "soap_monster_avatar";
    public const string MONSTER_TAIL_ITEM_ID = "monster_tail";
    public const string MONSTER_TAIL_PRODUCT_ID = "soap_monster_tail";

    public const string MUMMY_AVATAR_ITEM_ID = "mummy_avatar";
    public const string MUMMY_AVATAR_PRODUCT_ID = "soap_mummy_avatar";
    public const string MUMMY_TAIL_ITEM_ID = "mummy_tail";
    public const string MUMMY_TAIL_PRODUCT_ID = "soap_mummy_tail";

    public const string NINJA_AVATAR_ITEM_ID = "ninja_avatar";
    public const string NINJA_AVATAR_PRODUCT_ID = "soap_ninja_avatar";
    public const string NINJA_TAIL_ITEM_ID = "ninja_tail";
    public const string NINJA_TAIL_PRODUCT_ID = "soap_ninja_tail";

    public const string NIGHTMAN_AVATAR_ITEM_ID = "nightman_avatar";
    public const string NIGHTMAN_AVATAR_PRODUCT_ID = "soap_nightman_avatar";
    public const string NIGHTMAN_TAIL_ITEM_ID = "nightman_tail";
    public const string NIGHTMAN_TAIL_PRODUCT_ID = "soap_nightman_tail";

    public const string NIGHTMARE_AVATAR_ITEM_ID = "nightmare_avatar";
    public const string NIGHTMARE_AVATAR_PRODUCT_ID = "soap_nightmare_avatar";
    public const string NIGHTMARE_TAIL_ITEM_ID = "nightmare_tail";
    public const string NIGHTMARE_TAIL_PRODUCT_ID = "soap_nightmare_tail";

    public const string OHYEAH_AVATAR_ITEM_ID = "ohyeah_avatar";
    public const string OHYEAH_AVATAR_PRODUCT_ID = "soap_ohyeah_avatar";
    public const string OHYEAH_TAIL_ITEM_ID = "ohyeah_tail";
    public const string OHYEAH_TAIL_PRODUCT_ID = "soap_ohyeah_tail";

    public const string PIRATE_AVATAR_ITEM_ID = "pirate_avatar";
    public const string PIRATE_AVATAR_PRODUCT_ID = "soap_pirate_avatar";
    public const string PIRATE_TAIL_ITEM_ID = "pirate_tail";
    public const string PIRATE_TAIL_PRODUCT_ID = "soap_pirate_tail";

    public const string RANGER_AVATAR_ITEM_ID = "ranger_avatar";
    public const string RANGER_AVATAR_PRODUCT_ID = "soap_ranger_avatar";
    public const string RANGER_TAIL_ITEM_ID = "ranger_tail";
    public const string RANGER_TAIL_PRODUCT_ID = "soap_ranger_tail";

    public const string SKULL_AVATAR_ITEM_ID = "skull_avatar";
    public const string SKULL_AVATAR_PRODUCT_ID = "soap_skull_avatar";
    public const string SKULL_TAIL_ITEM_ID = "skull_tail";
    public const string SKULL_TAIL_PRODUCT_ID = "soap_skull_tail";

    public const string SUPERBMAN_AVATAR_ITEM_ID = "superbman_avatar";
    public const string SUPERBMAN_AVATAR_PRODUCT_ID = "soap_superbman_avatar";
    public const string SUPERBMAN_TAIL_ITEM_ID = "superbman_tail";
    public const string SUPERBMAN_TAIL_PRODUCT_ID = "soap_superbman_tail";

    public const string TINKER_AVATAR_ITEM_ID = "tinker_avatar";
    public const string TINKER_AVATAR_PRODUCT_ID = "soap_tinker_avatar";
    public const string TINKER_TAIL_ITEM_ID = "tinker_tail";
    public const string TINKER_TAIL_PRODUCT_ID = "soap_tinker_tail";

    public const string WEBHEAD_AVATAR_ITEM_ID = "webhead_avatar";
    public const string WEBHEAD_AVATAR_PRODUCT_ID = "soap_webhead_avatar";
    public const string WEBHEAD_TAIL_ITEM_ID = "webhead_tail";
    public const string WEBHEAD_TAIL_PRODUCT_ID = "soap_webhead_tail";

    public const string VAMPIRE_AVATAR_ITEM_ID = "vampire_avatar";
    public const string VAMPIRE_AVATAR_PRODUCT_ID = "soap_vampire_avatar";
    public const string VAMPIRE_TAIL_ITEM_ID = "vampire_tail";
    public const string VAMPIRE_TAIL_PRODUCT_ID = "soap_vampire_tail";



    /** Virtual Currencies **/

    public static VirtualCurrency SOAP_CURRENCY = new VirtualCurrency(
                "Coins",										// name
                "SOAP Currency",								// description
                SOAP_CURRENCY_ITEM_ID							// item id
    );


    /** LifeTimeVGs - can only be purchased once and lasts forever **/

    // Purchase ninja with virtual currency
    public static VirtualGood NINJA_AVATAR_C = new LifetimeVG(
        "Ninja", 													    // name
        "Unlock Ninja Avatar",				 							// description
        NINJA_AVATAR_ITEM_ID,										    // item id
        new PurchaseWithVirtualItem(SOAP_CURRENCY_ITEM_ID, 12500)	    // the way this virtual good is purchased
    );

    // Purchase ninja with real money
    public static VirtualGood NINJA_AVATAR_M = new LifetimeVG(
        "Ninja", 													    // name
        "Unlock Ninja Avatar",				 							// description
        NINJA_AVATAR_PRODUCT_ID,										// product id
        new PurchaseWithMarket(NINJA_AVATAR_PRODUCT_ID, 0.99)	        // the way this virtual good is purchased
    );

    // Purchase skull with virtual currency
    public static VirtualGood SKULL_AVATAR_C = new LifetimeVG(
        "Skull", 												    	// name
        "Unlock Skull Avatar",				 						    // description
        SKULL_AVATAR_ITEM_ID,										    // item id
        new PurchaseWithVirtualItem(SOAP_CURRENCY_ITEM_ID, 9500)	    // the way this virtual good is purchased
    );

    // Purchase skull with real money
    public static VirtualGood SKULL_AVATAR_M = new LifetimeVG(
        "Skull", 													    // name
        "Unlock Skull Avatar",				 						    // description
        SKULL_AVATAR_PRODUCT_ID,										// product id
        new PurchaseWithMarket(SKULL_AVATAR_PRODUCT_ID, 0.99)	        // the way this virtual good is purchased
    );

    // Purchase cat with virtual currency
    public static VirtualGood CAT_AVATAR_C = new LifetimeVG(
        "Cat", 												    	    // name
        "Unlock Cat Avatar",				 						    // description
        CAT_AVATAR_ITEM_ID,										        // item id
        new PurchaseWithVirtualItem(SOAP_CURRENCY_ITEM_ID, 6500)	    // the way this virtual good is purchased
    );

    // Purchase cat with real money
    public static VirtualGood CAT_AVATAR_M = new LifetimeVG(
        "Cat", 													        // name
        "Unlock Cat Avatar",	    			 						// description
        CAT_AVATAR_PRODUCT_ID,										    // product id
        new PurchaseWithMarket(CAT_AVATAR_PRODUCT_ID, 0.99)	            // the way this virtual good is purchased
    );

    // Purchase mummy with virtual currency
    public static VirtualGood MUMMY_AVATAR_C = new LifetimeVG(
        "Mummy", 											            // name
        "Unlock Mummy Avatar",				 				            // description
        MUMMY_AVATAR_ITEM_ID,								            // item id
        new PurchaseWithVirtualItem(SOAP_CURRENCY_ITEM_ID, 11500)        // the way this virtual good is purchased
    );
    
    // Purchase mummy with real money
    public static VirtualGood MUMMY_AVATAR_M = new LifetimeVG(
        "Mummy", 													    // name
        "Unlock Mummy Avatar",				 						    // description
        MUMMY_AVATAR_PRODUCT_ID,									    // product id
        new PurchaseWithMarket(MUMMY_AVATAR_PRODUCT_ID, 0.99)	        // the way this virtual good is purchased
    );

    // Purchase monster with virtual currency
    public static VirtualGood MONSTER_AVATAR_C = new LifetimeVG(
        "Monster", 											            // name
        "Unlock Monster Avatar",				 				         // description
        MONSTER_AVATAR_ITEM_ID,								            // item id
        new PurchaseWithVirtualItem(SOAP_CURRENCY_ITEM_ID, 15500)        // the way this virtual good is purchased
    );
    
    // Purchase monster with real money
        public static VirtualGood MONSTER_AVATAR_M = new LifetimeVG(
        "Monster", 													    // name
        "Unlock Monster Avatar",				 					    // description
        MONSTER_AVATAR_PRODUCT_ID,									    // product id
        new PurchaseWithMarket(MONSTER_AVATAR_PRODUCT_ID, 0.99)	        // the way this virtual good is purchased
    );

    // Purchase ranger with virtual currency
    public static VirtualGood RANGER_AVATAR_C = new LifetimeVG(
        "Ranger", 											            // name
        "Unlock Ranger Avatar",				 				            // description
        RANGER_AVATAR_ITEM_ID,								            // item id
        new PurchaseWithVirtualItem(SOAP_CURRENCY_ITEM_ID, 19500)        // the way this virtual good is purchased
    );

    // Purchase ranger with real money
    public static VirtualGood RANGER_AVATAR_M = new LifetimeVG(
        "Ranger", 													    // name
        "Unlock Ranger Avatar",				 						    // description
        RANGER_AVATAR_PRODUCT_ID,									    // product id
        new PurchaseWithMarket(RANGER_AVATAR_PRODUCT_ID, 0.99)	        // the way this virtual good is purchased
    );

    // Purchase baby with virtual currency
    public static VirtualGood BABY_AVATAR_C = new LifetimeVG(
        "Baby", 													    // name
        "Unlock Baby Avatar",				 							// description
        BABY_AVATAR_ITEM_ID,										    // item id
        new PurchaseWithVirtualItem(SOAP_CURRENCY_ITEM_ID, 6500)	    // the way this virtual good is purchased
    );

    // Purchase baby with real money
    public static VirtualGood BABY_AVATAR_M = new LifetimeVG(
        "Baby", 													    // name
        "Unlock Baby Avatar",				 							// description
        BABY_AVATAR_PRODUCT_ID,										    // product id
        new PurchaseWithMarket(BABY_AVATAR_PRODUCT_ID, 0.99)	        // the way this virtual good is purchased
    );


    // Purchase ironman with virtual currency
    public static VirtualGood IRONMAN_AVATAR_C = new LifetimeVG(
        "Ironman", 													    // name
        "Unlock Ironman Avatar",				 						// description
        IRONMAN_AVATAR_ITEM_ID,										    // item id
        new PurchaseWithVirtualItem(SOAP_CURRENCY_ITEM_ID, 19500)	    // the way this virtual good is purchased
    );

    // Purchase ironman with real money
    public static VirtualGood IRONMAN_AVATAR_M = new LifetimeVG(
        "Ironman", 													    // name
        "Unlock Ironman Avatar",				 						// description
        IRONMAN_AVATAR_PRODUCT_ID,										// product id
        new PurchaseWithMarket(IRONMAN_AVATAR_PRODUCT_ID, 0.99)	        // the way this virtual good is purchased
    );


    // Purchase ohyeah with virtual currency
    public static VirtualGood OHYEAH_AVATAR_C = new LifetimeVG(
        "Ohyeah", 													    // name
        "Unlock Ohyeah Avatar",				 							// description
        OHYEAH_AVATAR_ITEM_ID,										    // item id
        new PurchaseWithVirtualItem(SOAP_CURRENCY_ITEM_ID, 22500)	    // the way this virtual good is purchased
    );

    // Purchase ohyeah with real money
    public static VirtualGood OHYEAH_AVATAR_M = new LifetimeVG(
        "Ohyeah", 													    // name
        "Unlock Ohyeah Avatar",				 							// description
        OHYEAH_AVATAR_PRODUCT_ID,										// product id
        new PurchaseWithMarket(OHYEAH_AVATAR_PRODUCT_ID, 0.99)	        // the way this virtual good is purchased
    );


    // Purchase nightman with virtual currency
    public static VirtualGood NIGHTMAN_AVATAR_C = new LifetimeVG(
        "Nightman", 													// name
        "Unlock Nightman Avatar",				 						// description
        NIGHTMAN_AVATAR_ITEM_ID,										// item id
        new PurchaseWithVirtualItem(SOAP_CURRENCY_ITEM_ID, 27500)	    // the way this virtual good is purchased
    );

    // Purchase nightman with real money
    public static VirtualGood NIGHTMAN_AVATAR_M = new LifetimeVG(
        "Nightman", 													// name
        "Unlock Nightman Avatar",				 						// description
        NIGHTMAN_AVATAR_PRODUCT_ID,										// product id
        new PurchaseWithMarket(NIGHTMAN_AVATAR_PRODUCT_ID, 0.99)	    // the way this virtual good is purchased
    );


    // Purchase nightmare with virtual currency
    public static VirtualGood NIGHTMARE_AVATAR_C = new LifetimeVG(
        "Nightmare", 													// name
        "Unlock Nightmare Avatar",				 						// description
        NIGHTMARE_AVATAR_ITEM_ID,										// item id
        new PurchaseWithVirtualItem(SOAP_CURRENCY_ITEM_ID, 22500)	    // the way this virtual good is purchased
    );

    // Purchase nightmare with real money
    public static VirtualGood NIGHTMARE_AVATAR_M = new LifetimeVG(
        "Nightmare", 													// name
        "Unlock Nightmare Avatar",				 						// description
        NIGHTMARE_AVATAR_PRODUCT_ID,									// product id
        new PurchaseWithMarket(NIGHTMARE_AVATAR_PRODUCT_ID, 0.99)	    // the way this virtual good is purchased
    );


    // Purchase pirate with virtual currency
    public static VirtualGood PIRATE_AVATAR_C = new LifetimeVG(
        "Pirate", 													    // name
        "Unlock Pirate Avatar",				 							// description
        PIRATE_AVATAR_ITEM_ID,										    // item id
        new PurchaseWithVirtualItem(SOAP_CURRENCY_ITEM_ID, 25500)	    // the way this virtual good is purchased
    );

    // Purchase pirate with real money
    public static VirtualGood PIRATE_AVATAR_M = new LifetimeVG(
        "Pirate", 													    // name
        "Unlock Pirate Avatar",				 							// description
        PIRATE_AVATAR_PRODUCT_ID,										// product id
        new PurchaseWithMarket(PIRATE_AVATAR_PRODUCT_ID, 0.99)	        // the way this virtual good is purchased
    );

    // Purchase superbman with virtual currency
    public static VirtualGood SUPERBMAN_AVATAR_C = new LifetimeVG(
        "Superbman", 													// name
        "Unlock Superbman Avatar",				 						// description
        SUPERBMAN_AVATAR_ITEM_ID,										// item id
        new PurchaseWithVirtualItem(SOAP_CURRENCY_ITEM_ID, 29500)	    // the way this virtual good is purchased
    );

    // Purchase superbman with real money
    public static VirtualGood SUPERBMAN_AVATAR_M = new LifetimeVG(
        "Superbman", 													// name
        "Unlock Superbman Avatar",				 						// description
        SUPERBMAN_AVATAR_PRODUCT_ID,									// product id
        new PurchaseWithMarket(SUPERBMAN_AVATAR_PRODUCT_ID, 0.99)	    // the way this virtual good is purchased
    );


    // Purchase tinker with virtual currency
    public static VirtualGood TINKER_AVATAR_C = new LifetimeVG(
        "Tinker", 													    // name
        "Unlock Tinker Avatar",				 							// description
        TINKER_AVATAR_ITEM_ID,										    // item id
        new PurchaseWithVirtualItem(SOAP_CURRENCY_ITEM_ID, 25500)	    // the way this virtual good is purchased
    );

    // Purchase tinker with real money
    public static VirtualGood TINKER_AVATAR_M = new LifetimeVG(
        "Tinker", 													    // name
        "Unlock Tinker Avatar",				 							// description
        TINKER_AVATAR_PRODUCT_ID,										// product id
        new PurchaseWithMarket(TINKER_AVATAR_PRODUCT_ID, 0.99)	        // the way this virtual good is purchased
    );


    // Purchase webhead with virtual currency
    public static VirtualGood WEBHEAD_AVATAR_C = new LifetimeVG(
        "Webhead", 													    // name
        "Unlock Webhead Avatar",				 						// description
        WEBHEAD_AVATAR_ITEM_ID,										    // item id
        new PurchaseWithVirtualItem(SOAP_CURRENCY_ITEM_ID, 31500)	    // the way this virtual good is purchased
    );

    // Purchase webhead with real money
    public static VirtualGood WEBHEAD_AVATAR_M = new LifetimeVG(
        "Webhead", 													    // name
        "Unlock Webhead Avatar",				 						// description
        WEBHEAD_AVATAR_PRODUCT_ID,										// product id
        new PurchaseWithMarket(WEBHEAD_AVATAR_PRODUCT_ID, 0.99)	        // the way this virtual good is purchased
    );


    // Purchase vampire with virtual currency
    public static VirtualGood VAMPIRE_AVATAR_C = new LifetimeVG(
        "Vampire", 													    // name
        "Unlock Vampire Avatar",				 						// description
        VAMPIRE_AVATAR_ITEM_ID,										    // item id
        new PurchaseWithVirtualItem(SOAP_CURRENCY_ITEM_ID, 22500)	    // the way this virtual good is purchased
    );

    // Purchase vampire with real money
    public static VirtualGood VAMPIRE_AVATAR_M = new LifetimeVG(
        "Vampire", 													    // name
        "Unlock Vampire Avatar",				 						// description
        VAMPIRE_AVATAR_PRODUCT_ID,										// product id
        new PurchaseWithMarket(VAMPIRE_AVATAR_PRODUCT_ID, 0.99)	        // the way this virtual good is purchased
    );




    // --
    // -- Set up tail purchases --
    // --

    // Purchase ninja with virtual currency
    public static VirtualGood NINJA_TAIL_C = new LifetimeVG(
        "Ninja", 													    // name
        "Unlock Ninja Tail",				 							// description
        NINJA_TAIL_ITEM_ID,										        // item id
        new PurchaseWithVirtualItem(SOAP_CURRENCY_ITEM_ID, 6250)	    // the way this virtual good is purchased
    );

    // Purchase ninja with real money
    public static VirtualGood NINJA_TAIL_M = new LifetimeVG(
        "Ninja", 													    // name
        "Unlock Ninja Tail",				 							// description
        NINJA_TAIL_PRODUCT_ID,										    // product id
        new PurchaseWithMarket(NINJA_TAIL_PRODUCT_ID, 0.99)	            // the way this virtual good is purchased
    );

    // Purchase ninja with virtual currency
    public static VirtualGood SKULL_TAIL_C = new LifetimeVG(
        "Skull", 													    // name
        "Unlock Skull Tail",				 							// description
        SKULL_TAIL_ITEM_ID,										        // item id
        new PurchaseWithVirtualItem(SOAP_CURRENCY_ITEM_ID, 4250)	    // the way this virtual good is purchased
    );

    // Purchase skull with real money
    public static VirtualGood SKULL_TAIL_M = new LifetimeVG(
        "Skull", 													    // name
        "Unlock Skull Tail",				 							// description
        SKULL_TAIL_PRODUCT_ID,										    // product id
        new PurchaseWithMarket(SKULL_TAIL_PRODUCT_ID, 0.99)	            // the way this virtual good is purchased
    );

    // Purchase cat with virtual currency
    public static VirtualGood CAT_TAIL_C = new LifetimeVG(
        "Cat", 													        // name
        "Unlock Cat Tail",				 							    // description
        CAT_TAIL_ITEM_ID,										        // item id
        new PurchaseWithVirtualItem(SOAP_CURRENCY_ITEM_ID, 3250)	    // the way this virtual good is purchased
    );

    // Purchase cat with real money
    public static VirtualGood CAT_TAIL_M = new LifetimeVG(
        "Cat", 													        // name
        "Unlock Cat Tail",				 							    // description
        CAT_TAIL_PRODUCT_ID,										    // product id
        new PurchaseWithMarket(CAT_TAIL_PRODUCT_ID, 0.99)	            // the way this virtual good is purchased
    );

    // Purchase ranger with virtual currency
    public static VirtualGood RANGER_TAIL_C = new LifetimeVG(
        "Ranger", 													    // name
        "Unlock Ranger Tail",				 							// description
        RANGER_TAIL_ITEM_ID,										    // item id
        new PurchaseWithVirtualItem(SOAP_CURRENCY_ITEM_ID, 9750)	    // the way this virtual good is purchased
    );

    // Purchase ranger with real money
    public static VirtualGood RANGER_TAIL_M = new LifetimeVG(
        "Ranger", 													    // name
        "Unlock Ranger Tail",				 							// description
        RANGER_TAIL_PRODUCT_ID,										    // product id
        new PurchaseWithMarket(RANGER_TAIL_PRODUCT_ID, 0.99)	        // the way this virtual good is purchased
    );

    // Purchase mummy with virtual currency
    public static VirtualGood MUMMY_TAIL_C = new LifetimeVG(
        "Mummy", 													    // name
        "Unlock Mummy Tail",				 							// description
        MUMMY_TAIL_ITEM_ID,										        // item id
        new PurchaseWithVirtualItem(SOAP_CURRENCY_ITEM_ID, 5750)	    // the way this virtual good is purchased
    );

    // Purchase mummy with real money
    public static VirtualGood MUMMY_TAIL_M = new LifetimeVG(
        "Mummy", 													    // name
        "Unlock Mummy Tail",				 							// description
        MUMMY_TAIL_PRODUCT_ID,										    // product id
        new PurchaseWithMarket(MUMMY_TAIL_PRODUCT_ID, 0.99)	            // the way this virtual good is purchased
    );


    // Purchase monster with virtual currency
    public static VirtualGood MONSTER_TAIL_C = new LifetimeVG(
        "Monster", 													    // name
        "Unlock Monster Tail",				 							// description
        MONSTER_TAIL_ITEM_ID,										    // item id
        new PurchaseWithVirtualItem(SOAP_CURRENCY_ITEM_ID, 7750)	    // the way this virtual good is purchased
    );

    // Purchase monster with real money
    public static VirtualGood MONSTER_TAIL_M = new LifetimeVG(
        "Monster", 													    // name
        "Unlock Monster Tail",				 							// description
        MONSTER_TAIL_PRODUCT_ID,										// product id
        new PurchaseWithMarket(MONSTER_TAIL_PRODUCT_ID, 0.99)	        // the way this virtual good is purchased
    );

    // Purchase baby with virtual currency
    public static VirtualGood BABY_TAIL_C = new LifetimeVG(
        "Baby", 													    // name
        "Unlock Baby Tail",				 							    // description
        BABY_TAIL_ITEM_ID,										        // item id
        new PurchaseWithVirtualItem(SOAP_CURRENCY_ITEM_ID, 3250)	    // the way this virtual good is purchased
    );

    // Purchase baby with real money
    public static VirtualGood BABY_TAIL_M = new LifetimeVG(
        "Baby", 													    // name
        "Unlock Baby Tail",				 							    // description
        BABY_TAIL_PRODUCT_ID,										    // product id
        new PurchaseWithMarket(BABY_TAIL_PRODUCT_ID, 0.99)	            // the way this virtual good is purchased
    );


    // Purchase ironman with virtual currency
    public static VirtualGood IRONMAN_TAIL_C = new LifetimeVG(
        "Ironman", 													    // name
        "Unlock Ironman Tail",				 							// description
        IRONMAN_TAIL_ITEM_ID,										    // item id
        new PurchaseWithVirtualItem(SOAP_CURRENCY_ITEM_ID, 9750)	    // the way this virtual good is purchased
    );

    // Purchase ironman with real money
    public static VirtualGood IRONMAN_TAIL_M = new LifetimeVG(
        "Ironman", 													    // name
        "Unlock Ironman Tail",				 							// description
        IRONMAN_TAIL_PRODUCT_ID,										// product id
        new PurchaseWithMarket(IRONMAN_TAIL_PRODUCT_ID, 0.99)	        // the way this virtual good is purchased
    );


    // Purchase ohyeah with virtual currency
    public static VirtualGood OHYEAH_TAIL_C = new LifetimeVG(
        "Ohyeah", 													    // name
        "Unlock Ohyeah Tail",				 							// description
        OHYEAH_TAIL_ITEM_ID,										    // item id
        new PurchaseWithVirtualItem(SOAP_CURRENCY_ITEM_ID, 11250)	    // the way this virtual good is purchased
    );

    // Purchase ohyeah with real money
    public static VirtualGood OHYEAH_TAIL_M = new LifetimeVG(
        "Ohyeah", 													    // name
        "Unlock Ohyeah Tail",				 							// description
        OHYEAH_TAIL_PRODUCT_ID,										    // product id
        new PurchaseWithMarket(OHYEAH_TAIL_PRODUCT_ID, 0.99)	        // the way this virtual good is purchased
    );


    // Purchase nightman with virtual currency
    public static VirtualGood NIGHTMAN_TAIL_C = new LifetimeVG(
        "Nightman", 													// name
        "Unlock Nightman Tail",				 							// description
        NIGHTMAN_TAIL_ITEM_ID,										    // item id
        new PurchaseWithVirtualItem(SOAP_CURRENCY_ITEM_ID, 13750)	    // the way this virtual good is purchased
    );

    // Purchase nightman with real money
    public static VirtualGood NIGHTMAN_TAIL_M = new LifetimeVG(
        "Nightman", 													// name
        "Unlock Nightman Tail",				 							// description
        NIGHTMAN_TAIL_PRODUCT_ID,										// product id
        new PurchaseWithMarket(NIGHTMAN_TAIL_PRODUCT_ID, 0.99)	        // the way this virtual good is purchased
    );


    // Purchase nightmare with virtual currency
    public static VirtualGood NIGHTMARE_TAIL_C = new LifetimeVG(
        "Nightmare", 													// name
        "Unlock Nightmare Tail",				 						// description
        NIGHTMARE_TAIL_ITEM_ID,										    // item id
        new PurchaseWithVirtualItem(SOAP_CURRENCY_ITEM_ID, 11250)	    // the way this virtual good is purchased
    );

    // Purchase nightmare with real money
    public static VirtualGood NIGHTMARE_TAIL_M = new LifetimeVG(
        "Nightmare", 													// name
        "Unlock Nightmare Tail",				 						// description
        NIGHTMARE_TAIL_PRODUCT_ID,										// product id
        new PurchaseWithMarket(NIGHTMARE_TAIL_PRODUCT_ID, 0.99)	        // the way this virtual good is purchased
    );


    // Purchase pirate with virtual currency
    public static VirtualGood PIRATE_TAIL_C = new LifetimeVG(
        "Pirate", 													    // name
        "Unlock Pirate Tail",				 							// description
        PIRATE_TAIL_ITEM_ID,										    // item id
        new PurchaseWithVirtualItem(SOAP_CURRENCY_ITEM_ID, 12750)	    // the way this virtual good is purchased
    );

    // Purchase pirate with real money
    public static VirtualGood PIRATE_TAIL_M = new LifetimeVG(
        "Pirate", 													    // name
        "Unlock Pirate Tail",				 							// description
        PIRATE_TAIL_PRODUCT_ID,										    // product id
        new PurchaseWithMarket(PIRATE_TAIL_PRODUCT_ID, 0.99)	        // the way this virtual good is purchased
    );

    // Purchase superbman with virtual currency
    public static VirtualGood SUPERBMAN_TAIL_C = new LifetimeVG(
        "Superbman", 													// name
        "Unlock Superbman Tail",				 						// description
        SUPERBMAN_TAIL_ITEM_ID,										    // item id
        new PurchaseWithVirtualItem(SOAP_CURRENCY_ITEM_ID, 14750)	    // the way this virtual good is purchased
    );

    // Purchase superbman with real money
    public static VirtualGood SUPERBMAN_TAIL_M = new LifetimeVG(
        "Superbman", 													// name
        "Unlock Superbman Tail",				 						// description
        SUPERBMAN_TAIL_PRODUCT_ID,										// product id
        new PurchaseWithMarket(SUPERBMAN_TAIL_PRODUCT_ID, 0.99)	        // the way this virtual good is purchased
    );


    // Purchase tinker with virtual currency
    public static VirtualGood TINKER_TAIL_C = new LifetimeVG(
        "Tinker", 													    // name
        "Unlock Tinker Tail",				 							// description
        TINKER_TAIL_ITEM_ID,										    // item id
        new PurchaseWithVirtualItem(SOAP_CURRENCY_ITEM_ID, 12750)	    // the way this virtual good is purchased
    );

    // Purchase tinker with real money
    public static VirtualGood TINKER_TAIL_M = new LifetimeVG(
        "Tinker", 													    // name
        "Unlock Tinker Tail",				 							// description
        TINKER_TAIL_PRODUCT_ID,										    // product id
        new PurchaseWithMarket(TINKER_TAIL_PRODUCT_ID, 0.99)	        // the way this virtual good is purchased
    );


    // Purchase webhead with virtual currency
    public static VirtualGood WEBHEAD_TAIL_C = new LifetimeVG(
        "Webhead", 													    // name
        "Unlock Webhead Tail",				 							// description
        WEBHEAD_TAIL_ITEM_ID,										    // item id
        new PurchaseWithVirtualItem(SOAP_CURRENCY_ITEM_ID, 15750)	    // the way this virtual good is purchased
    );

    // Purchase webhead with real money
    public static VirtualGood WEBHEAD_TAIL_M = new LifetimeVG(
        "Webhead", 													    // name
        "Unlock Webhead Tail",				 							// description
        WEBHEAD_TAIL_PRODUCT_ID,										// product id
        new PurchaseWithMarket(WEBHEAD_TAIL_PRODUCT_ID, 0.99)	        // the way this virtual good is purchased
    );


    // Purchase vampire with virtual currency
    public static VirtualGood VAMPIRE_TAIL_C = new LifetimeVG(
        "Vampire", 													    // name
        "Unlock Vampire Tail",				 							// description
        VAMPIRE_TAIL_ITEM_ID,										    // item id
        new PurchaseWithVirtualItem(SOAP_CURRENCY_ITEM_ID, 11250)	    // the way this virtual good is purchased
    );

    // Purchase vampire with real money
    public static VirtualGood VAMPIRE_TAIL_M = new LifetimeVG(
        "Vampire", 													    // name
        "Unlock Vampire Tail",				 							// description
        VAMPIRE_TAIL_PRODUCT_ID,										// product id
        new PurchaseWithMarket(VAMPIRE_TAIL_PRODUCT_ID, 0.99)	        // the way this virtual good is purchased
    );



    // --
    // -- Remove Ads from the game
    // --

    // Remove all ads from the game
    public static VirtualGood NO_ADS_LTVG = new LifetimeVG(
		"No Ads", 														// name
		"No More Ads!",				 									// description
        NO_ADS_LIFETIME_PRODUCT_ID,										// item id
		new PurchaseWithMarket(NO_ADS_LIFETIME_PRODUCT_ID, 1.99)	    // the way this virtual good is purchased
    );


    /** Virtual Categories **/

    public static VirtualCategory GENERAL_CATEGORY = new VirtualCategory(
        "General",
        new List<string>(new string[] { NINJA_AVATAR_ITEM_ID })
    );
}


