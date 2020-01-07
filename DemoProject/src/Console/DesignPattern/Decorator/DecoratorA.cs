namespace DesignPattern.Decorator
{
    
    public class DecoratorA : IComponent
    {
        IComponent component;
        public DecoratorA(IComponent c)
        {
            component = c;
        }

        public string Operation()
        {
            string s = component.Operation();
            s+= " and listening to classic FM ";
            return s;
        }
    }

}