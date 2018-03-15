namespace DotsBook
{
    //状态接口类
    public interface IVLState
    {
        GAMESTATE_TYPE GetVLEditorState();
        //进入状态
        bool EnterState();
        //更新
        void OnUpDate();
        //退出状态
        bool ExitState();
    }
}
