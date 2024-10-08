using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter.Command
{
    public class Left : Command
    {
        private PlayerController _controller;
        public Left(PlayerController controller)
        {
            _controller = controller;
        }
        public override void Execute()
        {
            _controller.Turn(PlayerController.Direction.Left);
        }
    }
}
