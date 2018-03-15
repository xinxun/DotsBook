
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DotsBook
{
    /// <summary>
    /// loading状态
    /// </summary>
    class VLState_Loading : VLState_Base
    {
        public override GAMESTATE_TYPE GetVLEditorState()
        {
            return GAMESTATE_TYPE.GAMESTATE_LOADING;
        }

        public override bool EnterState()
        {
            base.EnterState();

            //加载loading场景
            if ("loading" != SceneManager.GetActiveScene().name)
            {
                SceneManager.LoadScene("loading");
            }

            return true;
        }

        public override void OnUpDate()
        {
            base.OnUpDate();
        }

        public override bool ExitState()
        {
            base.ExitState();
            return true;
        }
    }
}
