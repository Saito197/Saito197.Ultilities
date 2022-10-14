using UnityEngine;

namespace SaitoGames.Utilities
{
    public static class ComponentUtil
    {

        #region Add new components with values
        public static T AddComponentExt<T, T1>(this GameObject go, T1 arg1) where T : ExtendedBehaviour<T1>
        {
            if (go == null)
                return null;
            
            var newComponent = go.AddComponent<T>();
            newComponent.OnCreate(arg1);
            return newComponent;
        }
        
        public static T AddComponentExt<T, T1, T2>(this GameObject go, T1 arg1, T2 arg2) where T : ExtendedBehaviour<T1, T2>
        {
            if (go == null)
                return null;

            var newComponent = go.AddComponent<T>();
            newComponent.OnCreate(arg1, arg2);
            return newComponent;
        }
        
        public static T AddComponentExt<T, T1, T2, T3>(this GameObject go, T1 arg1, T2 arg2, T3 arg3) where T : ExtendedBehaviour<T1, T2, T3>
        {
            if (go == null)
                return null;

            var newComponent = go.AddComponent<T>();
            newComponent.OnCreate(arg1, arg2, arg3);
            return newComponent;
        }
        
        public static T AddComponentExt<T, T1, T2, T3, T4>(this GameObject go, T1 arg1, T2 arg2, T3 arg3, T4 arg4) where T : ExtendedBehaviour<T1, T2, T3, T4>
        {
            if (go == null)
                return null;

            var newComponent = go.AddComponent<T>();
            newComponent.OnCreate(arg1, arg2, arg3, arg4);
            return newComponent;
        }

        #endregion

        #region GameObject Instantiation 
        public static T InstantiateExt<T>(T prefab) where T : Component
        {
            var go = Object.Instantiate(prefab);
            var extBehaviours = go.GetComponents<ExtendedBehaviour>();
            foreach (var component in extBehaviours)
            {
                component.OnCreate();
            }
            return go;
        }
        
        public static T InstantiateExt<T>(T prefab, Transform parent) where T : Component
        {
            var go = Object.Instantiate(prefab, parent);
            var extBehaviours = go.GetComponents<ExtendedBehaviour>();
            foreach (var component in extBehaviours)
            {
                component.OnCreate();
            }
            return go;
        }
        
        public static T InstantiateExt<T>(T prefab, Vector3 position, Quaternion rotation, Transform parent) where T : Component
        {
            var go = Object.Instantiate(prefab, position, rotation, parent);
            var extBehaviours = go.GetComponents<ExtendedBehaviour>();
            foreach (var component in extBehaviours)
            {
                component.OnCreate();
            }
            return go;
        }

        #endregion
    }
}