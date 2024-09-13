using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timerDuration = 30f;
    [SerializeField] private TextMeshProUGUI timerText;
    public float timer;

    void Start()
    {
        timer = timerDuration;
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if (timerText != null)
        {
            timerText.text = Mathf.Ceil(timer).ToString() + "s";
        }
    }
}