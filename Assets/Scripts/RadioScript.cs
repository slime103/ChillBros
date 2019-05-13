using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioScript : MonoBehaviour
{
    public float volume;
    public AudioClip[] playlist;
    AudioSource radio;
    public int currentSong = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        radio = GetComponent<AudioSource>();
        int num = Random.Range(0, 7);
        radio.PlayOneShot(playlist[num]);
        currentSong = num;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            radio.Stop();
            int num = Random.Range(0, 7);
            radio.PlayOneShot(playlist[num]);
            currentSong = num;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            NextTrack();
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            LastTrack();
        }
    }

    public void NextTrack()
    {
        radio.Stop();
        currentSong++;
        radio.PlayOneShot(playlist[currentSong]);
    }

    public void LastTrack()
    {
        radio.Stop();
        currentSong--;
        radio.PlayOneShot(playlist[currentSong]);
    }

    //RadioOFF
    //RadioON
}
