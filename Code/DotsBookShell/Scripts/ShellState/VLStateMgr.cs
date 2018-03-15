using UnityEngine;

namespace DotsBook
{
    //状态管理器
    public class VLStateMgr
    {
        private static readonly VLStateMgr _instance = new VLStateMgr();
        public static VLStateMgr GetInstance()
        {
            return _instance;
        }

        private VLStateProxy m_StateProxy = null;
	    public bool Init()
        {

            if(m_StateProxy != null)
            {
                return true;
            }
            
            GameObject pGameObject = new GameObject("VLDemoState");
            if (pGameObject == null)
            {
                return false;
            }
            m_StateProxy = pGameObject.AddComponent<VLStateProxy>();
            //不删除
	        GameObject.DontDestroyOnLoad(pGameObject);
            return true;
        }

        public IVLState GetCurState()
        {
            if(m_StateProxy == null)
            {
                return null;
            }
          
            return m_StateProxy.GetCurState();
        }

        //返回是否有切换
	    public bool EnterState(GAMESTATE_TYPE eState = GAMESTATE_TYPE.GAMESTATE_NONE)
        {
            if(m_StateProxy == null)
            {
                return false;
            }
            //退出前一状态
            m_StateProxy.ExitState();
            //创建新状态
            m_StateProxy.SwitchStateByState(eState);
            //进入新状态
            m_StateProxy.EnterState();
            return true;
        }

        //是否在当前状态
        public bool IsState(GAMESTATE_TYPE eState)
        {
            if(m_StateProxy == null)
            {
                return false;
            }
            return m_StateProxy.IsState(eState);
        }
    }
}
