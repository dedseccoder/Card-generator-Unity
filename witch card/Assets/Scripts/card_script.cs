using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class card_script : MonoBehaviour, IPointerDownHandler
{
    public int num;
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log(this.gameObject.name + " Was Clicked.");
        num = Random.Range(0, 9);
        random_card.card_num = num;
        attach.main_card.SetActive(true);
    }

    void Update ()
    {
        if (attach.main_card.activeSelf)
        {
            gameObject.GetComponent<card_script>().enabled = false;
        }
    }
}
