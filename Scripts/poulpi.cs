using UnityEngine;
using System.Collections;

public class poulpi : MonoBehaviour
{
    public static int score = 0;
     int n = 5;
     int speed=6;
    // Use this for initialization
    void Start()
    {
        Debug.Log(GetComponent<SpriteRenderer>().bounds.size.y);
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
            if (n >= 1)
        {
            n--;
            if (n == 0)
            {
                Destroy(this.gameObject);
                score++;
            }
        }
        }

    }
}

