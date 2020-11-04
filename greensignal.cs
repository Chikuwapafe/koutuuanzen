using UnityEngine;
using System.Collections;

public class greensignal : MonoBehaviour {

    public bool signalflag = true;


	// Use this for initialization
	void Start () {

        StartCoroutine("ChangeColor");

    }

    IEnumerator ChangeColor()
    {
        while (true)
        {

            //"green"を緑色にする
            gameObject.GetComponent<Renderer>().material.color = Color.green;
            signalflag = true;

            //12秒停止
            yield return new WaitForSeconds(12);

            //"green"を黒色にする
            gameObject.GetComponent<Renderer>().material.color = Color.black;
            signalflag = false;

            //22秒停止
            yield return new WaitForSeconds(22);
        }
    }

	// Update is called once per frame
	void Update () {
	
	}
}
