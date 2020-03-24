using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attach : MonoBehaviour
{
    public static GameObject main_card, scroll_text, scroll, ok_button;
    public static GameObject buttton_start, buttton_advice, card_box, restart, main_card2;
    // Start is called before the first frame update
    void Awake()
    {
        main_card2 = GameObject.Find("main_card2");
        restart = GameObject.Find("restart_button");
        buttton_start = GameObject.Find("start");
        buttton_advice = GameObject.Find("advice");
        card_box = GameObject.Find("card_box");
        main_card = GameObject.Find("main_card");
        scroll = GameObject.Find("Scroll");
        scroll_text = GameObject.Find("scroll text");
        ok_button = GameObject.Find("ok");
        main_card2.SetActive(false);
        restart.SetActive(false);
        ok_button.SetActive(false);
        scroll.SetActive(false);
        main_card.SetActive(false);
    }
}
