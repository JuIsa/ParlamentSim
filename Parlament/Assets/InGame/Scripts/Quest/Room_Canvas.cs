using DG.Tweening;

using UnityEngine;
using UnityEngine.UI;

public class Room_Canvas : MonoBehaviour
{
    public Room_Quest quest;

    [Header("Suggestion")]
    public RectTransform suggestion;

    public RectTransform billWhich;
    public RectTransform billMedicine;
    public RectTransform billEducation;

    public RectTransform instruction;

    [Header("Question")]
    public RectTransform comissionQ;
    public GameObject hint;
    public InputField answer;

    public RectTransform win;
    public GameObject lose;

    private void Awake()
    {
        quest.ePlayerHitQuest += ShowSuggestion;
        quest.eShowQuestion += ShowQuestion;
    }

    private void ShowSuggestion()
    {
        suggestion.DOAnchorPos(Vector2.zero, 0.2f);
    }

    public void QuestAgree()
    {
        suggestion.DOAnchorPos(new Vector2(0, 2500), 0.2f);
        billWhich.DOAnchorPos(Vector2.zero, 0.2f);        
    }

    public void QuestCancel()
    {
        suggestion.DOAnchorPos(new Vector2(0, 2500), 0.2f);
    }

    #region medicine
    public void ShowMedicine()
    {
        billWhich.DOAnchorPos(new Vector2(0, 2500), 0.2f);
        billMedicine.DOAnchorPos(Vector2.zero, 0.2f);
    }

    public void MedicineAgree()
    {
        billMedicine.DOAnchorPos(new Vector2(0, 2500), 0.2f);
        instruction.DOAnchorPos(Vector2.zero, 0.2f);
    }

    public void MedicineCancel()
    {
        billWhich.DOAnchorPos(Vector2.zero, 0.2f);
        billMedicine.DOAnchorPos(new Vector2(0, -2500), 0.2f);
    }

    public void InstrOk()
    {
        instruction.DOAnchorPos(new Vector2(0, 2500), 0.2f);
        quest.showWay.SetActive(true);
        quest.book.SetActive(true);
        quest.signQuest.SetActive(false);
        quest.book.transform.parent = this.transform;
    }


    #endregion

    #region edu
    public void ShowEducation()
    {
        billWhich.DOAnchorPos(new Vector2(0,2500), 0.2f);
        billEducation.DOAnchorPos(Vector2.zero, 0.2f);
    }

    public void EduAgree()
    {
        billEducation.DOAnchorPos(new Vector2(0, 2500), 0.2f);
        instruction.DOAnchorPos(Vector2.zero, 0.2f);
    }

    public void EduCancel()
    {
        billWhich.DOAnchorPos(Vector2.zero, 0.2f);
        billEducation.DOAnchorPos(new Vector2(0, -2500), 0.2f);
    }

    #endregion

    public void ShowQuestion()
    {
        comissionQ.DOAnchorPos(Vector2.zero, 0.2f);
    }

    public void ShowHint()
    {
        hint.SetActive(true);
    }

    public void CheckAnswer()
    {
        if (answer.text == "5")
            ShowWin();
        else
            ShowLose();
        
    }

    public void ShowWin()
    {
        comissionQ.DOAnchorPos(new Vector2(0, 2500), 0.2f);
        win.DOAnchorPos(Vector2.zero, 0.2f);
    }

    public void ShowLose()
    {
        lose.SetActive(true);
    }

    public void billBack()
    {
        win.DOAnchorPos(new Vector2(0, 2500), 0.2f);
        quest.book.transform.parent = this.transform;
    }
}
