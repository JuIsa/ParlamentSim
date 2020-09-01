using DG.Tweening;

using UnityEngine;

public class City_Quest : MonoBehaviour
{
    public City_Collision collis;
    public GameObject books;
    public GameObject showWay;



    [Header("Windows/Suggest")]
    public RectTransform intro;
    public RectTransform suggestQuest;
    [Header("Window/Finish")]
    public RectTransform final;

    
    public void introOk()
    {
        intro.DOAnchorPos(new Vector2(0f, 2500f), 0.2f);
    }

    public void StartShowingMessages()
    {
        suggestQuest.DOAnchorPos(Vector2.zero, 0.2f);
    }

    #region suggest
    public void QuestAgree()
    {
        books.SetActive(true);
        suggestQuest.DOAnchorPos(new Vector2(0f, 2500f), 0.2f);
    }

    public void QuestCancel()
    {
        suggestQuest.DOAnchorPos(new Vector2(0f, 2500f), 0.2f);
        collis.QuestAgain();
    }

    public void FinishBookQuest()
    {
        final.DOAnchorPos(Vector2.zero, 0.2f);

    }


    public void FinishOk()
    {
        final.DOAnchorPos(new Vector2(0f, 2500f), 0.2f);
        showWay.SetActive(true);
    }
    #endregion


}
