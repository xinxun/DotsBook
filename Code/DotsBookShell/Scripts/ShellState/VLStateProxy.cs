using UnityEngine;

namespace DotsBook
{
    //编辑状态的代理器，
    class VLStateProxy : MonoBehaviour, IVLState
    {
        private IVLState m_curState = null;//当前状态
        [SerializeField]
        private GAMESTATE_TYPE m_eCurState = GAMESTATE_TYPE.GAMESTATE_NONE;

        void Awake()
        {
            if(m_curState == null)
            {
                m_curState = SwitchStateByState(GAMESTATE_TYPE.GAMESTATE_NONE);
            }
        }

        void Update()
        {//此处代码是方便用户测试状态使用, 请不要在此处加入代码
            //+++++++++++++++++++++begine 不可加入代码+++++++++++++++++++++++++++++
            
            if (m_curState == null)
            {
                return;
            }
            OnUpDate();
            if (m_eCurState == m_curState.GetVLEditorState())
            {
                return;
            }
            ExitState();
            SwitchStateByState(m_eCurState);
            EnterState();
            //++++++++++++++++++++++end 不可加入代码++++++++++++++++++++++++++++
           
        }
        //选择状态
        public IVLState SwitchStateByState(GAMESTATE_TYPE eStateType)
        {
            m_eCurState = eStateType;
            switch (eStateType)
            {
                case GAMESTATE_TYPE.GAMESTATE_LOADING:
                    m_curState = new VLState_Loading();
                    break;
                case GAMESTATE_TYPE.GAMESTATE_PLAY:
                    m_curState = new VLState_Play();
                    break;
                default:
                    m_curState = new VLState_Base();
                    m_eCurState = GAMESTATE_TYPE.GAMESTATE_NONE;
                    break;
            }
            return m_curState;
        }
        //进入状态
        public bool EnterState()
        {
            if(m_curState != null)
            {
                return m_curState.EnterState();
            }
            return false;
        }

        public void OnUpDate()
        {
            if (m_curState != null)
            {
                m_curState.OnUpDate();
            }
        }
        //退出状态
        public bool ExitState()
        {
            if (m_curState != null)
            {
                return m_curState.ExitState();
            }
            return false;
        }

        public IVLState GetCurState()
        {
            return m_curState;
        }

        public bool IsState(GAMESTATE_TYPE eState)
        {
            if (m_eCurState == eState)
            {
                return true;
            }
            return false;
        }

        public GAMESTATE_TYPE GetVLEditorState()
        {
            if(m_curState == null)
            {
                return GAMESTATE_TYPE.GAMESTATE_NONE;
            }
            return m_curState.GetVLEditorState();
        }


    }
}
