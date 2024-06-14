using UnityEngine;

public class SkillButton : MonoBehaviour
{
    public void OnClick_LevelUp()
    {
        GameLogicManager.Inst.RequestLevelUpDouble();
    }
}
