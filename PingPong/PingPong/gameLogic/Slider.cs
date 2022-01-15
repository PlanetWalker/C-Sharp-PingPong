using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong.gameLogic
{
    public class Slider
    {
        public int sliderSpeed = 10; // speed of the sliders
        public bool _Up;
        public bool _Down;

        public Slider()
        {
            // set Default
            _Up = _Down = false;
        }

        public int CalcPosition(int posTop, int screenHeight, int playerHeight) {
            // if key pressed do this
            if (_Up && posTop > 0) // This schould not remove if there no space
                posTop -= sliderSpeed;
            if (_Down && posTop < screenHeight - playerHeight) // This schould not add if there no space
                posTop += sliderSpeed;
            return posTop;
        }

        public void KeyDownPosition(Keys key, Keys keyUp, Keys keyDown)
        {
            if(key == keyUp)
                _Up = true;
            if(key == keyDown)
                _Down = true;
        }
        public void KeyUpPosition(Keys key, Keys keyUp, Keys keyDown)
        {
            if (key == keyUp)
                _Up = false;
            if (key == keyDown)
                _Down = false;
        }
    }
}
