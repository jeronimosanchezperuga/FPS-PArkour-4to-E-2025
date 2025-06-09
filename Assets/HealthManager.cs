﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int healthPoints;
    public UIManager uiManager;

    // Start is called before the first frame update
    void Start()
    {
        uiManager.UpdateHealthText(healthPoints.ToString());
    }

    public void UpdateHealth(int damageAmount)
    {
        if (healthPoints + damageAmount <= 0)
        {
            Debug.Log("Game Over");
            healthPoints = 0;
            uiManager.UpdateHealthText(healthPoints.ToString());
            return;
        }

        healthPoints += damageAmount;
        uiManager.UpdateHealthText(healthPoints.ToString());
    }

    void GameOverActions()
    {

    }
    
}
