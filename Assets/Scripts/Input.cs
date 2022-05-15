using UnityEngine.UI;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;
// using ActionUnit;

public class Input : MonoBehaviour
{
	UnityEvent Cancel;
    public ActionUnit.Added added;

	public void OnСancel(InputValue val)
    {
		if (val.isPressed) {
			added.Set(ActionUnit.Added.State.EMPTY_UNIT);
		}
	}

	public void OnSelect(Unit unit) {
		added.unit =  unit;
		added.Set(ActionUnit.Added.State.SELECTED_UNIT);
	}
}
