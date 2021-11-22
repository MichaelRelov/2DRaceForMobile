using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class UnityAnalyticsHandler : IAnalytics
{
    public void TrackEvent(string alias, IDictionary<string, object> evenData)
    {
        if (evenData == null)
        {
            evenData = new Dictionary<string, object>();
        }
        Analytics.CustomEvent(alias, evenData);
    }
}
