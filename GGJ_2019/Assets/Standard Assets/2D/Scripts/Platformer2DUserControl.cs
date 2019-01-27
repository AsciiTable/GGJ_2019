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
        public float windy = 1f;

        private float currentWindy;
        private PlatformerCharacter2D m_Character;
        private bool m_Jump;

        private void Awake()
        {
            currentWindy = 1f;
            m_Character = GetComponent<PlatformerCharacter2D>();
        }


        private void Update()
        {
            if (!m_Jump)
            {
                // Read the jump input in Update so button presses aren't missed.
                m_Jump = CrossPlatformInputManager.GetButtonDown("Jump");
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
            if (Input.GetKeyDown(KeyCode.LeftShift) && windy >= 1)
            {
                if(currentWindy == 1f)
                {
                    currentWindy = windy;
                }
                else if(currentWindy > 1f)
                {
                    currentWindy = 1f;
                }
                else
                {
                    Debug.Log("You shoud not see this, contact programmer for fix");
                }
            }
            else if(windy < 1)
            {
                Debug.Log("windy should not be less than 1");
            }
            m_Character.Move(h * currentWindy, crouch, m_Jump);
            m_Jump = false;
        }
    }
}
