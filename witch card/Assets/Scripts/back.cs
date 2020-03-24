using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class back : MonoBehaviour
{
   public void back_button ()
    {
        attach.buttton_advice.SetActive(true);
        attach.buttton_start.SetActive(true);
        advice.advicer.SetActive(false);
    }
}
