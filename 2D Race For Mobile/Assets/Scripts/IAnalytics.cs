using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAnalytics
{
    public void TrackEvent(string alias, IDictionary<string, object> evenData);
}
