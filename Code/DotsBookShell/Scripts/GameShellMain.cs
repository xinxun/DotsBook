

using System.Collections;
using UnityEngine;

namespace DotsBook
{
    /// <summary>
    /// 主入口
    /// </summary>
    public class GameShellMain : MonoBehaviour
    {
        void Awake()
        {
            //状态机初始化
            VLStateMgr.GetInstance().Init();
            //切换状态机到loadding状态
            VLStateMgr.GetInstance().EnterState(GAMESTATE_TYPE.GAMESTATE_LOADING);
            //该节点场景切换时不被删除
            DontDestroyOnLoad(this);
        }

        void Start()
        {
            //切换状态机到play态
            VLStateMgr.GetInstance().EnterState(GAMESTATE_TYPE.GAMESTATE_PLAY);
        }
    }
}
