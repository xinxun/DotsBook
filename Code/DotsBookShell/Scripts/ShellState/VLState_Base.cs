
namespace DotsBook
{
    /// <summary>
    /// 状态机基类 提供基础状态的方法
    /// </summary>
    class VLState_Base : IVLState
    {
        public virtual GAMESTATE_TYPE GetVLEditorState()
        {
            return GAMESTATE_TYPE.GAMESTATE_NONE;
        }

        public virtual bool EnterState()
        {
            return true;
        }


        public virtual void OnUpDate()
        {

        }

        public virtual bool ExitState()
        {
            return true;
        }
    }
}
