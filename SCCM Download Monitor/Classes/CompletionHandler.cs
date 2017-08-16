//----------------------------------
// Completion Handler 
//----------------------------------
using System;
using System.Management;

namespace completionHandler
{
    /// <span class="code-SummaryComment"><summary></span>
    /// MyHandler class handle notification 
    /// when InvokeMethod call is complete
    /// <span class="code-SummaryComment"></summary></span>
    public class MyHandler
    {
        private bool isComplete = false;
        private ManagementBaseObject returnObject;

        /// <span class="code-SummaryComment"><summary></span>
        /// Trigger Done event when InvokeMethod is complete
        /// <span class="code-SummaryComment"></summary></span>
        public void Done(object sender, ObjectReadyEventArgs e)
        {
            isComplete = true;
            returnObject = e.NewObject;
        }


        /// <span class="code-SummaryComment"><summary></span>
        /// Get property IsComplete
        /// <span class="code-SummaryComment"></summary></span>
        public bool IsComplete
        {
            get
            {
                return isComplete;
            }
        }

        /// <span class="code-SummaryComment"><summary></span>
        /// Property allows accessing the result 
        /// object in the main function
        /// <span class="code-SummaryComment"></summary></span>
        public ManagementBaseObject ReturnObject
        {
            get
            {
                return returnObject;
            }
        }

    }
}