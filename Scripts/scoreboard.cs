using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class scoreboard : MonoBehaviour {
	// Use this for initialization
	void Start () {
           
	}
	
	// Update is called once per frame
	void Update () {
        GameObject.Find("Canvas/Text").GetComponent<Text>().text = "分数："+poulpi.score;
	}
}
