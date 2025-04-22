/**
 * Prompts a button that the player can press to activate something.
 *
 * Programmer: Christian Toney (https://github.com/Christian-Toney)
 * © 2025 Never Cook Again Group
 */

using System;
using UnityEngine;
using UnityEngine.Events;

public class ProximityPrompt : MonoBehaviour
{

  public KeyCode activationKeybind = KeyCode.E;
  public Boolean isEnabled = true;
  private Canvas canvas;

  public UnityEvent activationEvent = new();

  void Start()
  {

    this.canvas = transform.GetChild(0).GetComponent<Canvas>();

  }

  void Update()
  {

    if (this.canvas.enabled && this.isEnabled && Input.GetKeyDown(KeyCode.E)) {

      activationEvent.Invoke();

    }

  }

  void OnTriggerEnter2D(Collider2D collision)
  {

    this.canvas.enabled = true;

  }

  void OnTriggerExit2D(Collider2D collision)
  {

    this.canvas.enabled = false;

  }

}
