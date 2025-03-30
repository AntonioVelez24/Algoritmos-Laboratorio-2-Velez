using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Anthonycrimson
{
    public static class GameUtils
    {
        public static void ApplyToAll<T>(List<T> list, Action<T> action)
        {
            if (list == null) return;
            foreach (var item in list)
            {
                action(item);
            } 
        }
    }
}

