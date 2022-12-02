using System;
using UnityEngine;

namespace SaitoGames.Utilities
{
    public abstract class ExtendedBehaviour : MonoBehaviour
    {
        public virtual void OnCreate() { }
    }

    public abstract class ExtendedBehaviour<T1> : ExtendedBehaviour
    {
        [SerializeField] protected T1 Value1;
        public virtual void OnCreate(T1 arg1)
        {
            Value1 = arg1;
        }

        public override void OnCreate()
        {
            if (Value1 == null)
                return;

            OnCreate(Value1);
        }
    }

    public abstract class ExtendedBehaviour<T1, T2> : ExtendedBehaviour
    {
        [SerializeField] protected T1 Value1;
        [SerializeField] protected T2 Value2;
        public virtual void OnCreate(T1 arg1, T2 arg2)
        {
            Value1 = arg1;
            Value2 = arg2;
        }

        public override void OnCreate()
        {
            if (Value1 == null || Value2 == null)
                return;

            OnCreate(Value1, Value2);
        }
    }

    public abstract class ExtendedBehaviour<T1, T2, T3> : ExtendedBehaviour
    {
        [SerializeField] protected T1 Value1;
        [SerializeField] protected T2 Value2;
        [SerializeField] protected T3 Value3;
        public virtual void OnCreate(T1 arg1, T2 arg2, T3 arg3)
        {
            Value1 = arg1;
            Value2 = arg2;
            Value3 = arg3;
        }

        public override void OnCreate()
        {
            if (Value1 == null || Value2 == null || Value3 == null)
                return;

            OnCreate(Value1, Value2, Value3);
        }
    }

    public abstract class ExtendedBehaviour<T1, T2, T3, T4> : ExtendedBehaviour
    {
        [SerializeField] protected T1 Value1;
        [SerializeField] protected T2 Value2;
        [SerializeField] protected T3 Value3;
        [SerializeField] protected T4 Value4;

        public virtual void OnCreate(T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            Value1 = arg1;
            Value2 = arg2;
            Value3 = arg3;
            Value4 = arg4;
        }

        public override void OnCreate()
        {
            if (Value1 == null || Value2 == null || Value3 == null || Value4 == null)
                return;

            OnCreate(Value1, Value2, Value3, Value4);
        }
    }


}