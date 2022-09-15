using UnityEngine;

public class Ore : MonoBehaviour
{
    private Vector2 _normalScale;
    private Vector2 _clickedScale;

    [SerializeField] private Clicker _clicker;

    private void Awake()
    {
        var scaleDifference = 0.05f;

        _normalScale = transform.localScale;
        _clickedScale = new Vector2(transform.localScale.x - scaleDifference, transform.localScale.y - scaleDifference);
    }

    private void OnMouseDown()
    {
        transform.localScale = _clickedScale;
    }

    private void OnMouseUp()
    {
        transform.localScale = _normalScale;
        _clicker.Click();
    }
}
