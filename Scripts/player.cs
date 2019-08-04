using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class player : MonoBehaviour {
    public static GameObject PL;
    public GameObject bullet;
    public GameObject explode;
    Animator an;
    float time = 0;
    public static int dam = 100;
	// Use this for initialization
	void Start () {
      PL=GameObject.Find("Player");
	}	
	// Update is called once per frame
	void Update () {
       
	 if (Input.GetKey(KeyCode.W))
        {
            PL.transform.position += Vector3.up*Time.deltaTime*8;
        }
        if (Input.GetKey(KeyCode.A))
        {
            PL.transform.position += Vector3.left*Time.deltaTime *8;
        }
        if (Input.GetKey(KeyCode.S))
        {
            PL.transform.position += Vector3.down * Time.deltaTime *8;
        }
        if (Input.GetKey(KeyCode.D))
        {
            PL.transform.position += Vector3.right * Time.deltaTime*8;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            PL.transform.position += Vector3.zero;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            PL.transform.position += Vector3.zero;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            PL.transform.position += Vector3.zero;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            PL.transform.position += Vector3.zero;
        }
        if (time>0.5f)
        {
            Instantiate<GameObject>(bullet);
            time=0;
        }
        time += Time.deltaTime;

        if (PL.transform.position.y > Camera.main.transform.position.y +
            Camera.main.orthographicSize - GetComponent<SpriteRenderer>().sprite.bounds.size.y / 2*0.3f)
        {
            transform.position = new Vector3(PL.transform.position.x, Camera.main.transform.position.y + Camera.main.orthographicSize - GetComponent<SpriteRenderer>().sprite.bounds.size.y / 2 * 0.3f, 0);
        }
        if (PL.transform.position.y < -Camera.main.orthographicSize + GetComponent<SpriteRenderer>().sprite.bounds.size.y / 2 * 0.3f)
        {
            transform.position = new Vector3(PL.transform.position.x,-Camera.main.orthographicSize + GetComponent<SpriteRenderer>().sprite.bounds.size.y / 2 * 0.3f, 0);
        }
        float x = Camera.main.orthographicSize / (Screen.height * 1f / Screen.width);
        
        if (PL.transform.position.x > x - GetComponent<SpriteRenderer>().sprite.bounds.size.y / 2 * 0.3f)
        {
            transform.position = new Vector3( x - GetComponent<SpriteRenderer>().sprite.bounds.size.y / 2 * 0.3f, PL.transform.position.y, 0);
        }
        if (PL.transform.position.x < -x + GetComponent<SpriteRenderer>().sprite.bounds.size.y / 2 * 0.3f)
        {
            transform.position = new Vector3(-x + GetComponent<SpriteRenderer>().sprite.bounds.size.y / 2 * 0.3f, PL.transform.position.y, 0);
        }
	}
    void OnTriggerEnter2D(Collider2D co) {
        if (co.tag=="el")
        {
            dam -= 10;
            if (dam==0)
            {
                GameObject ss = Instantiate<GameObject>(explode);
                ss.transform.position = PL.transform.position;
                PL.GetComponent<SpriteRenderer>().material = null;
                StartCoroutine("B"); 
            }
        }
        
    }
    IEnumerator B(){
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("结束场景");
    }
}
