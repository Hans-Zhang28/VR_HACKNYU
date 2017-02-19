using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timeTF;
    int currentTime;

    void Start()
    {
        currentTime = 0;
        timeTF.text = "TIME: 90";
        InvokeRepeating("ReduceTime", 1, 1);
    }

    void ReduceTime()
    {
        if (timeTF.text == "1")
        {
            /* Alert */

            Time.timeScale = 0;
            //Instantiate(alertReference, new Vector3(0.5f, 0.5f, 0), transform.rotation);
        }

        timeTF.text = (int.Parse(timeTF.text) - 1).ToString();
    }

}
