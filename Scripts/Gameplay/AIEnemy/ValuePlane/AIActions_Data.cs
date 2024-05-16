using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Object/AI/Skills Data")]
public class AIActions_Data : ScriptableObject
{
    public float damage, skillHit, normalCharge, lenght;

    public bool isLock;
}
