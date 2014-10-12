using System;
using System.Collections;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Unity3DWebFundamentals
{
    public class SampleMonoBehaviour : MonoBehaviour
    {

        public float Seconds;
        
        public void Start()
        {
            Debug.Log(this.GetType().Name + " is starting up");
            StartCoroutine(UpdateLog());
        }
        
        bool updated = false;

        public float SomeProperty
        {
            get;
            set;
        }

        public void Update()
        {
            if (!updated)
            {
                updated = true;
                Debug.Log(this.GetType().Name + " is updating");
            }
        }

        private IEnumerator UpdateLog()
        {
            while (true)
            {
                Debug.Log(this.GetType().Name + " isssss logging every " + Seconds + " seconds " + DateTime.Now.ToString());
                yield return new WaitForSeconds(Seconds);
            }
        }
    }
}