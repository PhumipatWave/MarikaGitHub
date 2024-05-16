using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Object/AI/Stats Data")]
public class AIStats_Data : ScriptableObject
{
    public float hp, manaDrop, soulDrop, moveSpeed, jumpPower,
        jumpCooldown, fallSpeed, junibyouDrop;
}