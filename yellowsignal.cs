using UnityEngine;
using System.Collections;

public class yellowsignal : MonoBehaviour {

    public bool signalflag = false;

	// Use this for initialization
	void Start () {

        StartCoroutine("ChangeColor");

    }

    IEnumerator ChangeColor()
    {

        //"yellow"を黒色にする
        gameObject.GetComponent<Renderer>().material.color = Color.black;
        signalflag = false;

        //12秒停止
        yield return new WaitForSeconds(12);

        while (true)
        {

            //"yellow"を黄色にする
            gameObject.GetComponent<Renderer>().material.color = Color.yellow;
            signalflag = true;

            //3秒停止
            yield return new WaitForSeconds(3);

            //"yellow"を黒色にする
            gameObject.GetComponent<Renderer>().material.color = Color.black;
            signalflag = false;

            //31秒停止
            yield return new WaitForSeconds(31);

        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
