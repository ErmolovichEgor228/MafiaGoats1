using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Vector2 direction;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] GameObject _startButton;
    [SerializeField] GameObject _dialoguePanel;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _startButton.SetActive(false);
        _dialoguePanel.SetActive(false);
    }

    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);
    }

    public void DialogueStart()
    {
        _dialoguePanel.SetActive(true);
        _startButton.SetActive(false);
    }
}
