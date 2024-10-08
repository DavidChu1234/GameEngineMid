using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Chapter.Singleton
{
    public class GameManager : Singleton<GameManager>
    {
        private DateTime _sessionStartTime;
        private DateTime _sessionEndTime;
        private int _Score = 100;

        void Start()
        {
            _sessionStartTime = DateTime.Now;
            Debug.Log("Game Session started at " + _sessionStartTime.ToString());
        }

        void OnApplicationQuit()
        {
            _sessionEndTime = DateTime.Now;
            TimeSpan timeDifferance = _sessionEndTime - _sessionStartTime;

            Debug.Log("Session ended at " + _sessionEndTime.ToString());
            Debug.Log("Session lasted " + timeDifferance.ToString());
        }

        void UpdateScore(int score)
        {
            _Score += score;
        }


        void OnGUI()
        {
            if (GUILayout.Button(_Score.ToString()))
            {
                //displays score using observer
            }
        }
    }
}