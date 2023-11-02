using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuPanel;
    [SerializeField] private Rigidbody2D rbShip;

    public bool isStart;
    float shipFallSpeed = 0;
    public void PlayGame()
    {
        mainMenuPanel.SetActive(false);
        rbShip.gravityScale = 1;
        isStart = true;
    }

    private void Update()
    {
        if (isStart)
        {
            // Tinh diem cho player
            // Tang gia tri de ship roi nhanh hon
            shipFallSpeed = Mathf.MoveTowards(shipFallSpeed, Constants.MAX_SPEED, 0.5f * Time.deltaTime);
        }
        rbShip.velocity = new Vector2(0, -shipFallSpeed);
    }
}
