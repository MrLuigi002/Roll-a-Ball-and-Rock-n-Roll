using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class StoreScript : MonoBehaviour
{

    public RawImage myImage;
    public VideoPlayer videoPlayer;

    public void tenPoints()
    {
        Application.OpenURL("https://www.paypal.me/mrluigi002/1.99");
    }

    public void sixtyPoints()
    {
        Application.OpenURL("https://www.paypal.me/mrluigi002/9.99");
    }

    public void onefixtyPoints()
    {
        Application.OpenURL("https://www.paypal.me/mrluigi002/19.99");
    }

    public void fourhPoints()
    {
        Application.OpenURL("https://www.paypal.me/mrluigi002/49.99");
    }

    public void watchAd()
    {
        StartCoroutine(PlayAd());
    }

    IEnumerator PlayAd()
    {
        GameObject playerBall = GameObject.FindGameObjectWithTag("Player");
        GameObject storePage = GameObject.FindGameObjectWithTag("Store");
        //bool pageActive = false;

        videoPlayer.Prepare();
        WaitForSeconds waitforseconds = new WaitForSeconds(1);
        while(!videoPlayer.isPrepared)
        {
            yield return waitforseconds;
            break;
        }

        myImage.texture = videoPlayer.texture;
        myImage.gameObject.SetActive(true);
        videoPlayer.Play();

        yield return new WaitForSeconds(53);

        //storePage.GetComponent<OpenStoreScript>().active = pageActive;
        //pageActive = false;
        storePage.SetActive(false);
        
        myImage.gameObject.SetActive(false);

        playerBall.GetComponent<PlayerController>().score += 5;

        yield return null;
    }
}
