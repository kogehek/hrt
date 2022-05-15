using UnityEngine;
namespace ActionUnit
{
       public class Added : MonoBehaviour
    {
        public enum State
        {
            EMPTY_UNIT = 0,
            SELECTED_UNIT = 1,
            SET_UNIT = 2,
        }

        // [System.NonSerialized]
        public State state;
        // [System.NonSerialized]
        public Unit unit;
        private void Start() {
            state = State.EMPTY_UNIT;
        }
        public void Set(State action) {
            this.state = action;
        }
        public State Get() {
            return state;
        }
    }
    
}
