using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsGUIDecoupled
{
    class Game
    {
        private Boolean clickedButton = false;
        public Game someoneHasClickedMyButton()
        {

            // this event could call metthods in other classes but as a demo it's
            // just going to change the button clicked value to true
            // It could return a reference to the entire game to the GUI so get set methods could be used
            // by the gui to access any data in the game to update the gui
            // in fact i'll return a reference to the object rather than the boolean 
            clickedButton = true;
            return this;
        }

        public Boolean getClickedButton()
        {
           return  clickedButton ;
        }
    }
}
