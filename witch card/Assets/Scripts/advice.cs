using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class advice : MonoBehaviour
{
    public static GameObject advicer;
   public void Advice_button ()
    {
        attach.buttton_start.SetActive(false);
        attach.buttton_advice.SetActive(false);
        advicer.SetActive(true);
    }
    private void Awake()
    {
        advicer = GameObject.Find("simple backgrounde");
    }
    private void Start()
    {
        advicer.SetActive(false);
    }
}
