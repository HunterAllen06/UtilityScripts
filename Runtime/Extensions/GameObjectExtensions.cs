using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace HunterAllen.Utility
{
    public static class GameObjectExtensions
    {
        public static T GetOrAdd<T>(this GameObject self) where T : MonoBehaviour
        {
            return self.GetComponent<T>() ?? self.AddComponent<T>();
        }
        public static T GetOrAddComponent<T>(this GameObject self) where T : Component
        {
            self.TryGetComponent(out T t);
            t ??= self.AddComponent<T>();
            return t;
        }

        /// <summary>
        /// A version of GetComponent<T> that isn't exclusive to GameObjects/Components. Should work on interfaces.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public static T GetComponent<T>(this object self) where T : class
        {
            return (self as Component)?.GetComponent<T>();
        }
        /// <summary>
        /// A version of GetComponents<T> that isn't exclusive to GameObjects/Components. Should work on interfaces.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public static List<T> GetComponents<T>(this object self) where T : class
        {
            return (self as Component)?.GetComponents<T>().ToList();
        }

        public static bool TryGetComponent<T>(this object self, out T t) where T : class
        {
            if (self == null)
            {
                t = null;
                return false;
            }
            if ((self as Component) == null)
            {
                t = null;
                return false;
            }

            return (self as Component).TryGetComponent(out t);
        }
        public static bool TryGetComponentInParent<T>(this Component self, out T component) where T : Component
        {
            component = self.GetComponentInParent<T>();
            return component != null;
        }
        public static bool TryGetComponentInParent<T>(this GameObject self, out T component) where T : Component
        {
            component = self.GetComponentInParent<T>();
            return component != null;
        }
        public static bool TryGetComponentInChildren<T>(this Component self, out T component) where T : Component
        {
            component = self.GetComponentInChildren<T>();
            return component != null;
        }
        public static bool TryGetComponentInChildren<T>(this GameObject self, out T component) where T : Component
        {
            component = self.GetComponentInChildren<T>();
            return component != null;
        }
        public static bool TryGetComponentInRelatives<T>(this Component self, out T component) where T : Component
        {
            component = self.GetComponentInChildren<T>()??self.GetComponentInParent<T>();
            return component != null;
        }
        public static bool TryGetComponentInRelatives<T>(this GameObject self, out T component) where T : Component
        {
            component = self.GetComponentInChildren<T>()??self.GetComponentInParent<T>();
            return component != null;
        }
        
        /// <summary>
        /// Compares the layer on a GameObject to a LayerMask
        /// </summary>
        /// <returns>True if they are equal</returns>
        public static bool CompareLayer(LayerMask layerMask, GameObject obj)
        {
            return (layerMask.value & (1 << obj.layer)) != 0;
        }
        /// <summary>
        /// Compares the layer on this GameObject to a LayerMask
        /// </summary>
        /// <returns>True if they are equal</returns>
        public static bool CompareLayer(this GameObject obj, LayerMask layerMask)
        {
            return (layerMask.value & (1 << obj.layer)) != 0;
        }
        public static int ToLayer(this LayerMask self)
        {
            return self.value switch
            {
                0 => 0,
                1 << 1 => 1,
                1 << 2 => 2,
                1 << 3 => 3,
                1 << 4 => 4,
                1 << 5 => 5,
                1 << 6 => 6,
                1 << 7 => 7,
                1 << 8 => 8,
                1 << 9 => 9,
                1 << 10 => 10,
                1 << 11 => 11,
                1 << 12 => 12,
                1 << 13 => 13,
                1 << 14 => 14,
                1 << 15 => 15,
                1 << 16 => 16,
                1 << 17 => 17,
                1 << 18 => 18,
                1 << 19 => 19,
                1 << 20 => 20,
                1 << 21 => 21,
                1 << 22 => 22,
                1 << 23 => 23,
                1 << 24 => 24,
                1 << 25 => 25,
                1 << 26 => 26,
                1 << 27 => 27,
                1 << 28 => 28,
                1 << 29 => 29,
                1 << 30 => 30,
                1 << 31 => 31,
                _ => 0
            };
        }
    }
}