using System;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;

namespace Main.Starter
{
    public class Start_Main : MonoBehaviour
    {
        public event Action eConfirmCharacter;
        public event Action eChooseCharacter;

        public event Action eConfirmName;

        public event Action eStartAgitation;

        public GeneralSettings settings;

        public Start_Canvas sCanvas;

        public void ConfirmCharacterMethod() => eConfirmCharacter?.Invoke();

        public void ChooseCharacterMethod() => eChooseCharacter?.Invoke();

        public void ConfirmNameMethod() => eConfirmName?.Invoke();


        public void StartAgitation() => eStartAgitation?.Invoke();



    }
}