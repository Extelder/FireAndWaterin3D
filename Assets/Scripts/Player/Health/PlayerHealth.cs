using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public readonly int MaxValue = 100;
    private float _currentValue;

    private bool _dead;

    public event Action Dead;

    public static PlayerHealth Instance { get; private set; }

    private void Awake()
    {
        if (!Instance)
        {
            Instance = this;
            return;
        }

        Destroy(this);

        throw new Exception("There is on or more more PlayerHealth in scene");
    }

    private void Start()
    {
        Heal(MaxValue);
    }

    public void Kill()
    {
        TakeDamage(MaxValue);
    }

    public void Heal(int value)
    {
        if (_dead)
            return;
        if (_currentValue + value > MaxValue)
        {
            _currentValue = MaxValue;
            return;
        }

        _currentValue += value;
    }

    public void TakeDamage(int value)
    {
        if (_currentValue - value < 0)
        {
            _currentValue = 0;
            _dead = true;
            Dead?.Invoke();
            return;
        }

        _currentValue -= value;
    }
}