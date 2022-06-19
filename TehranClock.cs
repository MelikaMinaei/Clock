using UnityEngine;
using System;


public class TehranClock : MonoBehaviour
{
    [SerializeField] Transform hourArm, minuteArm, secondArm;
    const float hoursDegree = -30f, minutesDegree = -6f, secondsDegree = -6f;

    void Update()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;
        hourArm.localRotation = Quaternion.Euler(0f, 0f, hoursDegree * (((float)time.TotalHours) + 8));
        minuteArm.localRotation = Quaternion.Euler(0f, 0f, minutesDegree * (((float)time.TotalMinutes) + 30));
        secondArm.localRotation = Quaternion.Euler(0f, 0f, secondsDegree * (float)time.TotalSeconds);
    }
}
