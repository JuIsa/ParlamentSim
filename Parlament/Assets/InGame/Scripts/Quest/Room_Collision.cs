using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Room_Collision : MonoBehaviour
{
    public Room_Quest quest;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ExitRoom"))
        {
            Debug.Log("adad");
            SceneManager.LoadScene("City");
        }
        else if (other.CompareTag("Quest")){
            quest.HitQuest();
        }
        else if (other.CompareTag("Comission"))
        {
            quest.LeaveBook();
        }
    }
}
