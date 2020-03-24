using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class random_card : MonoBehaviour
{
    public static int card_num;
    public List<Card> cards = new List<Card>();
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<RawImage>().texture = cards[card_num].picture;
        attach.main_card2.GetComponent<RawImage>().texture = cards[card_num].picture;
        attach.ok_button.SetActive(true);
        attach.scroll_text.GetComponent<Text>().text = cards[card_num].text;
    }

    public void OkButton ()
    {
        attach.card_box.SetActive(false);
        attach.main_card2.SetActive(true);
        attach.main_card.SetActive(false);
        attach.scroll.SetActive(true);
        attach.ok_button.SetActive(false);
        attach.restart.SetActive(true);
    }
}

[System.Serializable]

public class Card
{
    public Texture2D picture;
    public string text;
}
