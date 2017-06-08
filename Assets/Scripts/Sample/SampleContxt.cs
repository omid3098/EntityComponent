using System;
using UnityEngine;

public class SampleContxt : IContext
{
    protected override void Init()
    {
        Debug.Log("Initializeing the game.");
        var t = CreateEntity();
        t.AddComponent<ViewComponent>();
    }
}