using System;

namespace FlappyBird
{
    public class UIStateManager : StateManager

    {
        UIState _activeUIState = UIState.MAINMENU;

        public override void Awake()
        {
            base.Awake();
            LoadUIPanels();
            ChangeState(UIState.MAINMENU);
        }

        void Start()
        {

        }

        public override void ChangeState(Enum nextState)
        {
            stateList[(int)_activeUIState].Exit();
            this._activeUIState = (UIState)nextState;
            stateList[(int)_activeUIState].Begin(this);
        }

    }
}
