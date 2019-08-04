using UnityEngine;
using System.Collections;

public class bigelmy : MonoBehaviour
{
    public static int score = 0;
     int bn = 6;
     int speed=6;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float x = Camera.main.orthographicSize / (Screen.height * 1f / Screen.width);
        transform.position += Vector3.left * Time.deltaTime * speed;
        if (transform.position.x + GetComponent<SpriteRenderer>().bounds.size.x < -x)
        {
            Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.name == "Player")
        {
            Destroy(this.gameObject);
        }
        else if (co.tag == "Finish")
        {
            if (bn >= 1)
            {
                bn--;
                if (bn == 0)
                {
                    Destroy(this.gameObject);
                    score=score+10;
                }
            }
        }

    }
}

