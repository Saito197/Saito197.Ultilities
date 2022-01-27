using UnityEngine;

namespace SaitoGames.Utilities
{
    public static class GameObjectUtil
    {
        /// <summary>
        /// Clones the object original and returns the clone
        /// </summary>
        /// <param name="original">An existing object/prefab that you want to make a copy of</param>
        /// <param name="parent">Parent that will be assigned to the new object</param>
        /// <param name="behaviourParams">Parameters for extended behaviours attached to the GameObject</param>
        /// <returns></returns>
        public static GameObject InstantiateNew(
            GameObject original,
            Transform parent = null,
            params BehaviourParams[] behaviourParams)
        {
            var newGO = Object.Instantiate(original, parent);
            var index = 0;
            foreach (var item in behaviourParams)
            {
                var component = newGO.GetComponent(behaviourParams[index].Type) as ExtendedBehaviour;
                component.OnCreate(behaviourParams[index].Parameters);
                index++;
            }

            return newGO;
        }

        /// <summary>
        /// Clones the object original and returns the clone
        /// </summary>
        /// <param name="original">An existing object/prefab that you want to make a copy of</param>
        /// <param name="position">Position for the new object</param>
        /// <param name="rotation">Position for the new object</param>
        /// <param name="parent">Parent that will be assigned to the new object</param>
        /// <param name="behaviourParams">Parameters for extended behaviours attached to the GameObject</param>
        /// <returns></returns>
        public static GameObject InstantiateNew(
            GameObject original,
            Vector3 position,
            Quaternion rotation,
            Transform parent = null,
            params BehaviourParams[] behaviourParams)
        {
            var newGO = Object.Instantiate(original, position, rotation, parent);
            var index = 0;
            foreach (var item in behaviourParams)
            {
                var component = newGO.GetComponent(behaviourParams[index].Type) as ExtendedBehaviour;
                component.OnCreate(behaviourParams[index].Parameters);
                index++;
            }

            return newGO;
        }
    }

}