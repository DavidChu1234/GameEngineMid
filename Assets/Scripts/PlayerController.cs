using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Chapter.Command
{
    public class PlayerController : MonoBehaviour
    {
        public Object prefab;
        public enum Direction
        {
            Left = -1,
            Right = 1
        }

        private float _distance = 1.0f;
        
        public void Turn(Direction direction)
        {
            if (direction == Direction.Left)
                transform.Translate(Vector2.left * _distance);
            if (direction == Direction.Right)
                transform.Translate(Vector2.right * _distance);
        }

        public void Shoot()
        {
            Instantiate(prefab);
        }

        public void ResetPosition()
        {
            transform.position = new Vector2(0.0f, 0.0f);
        }
    }
}
