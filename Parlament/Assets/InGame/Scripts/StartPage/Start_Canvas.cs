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


        [Header("Page 1")]
        public Button next_1;
        public RectTransform pageCharacter;
        [Header("Page 2")]
        public Button next_2;
        public RectTransform pageName;
        public InputField inputName;
        [Header("Page 3")]
        public Button start;
        public RectTransform pageOutro;
        public Text txtPrepare;

        private void Awake()
        {
            Mains.StartR.eChooseCharacter += ButtonOn1;
            Mains.StartR.eConfirmCharacter += AfterCharacter;

            Mains.StartR.eConfirmName += AfterName;

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

        #region page 1
        private void ButtonOn1()
        {
            next_1.gameObject.SetActive(true);
        }

        private void AfterCharacter()
        {
            pageCharacter.DOAnchorPos(new Vector2(-2000, 0), 0.3f);
            pageName.DOAnchorPos(new Vector2(0, 0), 0.4f);
        }

        #endregion

        #region page 2
        public void ShowButton()
        {
            if (inputName.text.Length > 2)
            {
                next_2.gameObject.SetActive(true);
            }
        }

        private void AfterName()
        {
            pageName.DOAnchorPos(new Vector2(-2000, 0), 0.3f);
            pageOutro.DOAnchorPos(new Vector2(0, 0), 0.4f);
            txtPrepare.text = inputName.text + ", " + txtPrepare.text;
        }


        #endregion

        #region page 3
        private void StartAgitation()
        {
            SceneManager.LoadScene("City");
        }
        #endregion
    }
}