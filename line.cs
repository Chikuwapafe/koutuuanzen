using UnityEngine;
using System.Collections;

public class line : MonoBehaviour {

    bool flag;
    bool flag1;
    GameObject[] liner;
    line linescript;
    bool gflag;
    bool yflag;
    greensignal grscript;
    yellowsignal ylscript;
    public GameObject green;
    public GameObject yellow;


    void Start()
    {

        green = GameObject.Find("green");

        grscript = green.GetComponent<greensignal>();

        yellow = GameObject.Find("yellow");

        ylscript = green.GetComponent<yellowsignal>();

    }

    /*IEnumerator ChangeColor()
    {

        while (true)
        {
            //"line1"を緑色にする
            gameObject.GetComponent<Renderer>().material.color = Color.green;

            flag = true;

            //15秒停止
            yield return new WaitForSeconds(15);

            //"line1"を赤色にする
            gameObject.GetComponent<Renderer>().material.color = Color.red;

            flag = false;

            //19秒停止
            yield return new WaitForSeconds(19);
        }
    }*/

    // Update is called once per frame
    void Update()
    {
        //nullチェック
        if (grscript.signalflag == null || ylscript.signalflag == null)
        {
            Debug.Log("null");
            gflag = grscript.signalflag;
            yflag = ylscript.signalflag;
            flag1 = true;
        }

        if(flag1)
        {
            Debug.Log("not null");
            gflag = grscript.signalflag;
            yflag = ylscript.signalflag;
        }

        if (gflag || yflag)
        {
            //"line1"を緑色にする
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        else
        {
            //"line1"を赤色にする
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }

    }

    //ほかのオブジェクトがこのオブジェクトを通過したとき
    void OnTriggerEnter(Collider collider)
    {
        liner = GameObject.FindGameObjectsWithTag("linetag");

        if (flag)
        {
            Debug.Log("ok!");
            foreach (GameObject line1 in liner)
            {
                Destroy(line1);
            }
        }
        else
        {
            Debug.Log("out!");
            foreach (GameObject line1 in liner)
            {
                Destroy(line1);
                
            }
        }
    }

}
