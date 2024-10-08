using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter.Command
{
    public class Right : Command
    {
        private PlayerController _controller;
        public Right(PlayerController controller)
        {
            _controller = controller;
        }
        public override void Execute()
        {
            _controller.Turn(PlayerController.Direction.Right);
        }
    }
}

