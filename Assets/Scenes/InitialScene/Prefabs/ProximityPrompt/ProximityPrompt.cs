/**
 * Prompts a button that the player can press to activate something.
 *
 * Programmer: Christian Toney (https://github.com/Christian-Toney)
 * © 2025 Never Cook Again Group
 */

using UnityEngine;
using UnityEngine.Events;

public class ProximityPrompt : MonoBehaviour
{

  public KeyCode activationKeybind = KeyCode.E;
  public bool isEnabled = true;
  private Canvas canvas;

  public UnityEvent activationEvent = new();

  void Start()
  {

    canvas = transform.GetChild(0).GetComponent<Canvas>();
    canvas.enabled = false;

  }

  void Update()
  {

    if (canvas.enabled && isEnabled && Input.GetKeyDown(KeyCode.E)) {

      activationEvent.Invoke();

    }

  }

  void OnTriggerEnter2D(Collider2D collision)
  {

    canvas.enabled = true;

  }

  void OnTriggerExit2D(Collider2D collision)
  {

    canvas.enabled = false;

  }

}
