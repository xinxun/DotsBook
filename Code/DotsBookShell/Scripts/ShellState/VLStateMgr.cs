using UnityEngine;

namespace DotsBook
{
    //״̬������
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
            //��ɾ��
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

        //�����Ƿ����л�
	    public bool EnterState(GAMESTATE_TYPE eState = GAMESTATE_TYPE.GAMESTATE_NONE)
        {
            if(m_StateProxy == null)
            {
                return false;
            }
            //�˳�ǰһ״̬
            m_StateProxy.ExitState();
            //������״̬
            m_StateProxy.SwitchStateByState(eState);
            //������״̬
            m_StateProxy.EnterState();
            return true;
        }

        //�Ƿ��ڵ�ǰ״̬
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
