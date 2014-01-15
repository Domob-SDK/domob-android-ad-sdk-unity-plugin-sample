using UnityEngine;
using System.Collections;

public class SampleApp : MonoBehaviour {	
	
	private string PUBLISHER_ID = "56OJyM1ouMGoaSnvCK";
	private string InlinePPID = "16TLwebvAchksY6iO_8oSb-i";
	private string FlexibleInlinePPID = "16TLwebvAchksNUH_fumgl0k";
	private string InterstitialPPID = "16TLwebvAchksY6iOa7F4DXs";
	
	//ad sdk
	private string INTERSITIAL_SIZE_300X250 = "300x250";
	private string INTERSITIAL_SIZE_600X500 = "600x500";
	private string INTERSITIAL_SIZE_FULL_SCREEN = null;
	
	private string INLINE_SIZE_300X250 = "300x250";  
	private string INLINE_SIZE_320X50 = "320x50";    
	private string INLINE_SIZE_600X94 = "600x94";   
	private string INLINE_SIZE_600X500 = "600x500";
	private string INLINE_SIZE_728X90 = "728x90"; 
	
	private string LOCATION_TOP = "isTop";
	//default
	private string LOCATION_BOTTOM = "isBottom"; 
	
	// Use this for initialization
	void Start () {
	
	}
	
    void OnGUI()
    {
		int x = 15;
        int y = 5;
        int pad = 20;
		int h = 60;
		int width = 500;
		y += h + pad+10+20;

	       //   scrollViewVector = GUI.BeginScrollView (new Rect (0,0,Screen.width,Screen.height), scrollViewVector, new Rect (0,0,Screen.width-1,1000));
		
		    AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            AndroidJavaObject jo = jc.GetStatic<AndroidJavaObject>("currentActivity");

		
		y += h + pad;
		if (GUI.Button(new Rect(x, y, width, h), "addBannerAd"))
        {
			string[] paramaddBannerAd = new string[4];
			//PublisherI,must set
			paramaddBannerAd[0]=PUBLISHER_ID;
			//InlinePPID,must set
			paramaddBannerAd[1]=InlinePPID;
			//set Advertising size,such as,INLINE_SIZE_320X50,INLINE_SIZE_300X250...must set
			paramaddBannerAd[2]=INLINE_SIZE_320X50;
			//set Advertising display position,default Displayed at the bottom,must set
			paramaddBannerAd[3]=LOCATION_TOP;
			
			// set more param to get ad,not must set
			jo.Call("setKeyword","game");
			jo.Call("setUserGender","male");
			jo.Call("setUserBirthdayStr","2000-08-08");
			jo.Call("setUserPostcode","123456");
			
		//	AndroidJavaClass jcc = new AndroidJavaClass("cn.domob.android.UnityActivity");
       //   jcc.Call("addBannerAd",paramaddBannerAd);
			jo.Call("addBannerAd",paramaddBannerAd);
        }
      	y += h + pad;
		if (GUI.Button(new Rect(x, y, width, h), "addFlexibleBannerAd"))
        {
			string[] paramaddFlexibleBannerAd = new string[3];
			//PUBLISHER_ID.must set
			paramaddFlexibleBannerAd[0]=PUBLISHER_ID;
			//FlexibleInlinePPID,must set
			paramaddFlexibleBannerAd[1]=FlexibleInlinePPID;
			//set Advertising display position,default Displayed at the bottom,must set
			paramaddFlexibleBannerAd[2]=LOCATION_BOTTOM;
            jo.Call("addFlexibleBannerAd",paramaddFlexibleBannerAd);
        }
		
		y += h + pad;
		if (GUI.Button(new Rect(x, y, width, h), "addInterstitialAd"))
        {
			
			string[] paramaddInterstitialAd = new string[3];
			//PUBLISHER_ID.must set
			paramaddInterstitialAd[0]=PUBLISHER_ID;
			//InterstitialPPID,must set
			paramaddInterstitialAd[1]=InterstitialPPID;
			//set Advertising size,such as,INTERSITIAL_SIZE_300X250,INTERSITIAL_SIZE_600X500...must set
			paramaddInterstitialAd[2]=INTERSITIAL_SIZE_300X250;
            jo.Call("addInterstitialAd",paramaddInterstitialAd);
        }
		//GUI.EndScrollView();      
    }
		// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.Home))
        {
            Application.Quit();
        }
	}
	
	
	//Ad Banner Callback
	 void onDomobAdReturned() {
		
	}


 void onDomobAdOverlayPresented() {
		
	}

	
	 void onDomobAdOverlayDismissed() {

	}


	 void onDomobAdClicked() {

	}


	 void onDomobAdFailed() {

	}

	
	 void onDomobLeaveApplication() {

	}

	
	//Ad FlexibleBanner Callback
	 void onDomobFlexibleAdReturned() {
		
	}


	 void onDomobFlexibleAdOverlayPresented() {
		
	}

	
	 void onDomobFlexiblAdOverlayDismissed() {

	}


	 void onDomobFlexibleAdClicked() {

	}


	 void onDomobFlexibleAdFailed() {

	}

	
	 void onDomobFlexibleLeaveApplication() {

	}
	
	//AD Interstitial Callback
	 void onInterstitialAdReady() {

	}


	 void onLandingPageOpen() {

	}


	 void onLandingPageClose() {
			
	}


	 void onInterstitialAdPresent() {
					
	}

		
	 void onInterstitialAdDismiss() {
	
	}

				
	 void onInterstitialAdFailed() {

	}

				
	 void onInterstitialAdLeaveApplication() {
	

	}

	
	 void onInterstitialAdClicked() {
	
	}

	
}
