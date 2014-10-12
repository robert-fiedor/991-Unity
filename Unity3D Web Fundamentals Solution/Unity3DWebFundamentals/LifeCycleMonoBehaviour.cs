using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Unity3DWebFundamentals
{
    public class LifeCycleMonoBehaviour : MonoBehaviour
    {
        // public "Variables"
        public bool TurnLoggerOn = true;

        // private counter variables
        private int updateCounter = 0;
        private int lateUpdateCounter = 0;

        /// <summary>
        /// This will get called first when the mono behaviour is loaded into the scene
        /// </summary>
        public void Awake()
        {
            this.Log("AWAKE called 1st");
        }

        /// <summary>
        /// This will get called once before any update functions are called
        /// Do your intialization here
        /// </summary>
        internal void Start()
        {
            this.Log("START called 2nd");
        }

        /// <summary>
        /// This is where any physics updates will live since this method is not tied to frame rate 
        /// </summary>
        public void FixedUpdate()
        {
            this.Log("FixedUpdate delta " + Time.fixedDeltaTime);
        }

        /// <summary>
        /// This is called once per frame as long as the behaviour is enabled
        /// </summary>
        private void Update()
        {
            this.Log("Update counter fff " + this.updateCounter++);
            if (10 == this.updateCounter)
            {
                this.enabled = false;
            }
        }
        
        /// <summary>
        /// This is called once per frame but always after Update
        /// </summary>
        public void LateUpdate()
        {
            this.Log("LateUpdate counter " + this.lateUpdateCounter++);
        }

        /// <summary>
        /// This is called anytime the behaviour is Disabled
        /// </summary>
        public void OnDisable()
        {
            this.Log("DISABLED");
            this.enabled = true;
        }

        /// <summary>
        /// This is called anytime the behaviour is Enabled
        /// </summary>
        internal void OnEnable()
        {
            this.Log("ENABLED");
        }

        /// <summary>
        /// My silly logging function
        /// </summary>
        /// <param name="message"></param>
        private void Log(string message)
        {
            if (this.TurnLoggerOn)
            {
                Debug.Log(string.Format("{0} {1}\n{2}",
                    this.GetType().Name, message, DateTime.Now.ToString("hh:mm:ss.fffffff")));
            }
        }

    }
}
