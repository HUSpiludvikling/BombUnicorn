using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Gamekit2D;

public class HealthBar : MonoBehaviour
{
    [SerializeField]
    Damageable damageable;

    
    
    // Start is called before the first frame update
    void Start()
    {
        damageable = transform.parent.GetComponentInParent<Damageable>();
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateLocalScale();
    }

    private void UpdateLocalScale()
    {
        transform.localScale = new Vector3(damageable.CurrentHealth / damageable.startingHealth, transform.localScale.y, transform.localScale.z);
    }
}
