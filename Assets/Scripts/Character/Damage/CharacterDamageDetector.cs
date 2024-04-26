using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TypeOfCharacter
{
    Fire,
    Water
}
public class CharacterDamageDetector : MonoBehaviour
{
    [SerializeField] private TypeOfCharacter _typeOfCharacter;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<IDamagable>(out IDamagable iDamagable))
        {
            iDamagable.Damage(_typeOfCharacter);
        }
    }
}