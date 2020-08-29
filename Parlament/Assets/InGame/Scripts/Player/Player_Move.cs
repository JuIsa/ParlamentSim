using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using UnityEditor;
using UnityEngine;

namespace Main.Player
{
    public class Player_Move : MonoBehaviour
    {
        CharacterController charCtrl;
        public GeneralSettings settings;
        public float smoothRot= 0.1f;
        private float velo;
        void Start()
        {
            charCtrl = GetComponent<CharacterController>();
        }

        // Update is called once per frame
        void Update()
        {
            float hor = SimpleInput.GetAxis("Horizontal");
            float vert = SimpleInput.GetAxis("Vertical");
            Vector3 dir = new Vector3(hor, 0f, vert).normalized;
            if (dir.magnitude>=0.1f){
                float targetAngle = Mathf.Atan2(dir.x, dir.z) * Mathf.Rad2Deg;
                float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref velo, smoothRot);
                transform.rotation = Quaternion.Euler(0f, angle, 0f);
                charCtrl.Move(dir*settings.playerSpeed * Time.deltaTime);
            }
            
        }
    }
}