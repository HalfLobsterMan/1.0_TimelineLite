﻿using CZToolKit.TimelineLite;
using System;
using UnityEngine;
using UnityEngine.Timeline;

namespace CZToolKit.TimelineLite.Example
{
    [Serializable]
    [TrackColor(0.96f, 0.44f, 0.47f)]
    [TLTrackAssetMenuItem("Example/插值旋转")]
    [TrackClipType(typeof(TweenRotationTLClipAsset))]
    public class TweenRotationTLTrackAsset : TLBasicTrackAsset
    {
        // 若有需求可返回自定义的轨道数据对象
        public override TLBasicTrackData CreateTrackData()
        {
            TLBasicTrackData trackData = new TLBasicTrackData();

            return trackData;
        }
    }
}
