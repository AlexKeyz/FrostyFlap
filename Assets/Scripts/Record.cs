using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using YG;

public class Record : MonoBehaviour
{
    public int _recordScore;
    public Text _recordText;
    void Start()
    {
        YandexGame.NewLeaderboardScores("LiderBordClicker", _recordScore);
        _recordScore = PlayerPrefs.GetInt("RecordScore", 0);
    }

    
    void Update()
    {
        if(_recordScore < PlayerController._score)
        {
            _recordScore = PlayerController._score;
            PlayerPrefs.SetInt("RecordScore", _recordScore);
            YandexGame.savesData.money = _recordScore;
        }
        _recordText.text = _recordScore.ToString();
    }
}
