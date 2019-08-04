using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class y : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Onclick()
    {
        SceneManager.LoadScene("打章鱼");
        GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -313);
    }
}
