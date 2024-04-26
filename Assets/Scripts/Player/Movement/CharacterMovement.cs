using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private GameObject _fireBoy;
    [SerializeField] private GameObject _waterGirl;

   //] [SerializeField] private float _jumpForce;
    [SerializeField] private float _movementSpeed;
    //[SerializeField] private float _checkRadius;

    [SerializeField] private Rigidbody _rbFireBoy;
    [SerializeField] private Rigidbody _rbWaterGirl;
   // [SerializeField] private Transform _groundCheckerFireBoy;
   // [SerializeField] private Transform _groundCheckerWaterGirl;
  //  [SerializeField] private Animator _animator;

    private bool _isGrounded;
    private float _movement;

    private void Start()
    {
        _rbFireBoy = GetComponent<Rigidbody>();
        _rbWaterGirl = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (_fireBoy)
        {
            _movement = Input.GetAxisRaw("FireBoyHorizontal");
            _rbFireBoy.velocity = new Vector3(_movement * _movementSpeed, _rbFireBoy.velocity.y);
        }
        if (_waterGirl)
        {
            _movement = Input.GetAxisRaw("WaterGirlHorizontal");
            _rbFireBoy.velocity = new Vector3(_movement * _movementSpeed, _rbFireBoy.velocity.y);
        }

    }
}
