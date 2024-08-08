using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpForce = 500f; // Сила прыжка
    [SerializeField] public GameObject player;
    [SerializeField] public GameObject pipe;
    [SerializeField] public GameObject loseWindow;
    public static int _score;
    public Text _textScore;
    [SerializeField] public GameObject delay;

    void Start()
    {
        delay.SetActive(true);
        Time.timeScale = 0;
        _score = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            rb.AddForce(Vector2.up * jumpForce);
        }
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) && !loseWindow.active)
        {
            delay.SetActive(false);
            Time.timeScale = 1;
        }
        // Обновляем текст с количеством очков
        _textScore.text = _score.ToString();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Pipe"))
        {
            Time.timeScale = 0; // Останавливаем время
            loseWindow.SetActive(true); // Показываем окно проигрыша
        }
        if (other.gameObject.CompareTag("PipeCompleate"))
        {
            _score += 1;
        }
    }
}