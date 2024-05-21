using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private Transform _transform;

    [Header("Parameters")]
    [SerializeField] private float _shipRotationSpeed;

    // Update is called once per frame
    private void Update()
    {
        if (!GameManager.Instance.IsAlive) return;
        HandleAcceletation();
        HandleRotation();
        HandleBullets();
    }
    
    private void FixedUpdate()
    {
        
    }

    private void HandleAcceletation()
    {
        
    }
    
    private void HandleBullets()
    {
        
    }

    

    // TODO: new input system
    private bool RotatingLeft => Input.GetKey(KeyCode.LeftArrow); 
    private bool RotatingRight => Input.GetKey(KeyCode.RightArrow); 
    
    
    private void HandleRotation()
    {
        if (RotatingLeft)
        {
            _desiredRotation = _transform.rotation.eulerAngles +
                                  _shipRotationSpeed * Time.deltaTime * transform.forward;
        }
        else if (RotatingRight)
        {
            transform.Rotate(_shipRotationSpeed * Time.deltaTime * transform.forward * -1);
        }
    }
}
