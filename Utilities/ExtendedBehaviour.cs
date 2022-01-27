using System;
using UnityEngine;

namespace SaitoGames.Utilities
{
    public struct BehaviourParams
    {
        public readonly Type Type;
        public readonly object[] Parameters;

        public BehaviourParams(Type behaviour, params object[] parameters)
        {
            if (!behaviour.IsSubclassOf(typeof(ExtendedBehaviour)))
            {
                Debug.LogError("Behaviour parameter must derive from type ExtendedBehaviour");
                Debug.Break();
            }

            Type = behaviour;
            Parameters = parameters;
        }
    }

    public abstract class ExtendedBehaviour : MonoBehaviour
    {
        public virtual void OnCreate(params object[] args)
        {
            if (args.Length == 0)
                return;
        }

        public T NewComponent<T>(params object[] args) where T: ExtendedBehaviour
        {
            var component = gameObject.AddComponent<T>();
            component.OnCreate(args);
            return component;
        }
    }
}