using TMPro;
using UnityEngine;

public class Clicker : MonoBehaviour
{
    private int _mineScore = 0;

    [SerializeField] private TextMeshProUGUI _mineScoreText;

    public void Click()
    {
        _mineScoreText.text = $"Score: {++_mineScore}";
    }
}
