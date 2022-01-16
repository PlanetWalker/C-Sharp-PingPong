namespace Game.Sliders
{
    internal class Slider
    {
        private int sliderSpeed; // speed of the sliders
        private bool _Left;
        private bool _Right;

        public bool IsLeft { get { return _Left; } set { _Left = value;  } }
        public bool IsRight { get { return _Right; } set { _Right = value; } }
        public int SetSpeed { set { sliderSpeed = value; } }
        public int GetSpeed { get { return sliderSpeed; } }

        public Slider()
        {
            // set Default
            sliderSpeed = 10;
            _Left = _Right = false;
        }

        public void CalcPosition(Form screen, Panel obj)
        {
            // if key pressed do this
            if (_Left && obj.Left > 0) // This schould not remove if there no space
                obj.Left -= sliderSpeed;
            if (_Right && obj.Left < screen.Width - obj.Width) // This schould not add if there no space
                obj.Left += sliderSpeed;
        }

        public void KeyDownPosition(Keys key, Keys keyUp, Keys keyDown)
        {
            if (key == keyUp)
                _Left = true;
            if (key == keyDown)
                _Right = true;
        }

        public void KeyUpPosition(Keys key, Keys keyUp, Keys keyDown)
        {
            if (key == keyUp)
                _Left = false;
            if (key == keyDown)
                _Right = false;
        }
    }
}
