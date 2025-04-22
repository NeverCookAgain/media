using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public enum BurnLevel {
  NotCooked,
  Cooked,
  Burnt
}

public abstract class Item : MonoBehaviour
{

    public Sprite Sprite;
    protected BurnLevel burnLevel = BurnLevel.NotCooked;
    public Dictionary<BurnLevel, Color32> colors = new();
    public UnityEvent onBurnLevelChange;

    void Awake() {

      colors.Add(BurnLevel.NotCooked, new Color32(255, 255, 255, 255));
      colors.Add(BurnLevel.Cooked, new Color32(252, 224, 146, 255));
      colors.Add(BurnLevel.Burnt, new Color32(51, 43, 19, 255));

    }

    public void SetBurnLevel(BurnLevel burnLevel) {

      this.burnLevel = burnLevel;
      this.onBurnLevelChange.Invoke();

    }

    public BurnLevel GetBurnLevel() {

      return burnLevel;

    } 

    public abstract void Activate();
}
