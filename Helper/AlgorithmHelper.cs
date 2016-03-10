using System;

namespace DDT
{
    // A class to store file lists, etc etc.
    public class AlgorithmHelper
    {
        private List<string> files;
        public List<string> FileList
        {
            get
            {
                return files;
            }
            set
            {
                files = value;
            }
        }
        
        private bool isDisintegrate;
        public bool ShouldDisintegrate
        {
            get
            {
                return isDisintegrate;
            }
            set
            {
                isDisintegrate = value;
            }
        }
        
        private bool isDisrupt;
        public bool ShouldDisrupt
        {
            get
            {
                return isDisrupt;
            }
            set
            {
                isDisrupt = value;
            }
        }
        
        private bool isTerminate;
        public bool ShouldTerminate
        {
            get
            {
                return isTerminate;
            }
            set
            {
                isTerminate = value;
            }
        }
        
        public AlgorithmHelper()
        {
            
        }
    }
}
