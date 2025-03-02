using UnityEngine;

public class TimeManager : MonoBehaviour
{
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }

    private void FastForward()
    {
        SetTimeScale(2);
    }

    private void SetTimeScale(float timeScale)
    {
        Time.timeScale = timeScale;
    }
}
