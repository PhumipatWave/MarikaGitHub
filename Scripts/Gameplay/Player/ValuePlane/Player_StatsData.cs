using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Object/Player/Stats Data")]
public class Player_StatsData : ScriptableObject
{
    public float Hp, Mana, ManaRecharge, Junibyou, MoveSpeed, JumpPower, 
        JumpDuration, JumpCooldown, FallSpeed, DashPower, DashDuration, DashCooldown;
}
