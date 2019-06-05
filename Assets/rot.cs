using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rot : MonoBehaviour
{

    public Transform cannon;
    public float currentangle;
    public static float angle;
    public Text scorebrd;
    public GameObject go,cont;
    public Text got;


    private void Update()
    {
        angle = cannon.eulerAngles.z;
        scorebrd.text = "Score: " + shootscrpt.score.ToString();
        if (bugcontrol.fin == true)
        {
            got.text = "Game Over\nScore: " + shootscrpt.score.ToString();
            go.SetActive(true);
            Time.timeScale = 0f;
            cont.SetActive(false);
        }
    }

    public void leftrot()
    {
        currentangle = cannon.eulerAngles.z;
        currentangle = (currentangle + 5f) % 180;
        cannon.eulerAngles = new Vector3(0f,0f,currentangle);
    }

    public void rightrot()
    {
        currentangle = cannon.eulerAngles.z;
        currentangle = (currentangle - 5f) % 180;
        cannon.eulerAngles = new Vector3(0f, 0f, currentangle);
    }

   
}
