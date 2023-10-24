using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace SaitoGames.Utilities
{
    public abstract class StateMachine : MonoBehaviour
    {
        protected State _currentState;
        protected Dictionary<Type, State> _states;

        public void ChangeState<T>() where T : State
        {
            // Handles when the current State requests a state change. 
            var t = typeof(T);
            if (_states.TryGetValue(t, out var targetState))
            {
                _currentState.OnStateExit();
                _currentState = targetState;
                _currentState.OnStateEnter();
            }
        }

        protected void StateMachineInit(State initialState, List<State> states)
        {
            _currentState = initialState;
            _states = new Dictionary<Type, State>();

            foreach (var s in states)
            {
                var k = s.GetType();
                _states.Add(k, s);
            }

            _currentState.OnStateEnter();
        }

        protected virtual void Update()
        {
            if (_currentState == null) return;
            _currentState.StateUpdate();
        }

        protected virtual void FixedUpdate()
        {
            if (_currentState == null) return;
            _currentState.StateFixedUpdate();
        }

    }

}