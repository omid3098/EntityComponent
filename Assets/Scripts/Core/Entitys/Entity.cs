using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    [SerializeField] public List<IComponent> components = new List<IComponent>();
    public IComponent AddComponent<T>() where T : IComponent
    {
        var component = (T)System.Activator.CreateInstance(typeof(T));
        components.Add(component);
        return component;
    }
}