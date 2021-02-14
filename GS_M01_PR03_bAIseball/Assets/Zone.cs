using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zone : MonoBehaviour
{
    public Text text;
    public GameManager gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            text.text = "Homerun!";
            text.color = Color.white;
        }

        if (other.gameObject.tag == "Chaser")
        {
            PlayerOut();
        }

        gm.Invoke("ResetScene", 0.5f);
    }
    

    public void PlayerOut()
    {
        text.text = "Out!";
        text.color = Color.red;
    }
}
