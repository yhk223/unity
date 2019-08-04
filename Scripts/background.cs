using UnityEngine;
using System.Collections;

public class background : MonoBehaviour {
	// Use this for initialization
    SpriteRenderer sr;
    GameObject[] gg=new GameObject[2];
    public GameObject[] g=new GameObject[2];
    float a;

	void Start () {
        sr = GetComponent<SpriteRenderer>();
        float x = Camera.main.orthographicSize * 2 / (Screen.height * 1f / Screen.width);
	}
	
	// Update is called once per frame
	void Update () {
        a = Camera.main.transform.position.x - Camera.main.orthographicSize * 2f / Screen.height * Screen.width / 2f - sr.bounds.size.x / 2f;
        transform.position += Vector3.left * Time.deltaTime * 2;
        if (transform.position.x < a)
        {
            transform.position += new Vector3(sr.sprite.bounds.size.x, 0, 0) * 3;
        }
	}
}
