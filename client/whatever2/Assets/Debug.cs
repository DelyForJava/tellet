﻿namespace whatever
{
    public class Debug
    {
        private static bool isOpenLog = true;

        public static void LogError(object message)
        {
            if (!isOpenLog)
                return;
            UnityEngine.Debug.LogError(message);
        }

        public static void LogWarning(object message)
        {
            if (!isOpenLog)
                return;
            UnityEngine.Debug.LogWarning(message);
        }

        public static void Log(object message)
        {
            if (!isOpenLog)
                return;
            UnityEngine.Debug.Log(message);
        }

    }

}