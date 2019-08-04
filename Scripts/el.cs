using UnityEngine;
using System.Collections;

public class el : MonoBehaviour {
    public GameObject elmy;
    public GameObject bigelmy;
    float m = 0,s=0;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (m>1.5f)
        {
            Instantiate<GameObject>(elmy);
            elmy.transform.position = new Vector3(Random.Range(31, 40), Random.Range(0,9),0);
            m = 0;
        }
        if (s>30)
        {
            Instantiate<GameObject>(bigelmy);
            s = 0;
        }
        m += Time.deltaTime;
        s += Time.deltaTime;
	}
}
