using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillsTree : MonoBehaviour
{
    public void OnePointOnClick()
    {
        PlayerPrefs.SetInt("pointsadd", 1);
    }
    public void TwoPointsOnClick()
    {
        PlayerPrefs.SetInt("pointsadd", 2);
    }
    public void ThreePointsOnClick()
    {
        PlayerPrefs.SetInt("pointsadd", 3);
    }
    public void FourPointsOnClick()
    {
        PlayerPrefs.SetInt("pointsadd", 4);
    }
    public void FivePointsOnClick()
    {
        PlayerPrefs.SetInt("pointsadd", 5);
    }
    public void SixPointsOnClick()
    {
        PlayerPrefs.SetInt("pointsadd", 6);
    }
}
