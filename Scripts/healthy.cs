using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class healthy : MonoBehaviour {
   
	// Use this for initialization
	void Start () { 
	}
	
	// Update is called once per frame
	void Update () {
        transform.rotation = Camera.main.transform.rotation;
        GetComponent<Slider>().value=player.dam;
	}
}
