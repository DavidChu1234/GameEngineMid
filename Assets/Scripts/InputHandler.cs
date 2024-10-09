using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Chapter.Command
{
    public class InputHandler : MonoBehaviour
    {
        private bool _isReplaying;
        private bool _isRecording;
        private PlayerController _playerController;
        private Command _buttonA, _buttonD, _spacebar;
        void Start()
        {

            _playerController = FindObjectOfType<PlayerController>();
            _buttonA = new Left(_playerController);
            _buttonD = new Right(_playerController);
            _spacebar = new Shoot(_playerController);
        }
        void Update()
        {
            if (Input.GetKeyUp(KeyCode.A))
                _playerController.Turn(PlayerController.Direction.Left);
            if (Input.GetKeyUp(KeyCode.D))
                _playerController.Turn(PlayerController.Direction.Right);
            if (Input.GetKeyUp(KeyCode.Space))
                _playerController.Shoot();
        }
    }
}

