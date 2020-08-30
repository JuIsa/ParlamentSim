
using UnityEngine;
using UnityEngine.SceneManagement;

public class City_Collision : MonoBehaviour
{

    public City_Quest quest;

    private int count = 0;
    private GameObject questSign;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Quest"))
        {
            questSign = other.gameObject;
            other.gameObject.SetActive(false);
            quest.StartShowingMessages();
        }
        else if (other.CompareTag("Book"))
        {
            other.gameObject.SetActive(false);
            count++;
            if (count == 5)
            {
                quest.FinishBookQuest();
            }
        }else if (other.CompareTag("EnterRoom"))
        {
            SceneManager.LoadScene("Office");
        }
    }

    public void QuestAgain()
    {
        questSign.SetActive(true);
    }

}
