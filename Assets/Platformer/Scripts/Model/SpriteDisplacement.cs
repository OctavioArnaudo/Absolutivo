using UnityEngine;

/// <summary>
/// 
/// Represents the orientation of a sprite in a 2D game.
/// 
/// This scriptable object can be used to define how a sprite should be oriented
/// 
/// in relation to its displacement. It can be used to adjust the sprite's position
/// 
/// and alignment based on the specified orientation.
/// 
/// </summary>
[CreateAssetMenu(fileName = "SpriteDisplacement", menuName = "Custom/Sprite Orientation", order = 1)]
public class SpriteDisplacement : ScriptableObject
{
    /// <summary>
    /// 
    /// Enum representing the possible orientations of a sprite.
    /// 
    /// </summary>
    public DisplacementOrientation orientation = DisplacementOrientation.Centered;
}