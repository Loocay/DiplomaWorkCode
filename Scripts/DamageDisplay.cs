using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDisplay : MonoBehaviour
{

    [SerializeField] Canvas damageCanvas;
    [SerializeField] float damageTime = 0.3f;


    // Start is called before the first frame update
    void Start()
    {   
        damageCanvas.enabled = false;
    }

    public void ShowDamage()
    {
        StartCoroutine(Splatter());
    }

    IEnumerator Splatter()
    {
        damageCanvas.enabled = true;
        yield return new WaitForSeconds(damageTime);
        damageCanvas.enabled = false;
    }
} 
