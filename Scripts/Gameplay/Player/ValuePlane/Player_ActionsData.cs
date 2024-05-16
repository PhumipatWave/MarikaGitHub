using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Object/Player/Skills Data")]
public class Player_ActionsData : ScriptableObject
{
    public float minDamage, normalDamage, maxDamage, skillHit, manaUsed, manaFill, junibyouFill, 
        minCharge, normalCharge, maxCharge, minSkillLenght, normalLenght, maxSkillLenght;

    public bool isLock;
}
