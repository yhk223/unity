using UnityEngine;
using System.Collections;

public class bgs : MonoBehaviour {
    
    float s;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    void Update()
    {
        SpriteRenderer sr=GetComponent<SpriteRenderer>();
        s = Camera.main.transform.position.x - Camera.main.orthographicSize * 2f / Screen.height * Screen.width / 2f - sr.bounds.size.x / 2f;
        transform.position += Vector3.left * Time.deltaTime * 2;
        if (transform.position.x < s)
        {
            transform.position += new Vector3(sr.sprite.bounds.size.x, 0, 0) * 3;
        }
    }
}
