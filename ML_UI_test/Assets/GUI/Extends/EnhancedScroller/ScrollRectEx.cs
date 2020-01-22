﻿using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ScrollRectEx : ScrollRect {

    private bool routeToParent = false;

    public bool IsDragging { get; private set; }
    public Action OnDragReleased;
    
    private int _activePointerId;



    /// <summary>
    /// Do action for all parents
    /// </summary>
    private void DoForParents<T>(Action<T> action) where T : IEventSystemHandler {
        Transform parent = transform.parent;
        while (parent != null) {
            foreach (var component in parent.GetComponents<Component>()) {
                if (component is T)
                    action((T)(IEventSystemHandler)component);
            }
            parent = parent.parent;
        }
    }

    /// <summary>
    /// Always route initialize potential drag event to parents
    /// </summary>
    public override void OnInitializePotentialDrag(PointerEventData eventData) {
        DoForParents<IInitializePotentialDragHandler>((parent) => { parent.OnInitializePotentialDrag(eventData); });
        base.OnInitializePotentialDrag(eventData);
    }

    /// <summary>
    /// Drag event
    /// </summary>
    public override void OnDrag(PointerEventData eventData) {
        if (_activePointerId != eventData.pointerId)
            return;
        
        if (routeToParent)
            DoForParents<IDragHandler>((parent) => { parent.OnDrag(eventData); });
        else
            base.OnDrag(eventData);
    }

    /// <summary>
    /// Begin drag event
    /// </summary>
    public override void OnBeginDrag(PointerEventData eventData) {
        _activePointerId = eventData.pointerId;
        
        if (!horizontal && Math.Abs(eventData.delta.x) > Math.Abs(eventData.delta.y))
            routeToParent = true;
        else if (!vertical && Math.Abs(eventData.delta.x) < Math.Abs(eventData.delta.y))
            routeToParent = true;
        else
            routeToParent = false;

        if (routeToParent)
            DoForParents<IBeginDragHandler>((parent) => { parent.OnBeginDrag(eventData); });
        else {
            base.OnBeginDrag(eventData);
            
            IsDragging = true;
        }
    }

    /// <summary>
    /// End drag event
    /// </summary>
    public override void OnEndDrag(PointerEventData eventData) {
        if (_activePointerId != eventData.pointerId)
            return;
        
        OnDrag(eventData);
        
        if (routeToParent)
            DoForParents<IEndDragHandler>((parent) => { parent.OnEndDrag(eventData); });
        else {
            base.OnEndDrag(eventData);
            
            IsDragging = false;
            if (OnDragReleased != null)
                OnDragReleased();
        }
        
        routeToParent = false;
    }


    protected override void OnDisable() {
        base.OnDisable();
        
        if (IsDragging) {
            IsDragging = false;
            if (OnDragReleased != null)
                OnDragReleased();
        }
    }

}