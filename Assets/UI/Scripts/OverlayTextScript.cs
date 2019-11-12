using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverlayTextScript : MonoBehaviour
{
    public AudioSource musicPlayer;
    public AudioClip nextSong;
    public bool avanced = false;

    bool poof = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && poof == false)
        {
            poof = true;
            //gameObject.SetActive(false);
            gameObject.transform.localScale = new Vector3(0, 0, 0);

            StartCoroutine("playNext");

        }
    }

    IEnumerator playNext()
    {
        musicPlayer.loop = false;
        yield return new WaitWhile (()=> musicPlayer.isPlaying);
        avanced = true;
        musicPlayer.Stop();
        musicPlayer.volume = 0.5f;
        musicPlayer.clip = nextSong;
        musicPlayer.Play();

        gameObject.SetActive(false);

        yield return null;
    }
}
