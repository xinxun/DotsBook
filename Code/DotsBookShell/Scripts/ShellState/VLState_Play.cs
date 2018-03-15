

using UnityEngine.SceneManagement;

namespace DotsBook
{
    /// <summary>
    /// play状态
    /// </summary>
    class VLState_Play : VLState_Base
    {
        public override GAMESTATE_TYPE GetVLEditorState()
        {
            return GAMESTATE_TYPE.GAMESTATE_PLAY;
        }

        public override bool EnterState()
        {
            base.EnterState();
            //加载play场景
            SceneManager.LoadScene("play");
 
            return true;
        }

        public override bool ExitState()
        {
            base.ExitState();
            return true;
        }

        public override void OnUpDate()
        {
            base.OnUpDate();
        }
    }
}
