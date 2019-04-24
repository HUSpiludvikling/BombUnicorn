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
        damageable = GetComponentInParent<Damageable>();
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateLocalScale();
    }

    private void UpdateLocalScale()
    {
        float ratio = Mathf.Clamp((float)damageable.CurrentHealth / (float)damageable.startingHealth, 0.01f, 0.98f);
        transform.localScale = new Vector3( ratio, transform.localScale.y, transform.localScale.z);
    }
}
