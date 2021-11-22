using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public interface IAdsShowed
{
    public void ShowInterstitial();


    public void ShowRewarded(Action OnSuccess);
   
}
