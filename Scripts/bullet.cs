using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
        transform.position = new Vector3(player.PL.transform.position.x+0.5f, player.PL.transform.position.y - 0.8f, 0);
	}
	
	// Update is called once per frame
	void Update () {
        float time=0;
        float x = Camera.main.orthographicSize / (Screen.height * 1f / Screen.width);
        transform.position += Vector3.right * Time.deltaTime*5 ;
        time += Time.deltaTime;
        if (transform.position.x>x+GetComponent<SpriteRenderer>().bounds.size.x/2.0f)
        {
            Destroy(this.gameObject);
        }
	}
    void OnTriggerEnter2D(Collider2D co) {
        if (co.tag=="el")
        {
            Destroy(this.gameObject);
        }
        
    }
  
}
