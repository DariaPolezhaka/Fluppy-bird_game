using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private Vector2 vec;
    public float localY;
    public GameObject pipe;

    // Start is called before the first frame update
    void Awake()
    {
        pipe = gameObject;
        vec = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        localY = Random.Range(-1f, 3.5f);
        vec -= new Vector2(Time.deltaTime*5f, 0f);
        transform.position = vec;
        if (transform.position.x < -8f)
        {
            Instantiate(pipe, new Vector2(12, localY), Quaternion.identity);
            Destroy(this);
        }
    }
}
