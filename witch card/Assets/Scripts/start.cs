using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
    private void Start()
    {
        attach.card_box.SetActive(false);
        Debug.Log("Starts");
    }

    public void start_button()
    {
        attach.buttton_advice.SetActive(false);
        attach.buttton_start.SetActive(false);
        attach.card_box.SetActive(true);
    }
}
