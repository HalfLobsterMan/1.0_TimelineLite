#region 注 释
/***
 *
 *  Title:
 *  
 *  Description:
 *  
 *  Date:
 *  Version:
 *  Writer: 半只龙虾人
 *  Github: https://github.com/HalfLobsterMan
 *  Blog: https://www.crosshair.top/
 *
 */
#endregion
using CZToolKit.TimelineLite;
using System;
using UnityEngine;

namespace CZToolKit.TimelineLite
{
    [Serializable]
    public class SetTimeScaleTLAction : TLAction<SetTimeScaleTLActionData>
    {
        float timeScale;

        /// <summary> 不能删 </summary>
        public SetTimeScaleTLAction() { }

        /// <summary> 不能删 </summary>
        public SetTimeScaleTLAction(ITLTrack _track, SetTimeScaleTLActionData _actionData) : base(_track, _actionData) { }

        protected override void OnGraphStart()
        {
            timeScale = Time.timeScale;
        }

        protected override void OnUpdateAction(float _timeSinceActionStart)
        {
            Time.timeScale = TActionData.timeScale;
        }

        protected override void OnActionFinish()
        {
            Time.timeScale = timeScale;
        }

        protected override void OnActionStop()
        {
            Time.timeScale = timeScale;
        }
    }
}