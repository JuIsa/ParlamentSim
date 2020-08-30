using System;
using UnityEngine;

namespace Main.Starter
{
    public class Start_Main : MonoBehaviour
    {
        public event Action eConfirmCharacter;
        public event Action eChooseCharacter;

        public event Action eConfirmName;

        public event Action eChooseRedParty;
        public event Action eChooseBlueParty;

        public event Action eStartAgitation;

        public GeneralSettings settings;

        public Start_Canvas sCanvas;
        public Start_CharsMove schars;

        public void ConfirmCharacterMethod() => eConfirmCharacter?.Invoke();

        public void ChooseCharacterMethod() => eChooseCharacter?.Invoke();

        public void ConfirmNameMethod() => eConfirmName?.Invoke();

        public void RedParty() => eChooseRedParty?.Invoke();

        public void BluePart() => eChooseBlueParty?.Invoke();

        public void StartAgitation() => eStartAgitation?.Invoke();



    }
}