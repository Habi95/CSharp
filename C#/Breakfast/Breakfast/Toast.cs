using System;
using System.Collections.Generic;
using System.Text;

namespace Breakfast
{
    public class Toast
    {
        private bool jamApplied;
        public bool JamApplied 
        { 
            get { return jamApplied; } 
            set { jamApplied = value; }
        }
       
        
        private bool butterApplied;
        public bool ButterApplied 
        { 
            get { return butterApplied; } 
            set { butterApplied = value; }
        }

        public Toast[] toasts;



        public static Toast ApplyButter (Toast toasts)
        {   
            toasts.butterApplied = true;
            return toasts;
             
        }
        public static Toast ApplyJam(Toast toasts)
        {
          toasts.jamApplied = true;
            return toasts;
        }
    }
}
