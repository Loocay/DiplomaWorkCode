using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHandler : MonoBehaviour
{
    [SerializeField] Canvas gameOverCanvas;
    private FirstPersonController controller;

    private void Start()
    {
        gameOverCanvas.enabled = false;
        controller = GetComponent<FirstPersonController>();
    }

    public void HandleDeath()
    {
        gameOverCanvas.enabled = true;
        Time.timeScale = 0f;
        controller.enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        GetComponentInChildren<Weapon>().enabled= false;
    }
}
