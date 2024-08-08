using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeTransform : MonoBehaviour
{
    public GameObject Pipe;
    public float speed;
    public float timeToDie = 0;
    private float _timer = 0;

    void Start()
    {
        _timer = timeToDie;
    }

    void Update()
    {
        Pipe.transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        if (_timer < 0)
        {
            DestroyPipe();
        }
        else
        {
            _timer -= Time.deltaTime;
        }
    }
    public void DestroyPipe()
    {
        Destroy(gameObject);
    }
}