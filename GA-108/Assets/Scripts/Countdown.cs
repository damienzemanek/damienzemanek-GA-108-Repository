using UnityEngine;
using TMPro;

public class Countdown : MonoBehaviour
{
    [SerializeField] private Cube cube;
    [SerializeField] private TextMeshProUGUI TMP;

    private void OnEnable()
    {
        cube.UpdateCountdown += UpdateCountdown;
    }

    private void OnDisable()
    {
        cube.UpdateCountdown -= UpdateCountdown;
    }

    void UpdateCountdown(int count)
    {
        TMP.text = "" + count;
    }
}
