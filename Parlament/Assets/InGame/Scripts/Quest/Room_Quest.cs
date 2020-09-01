using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Room_Quest : MonoBehaviour
{
    public event Action ePlayerHitQuest;
    public event Action eShowQuestion;


    public GameObject showWay;
    public GameObject book;

    public Transform table;

    public GameObject signQuest;
    public GameObject signComiss;


    public void HitQuest()
    {
        ePlayerHitQuest?.Invoke();
    }

    public void LeaveBook()
    {
        Vector3 newPos = new Vector3(table.position.x, table.position.y + 1.5f, table.position.z);
        book.transform.parent = null;
        book.transform.position = newPos;
        signComiss.SetActive(false);
        eShowQuestion?.Invoke();
    }

    

}
