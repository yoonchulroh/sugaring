using UnityEngine;

public class UIManager : MonoBehaviour
{
    public void OnClickRestartButton()
    {
        GameManager.Instance.timeManager.Restart();
    }
}
