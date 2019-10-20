using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;

public class Ads : MonoBehaviour {
    public void PlayAd()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
    }

    public void ShowRewardedAd()
    {
        const string RewardedPlacementId = "rewardedVideo";
        Time.timeScale = 0;

#if UNITY_ADS
        if (!Advertisement.IsReady(RewardedPlacementId))
        {
            Debug.Log(string.Format("Ads not ready for placement '{0}'", RewardedPlacementId));
            return;
        }

        var options = new ShowOptions { resultCallback = HandleShowResult };
        Advertisement.Show(RewardedPlacementId, options);
#endif
    }

#if UNITY_ADS
    private void HandleShowResult(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                Debug.Log("The ad was successfully shown.");
                //
                // YOUR CODE TO REWARD THE GAMER
                // Give coins etc.
               
                Time.timeScale = 0;
                SceneManager.LoadScene("presidential");
                break;
            case ShowResult.Skipped:
                Debug.Log("The ad was skipped before reaching the end.");
                Time.timeScale = 0;
                SceneManager.LoadScene("presidential");
                break;
            case ShowResult.Failed:
                Debug.LogError("The ad failed to be shown.");
                Time.timeScale = 0;
                SceneManager.LoadScene("presidential");
                break;
        }
    }



#endif

    public void ShowRewardedAdMenu()
    {
        const string RewardedPlacementId = "rewardedVideo";
        Time.timeScale = 0;

#if UNITY_ADS
        if (!Advertisement.IsReady(RewardedPlacementId))
        {
            Debug.Log(string.Format("Ads not ready for placement '{0}'", RewardedPlacementId));
            return;
        }

        var options = new ShowOptions { resultCallback = HandleShowResultMenu };
        Advertisement.Show(RewardedPlacementId, options);
#endif
    }

#if UNITY_ADS
    private void HandleShowResultMenu(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                Debug.Log("The ad was successfully shown.");
                //
                // YOUR CODE TO REWARD THE GAMER
                // Give coins etc.

                
                SceneManager.LoadScene(0);
                break;
            case ShowResult.Skipped:
                Debug.Log("The ad was skipped before reaching the end.");
                
                SceneManager.LoadScene(0);
                break;
            case ShowResult.Failed:
                Debug.LogError("The ad failed to be shown.");
                
                SceneManager.LoadScene(0);
                break;
        }
    }



#endif
}