using System.Collections;
using UnityEngine;

namespace Main.Starter
{
    public class Start_Regist : MonoBehaviour
    {
        public bool saveName;
        private Coroutine cor;
        private bool isAMan;
        private bool firstTouch;
      
        private void Awake()
        {
            Mains.StartR.eConfirmName += SaveName;
        }

        private void SaveName()
        {
            if(saveName)
                PlayerPrefs.SetString("name", Mains.StartR.sCanvas.inputName.text.ToString());
        }

        private void Update()
        {
#if UNITY_EDITOR
            DetectMouse();
#else
            DetectTouch();      
#endif


        }


        private void DetectTouch()
        {
            if (Input.touchCount > 0)
                CastRayToPosition(Input.GetTouch(0).position);
        }

        private void DetectMouse()
        {
            if (Input.GetMouseButton(0))
                CastRayToPosition(Input.mousePosition);

        }

        private void CastRayToPosition(Vector3 position)
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(position);
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                firstTouch = true;
                if (cor != null)
                    StopCoroutine(cor);
                Debug.Log(hit.transform.gameObject);
                Mains.StartR.ChooseCharacterMethod();


                if (hit.transform.CompareTag(Tags.Man))
                    ChooseMan(hit.transform.gameObject);
                else
                    ChooseWoman(hit.transform.gameObject);


            }
        }

        private void ChooseWoman(GameObject go)
        {
            isAMan = false;
            PlayerPrefs.SetInt("sex", 0);
            cor = StartCoroutine(RotateCharacters(go));

        }

        private void ChooseMan(GameObject go)
        {
            PlayerPrefs.SetInt("sex", 1);
            isAMan = true;
            cor = StartCoroutine(RotateCharacters(go));

        }

        private IEnumerator RotateCharacters(GameObject go)
        {
            while (true)
            {
                go.transform.Rotate(0, Mains.StartR.settings.charactersSpeedOfRotation * Time.deltaTime, 0);
                yield return null;
            }

        }


    }
}