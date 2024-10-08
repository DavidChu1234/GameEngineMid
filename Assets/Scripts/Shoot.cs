using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter.Command
{
    public class Shoot : Command
    {
        private PlayerController _controller;
        public Shoot(PlayerController controller)
        {
            _controller = controller;
        }
        public override void Execute()
        {
            _controller.Shoot();
        }
    }
}