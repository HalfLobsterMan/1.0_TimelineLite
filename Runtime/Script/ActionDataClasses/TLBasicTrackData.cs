﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace CZToolKit.TimelineLite
{
    /// <summary> 标准轨道数据类 </summary>
    [Serializable]
    public class TLBasicTrackData : TLTrackData
    {
        [SerializeField]
#if UNITY_2019_1_OR_NEWER
        [SerializeReference]
# endif
        private List<TLActionData> clips = new List<TLActionData>();

        public List<TLActionData> Clips { get { return clips; } }
    }
}