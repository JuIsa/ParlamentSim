using UnityEngine;
using Main.Starter;
using Main.Player;

namespace Main
{
    public class Mains : MonoBehaviour
    {
        [SerializeField] private Start_Main startMain;
        [SerializeField] private Player_Main playerMain;

        public static Start_Main StartR => Instance.startMain;
        public static Player_Main Player => Instance.playerMain;



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