namespace DotsBook
{
    //״̬�ӿ���
    public interface IVLState
    {
        GAMESTATE_TYPE GetVLEditorState();
        //����״̬
        bool EnterState();
        //����
        void OnUpDate();
        //�˳�״̬
        bool ExitState();
    }
}
