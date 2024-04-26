using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagableSurface : MonoBehaviour, IDamagable
{
    [SerializeField] private TypeOfCharacter _tolerantTypeOfCharacter;

    public void Damage(TypeOfCharacter typeOfCharacter)
    {
        if (_tolerantTypeOfCharacter != typeOfCharacter)
            PlayerHealth.Instance.Kill();
    }
}