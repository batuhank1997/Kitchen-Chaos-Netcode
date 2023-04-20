using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keys 
{
    #region AnimationKeys
    public const string ANIM_IS_WALKING = "IsWalking";
    #endregion AnimationKeys

    #region TagKeys
    public const string TAG_UNTAGGED = "Untagged";
    public const string TAG_PLAYER = "Player";
    public const string TAG_FINISH = "Finish";
    public const string TAG_RESPAWN = "Respawn";
    public const string TAG_EDITOR_ONLY = "EditorOnly";
    public const string TAG_MAIN_CAMERA = "MainCamera";
    public const string TAG_TUBE_EXIT_TRIGGER = "TubeExitTrigger";
    public const string TAG_BALL_DESTROYER = "BallDestroyer";
    #endregion TagKeys

    #region LayerKeys
    public const string LAYER_DEFAULT = "Default";
    public const string LAYER_TRANSPARENT_FX = "TransparentFX";
    public const string LAYER_IGNORE_RAYCAST = "Ignore Raycast";
    public const string LAYER_WATER = "Water";
    public const string LAYER_UI = "UI";
    #endregion LayerKeys
}
