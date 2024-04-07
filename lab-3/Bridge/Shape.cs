namespace Bridge
{
    public abstract class Shape
    {
        protected IRender _shapeRender;
        
        public Shape(IRender render)
        {
            _shapeRender = render;
        }

        public void changeRender(IRender newRender)
        {
            _shapeRender = newRender;
        }
        public abstract void Draw();
    }
}
