using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeVolume : MonoBehaviour
{

    // Start is called before the first frame update
    public Slider MusicVolumeSlider;
    public AudioSource backgroundMusic;

    // Update is called once per frame
    void Update()
    {
        backgroundMusic.volume = MusicVolumeSlider.value;
    }
}
