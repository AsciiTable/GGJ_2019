using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets._2D
{
    [RequireComponent(typeof (PlatformerCharacter2D))]
    public class Platformer2DUserControl : MonoBehaviour
    {
        //Edit By KingdomCross:
        public bool crouch;

        private PlatformerCharacter2D m_Character;
        private bool m_Jump;

        public float sitTimer = 0f;

        private void Awake()
        {
            m_Character = GetComponent<PlatformerCharacter2D>();
        }


        private void Update()
        {
            if (!m_Jump)
            {
                // Read the jump input in Update so button presses aren't missed.
                m_Jump = CrossPlatformInputManager.GetButtonDown("Jump");
            }

            //Timer for crouching
            if (crouch)
            {
                sitTimer += Time.deltaTime;
            }

        }


        private void FixedUpdate()
        {
            // Read the inputs.
            //bool crouch = Input.GetKey(KeyCode.X);
            if (Input.GetKeyDown(KeyCode.X))
            {
                crouch = !crouch;
            }

            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            // Pass all parameters to the character control script.
            if (!Input.GetKey(KeyCode.LeftShift))
            {
                m_Character.Move(h, crouch, m_Jump);
            }
            else if (Input.GetKey(KeyCode.LeftShift))
            {
                m_Character.Move(h * 2, crouch, m_Jump);
            }
            m_Jump = false;
        }
    }
}
