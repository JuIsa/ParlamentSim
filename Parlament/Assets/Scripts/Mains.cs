using UnityEngine;
using Main.Starter;

namespace Main
{
    public class Mains : MonoBehaviour
    {
        [SerializeField] private Start_Main startMain;


        public static Start_Main StartR => Instance.startMain;



        private static Mains _instance;
        private static Mains Instance
        {
            get
            {
                if (_instance == null)
                    _instance = GameObject.FindGameObjectWithTag(Tags.Mains)?.GetComponent<Mains>();
                return _instance;
            }
        }
    }
}