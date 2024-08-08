using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] public GameObject delay;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //delay.SetActive(true);
    }
    public void MenuExid(int SceneNumber)
    {
        SceneManager.LoadScene(SceneNumber);
        //delay.SetActive(true);
    }
    public void StartButton(int SceneNumber)
    {
        SceneManager.LoadScene(SceneNumber);
        //delay.SetActive(true);
    }
}
