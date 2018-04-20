using UnityEngine;
using System.Collections;

namespace LuaFramework {

    /// <summary>
    /// </summary>
    public class Main : MonoBehaviour {

        void Start() {
            Debug.Log("Main Start ....");
            AppFacade.Instance.StartUp();   //启动游戏
        }
    }
}