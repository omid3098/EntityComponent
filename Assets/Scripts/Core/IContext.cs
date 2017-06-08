using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class IContext : MonoBehaviour
{
    private List<Entity> entities;
    private Transform entityRoot;
    void Awake()
    {
        entities = new List<Entity>();
        entityRoot = new GameObject("Entities").transform;
        entityRoot.transform.SetParent(transform, false);
        Init();
    }
    protected abstract void Init();

    protected Entity CreateEntity()
    {
        var entityGo = new GameObject("entity");
        entityGo.transform.SetParent(entityRoot, false);
        var entity = entityGo.AddComponent<Entity>();
        entities.Add(entity);
        return entity;
    }
}