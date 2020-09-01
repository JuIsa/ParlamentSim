using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

namespace Main.Starter
{
    public class Start_Canvas : MonoBehaviour
    {
        [Header("Intro 1")]
        public RectTransform pageIntro;
        public Text disclaimer1;
        public Text disclaimer2;

        [Header("Page 2 name")]
        public Button next_name;
        public RectTransform pageName;
        public InputField inputName;

        [Header("Page 3 char")]
        public Button next_char;
        public RectTransform pageCharacter;
        public GameObject chars;

        [Header("Page 4 party")]
        public RectTransform pageParty;


        [Header("Page 5 party")]
        public Button start;
        public RectTransform pageOutro;
        public Text txtPrepare;

        private void Awake()
        {
            Mains.StartR.eChooseCharacter += ButtonOn1;

            Mains.StartR.eConfirmCharacter += AfterCharacter;

            Mains.StartR.eConfirmName += AfterName;

            Mains.StartR.eChooseRedParty += AfterParty;

            Mains.StartR.eStartAgitation += StartAgitation;
        }


        private void Start()
        {
            StartCoroutine(ShowAndHideIntro()); 
        }

        #region page intro 1
        private IEnumerator ShowAndHideIntro()
        {
            yield return new WaitForSeconds(4f);
            disclaimer1.DOFade(0f, 0.4f);
            disclaimer2.DOFade(0f, 0.4f);
            yield return new WaitForSeconds(0.45f);
            pageIntro.DOAnchorPos(new Vector2(-2000, 0), 0.1f);
        }
        #endregion

        #region page 2 name
        public void ShowButton()
        {
            if (inputName.text.Length > 2)
            {
                next_name.gameObject.SetActive(true);
            }
        }

        private void AfterName()
        {
            pageName.DOAnchorPos(new Vector2(-2000, 0), 0.3f);
            pageCharacter.DOAnchorPos(new Vector2(0, 0), 0.4f);
            txtPrepare.text = inputName.text + ", " + txtPrepare.text;
            chars.transform.DOMoveX(0f, 0.4f);
        }


        #endregion

        #region page 3 char
        private void ButtonOn1()
        {
            next_char.gameObject.SetActive(true);
        }

        private void AfterCharacter()
        {
            pageCharacter.DOAnchorPos(new Vector2(-2000, 0), 0.3f);
            chars.transform.DOMoveX(4f, 0.3f);
            pageParty.DOAnchorPos(Vector2.zero, 0.4f);
        }

        #endregion

        

        #region page 4 party
        private void AfterParty()
        {
            pageParty.DOAnchorPos(new Vector2(-2000, 0), 0.3f);
            SceneManager.LoadScene("City");
            pageOutro.DOAnchorPos(Vector2.zero, 0.4f);
        }
        #endregion

        #region page 5 start
        private void StartAgitation()
        {
            SceneManager.LoadScene("City");
        }
        #endregion
    }
}