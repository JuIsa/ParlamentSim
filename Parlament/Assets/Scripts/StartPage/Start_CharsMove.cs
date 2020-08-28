using System;
using UnityEngine;
using DG.Tweening;

namespace Main.Starter
{
    public class Start_CharsMove : MonoBehaviour
    {
        public GameObject woman, man;

        void Awake()
        {
            Mains.StartR.eConfirmCharacter += MoveCharacters;
        }

        private void MoveCharacters()
        {
            woman.transform.DOMoveY(5f, 0.25f);
            man.transform.DOMoveY(-5f, 0.25f);
        }
    }
}