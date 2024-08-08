using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YG;

public class MusicControl : MonoBehaviour
{
    public Sprite onMusic;
    public Sprite offMusic;

    public Image MusicButton;
    public static bool isOn;
    public AudioSource ad;

    void Start()
    {
        isOn = true;
    }


    void Update()
    {
        if (PlayerPrefs.GetInt("music") == 0)
        {
            MusicButton.GetComponent<Image>().sprite = onMusic;
            ad.enabled = true;
            isOn = true;
        }
        else if (PlayerPrefs.GetInt("music") == 1)
        {
            MusicButton.GetComponent<Image>().sprite = offMusic;
            ad.enabled = false;
            isOn = false;
        }
    }
    public void offSaund()
    {
        if (!isOn)
        {
            PlayerPrefs.SetInt("music", 0);
            YandexGame.savesData.money = 0;
        }
        else if (isOn)
        {
            PlayerPrefs.SetInt("music", 1);
            YandexGame.savesData.money = 1;
        }
    }
}
