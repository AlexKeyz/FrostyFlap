using UnityEngine;
using UnityEngine.UIElements;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] public Transform Spawner;
    [SerializeField] public GameObject Pipe;
    private float _timer;
    public float timeToSpawn;
    public float mixYPosition, maxYPosition;

    private void Start()
    {
        timeToSpawn = 3;
    }
    private void Update()
    {
        if (_timer < 0)
        {
            _timer = timeToSpawn;
            Vector3 position = Spawner.position;
            GameObject pipe = Instantiate(Pipe, position, Quaternion.identity);
            float rand = Random.Range(mixYPosition, maxYPosition);
            pipe.transform.position = new Vector3(pipe.transform.position.x, rand, 0);
        }
        else
        {
            _timer -= Time.deltaTime; 
        }
        switch (PlayerController._score)
        {
            case > 65:
                timeToSpawn = 1.8f;
                break;
            case > 60:
                timeToSpawn = 1.9f;
                break;
            case > 55:
                timeToSpawn = 2.0f;
                break;
            case > 50:
                timeToSpawn = 2.1f;
                break;
            case > 45:
                timeToSpawn = 2.2f;
                break;
            case > 40:
                timeToSpawn = 2.3f;
                break;
            case > 35:
                timeToSpawn = 2.4f;
                break;
            case > 30:
                timeToSpawn = 2.5f;
                break;
            case > 25:
                timeToSpawn = 2.6f;
                break;
            case > 20:
                timeToSpawn = 2.7f;
                break;
            case > 15:
                timeToSpawn = 2.8f;
                break;
            case > 10:
                timeToSpawn = 2.9f;
                break;
            default:
                timeToSpawn = 3f;
                break;
        }
    }
}