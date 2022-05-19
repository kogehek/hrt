using UnityEngine.UI;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

namespace Input
{
    [System.Serializable]
    public class OnPositionCursor : UnityEvent<Vector3>
    {
    }

    public class AddedUnit : MonoBehaviour
    {
        public OnPositionCursor onPositionCursor;

        public void OnСancel(InputValue val)
        {
            if (val.isPressed)
            {
                // added.Update(ActionUnit.Added.State.EMPTY_UNIT);
            }
        }

        public void OnSelect(Unit unit)
        {
            // added.unit = unit;
            // added.Update(ActionUnit.Added.State.SELECTED_UNIT);
        }
        public void OnPosition(InputValue val)
        {
            Vector3 mousePos = val.Get<Vector2>();
            onPositionCursor.Invoke(mousePos);
        }
    }
}

