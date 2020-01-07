namespace DesignPattern.Decorator
{
    public class DecoratorB : IComponent
    {
        IComponent component;
        public string addState = "past the Coffee Shop";

        public DecoratorB(IComponent c)
        {
            component = c;
        }

        public string Operation()
        {
            string s = component.Operation();
            s+= " to school ";
            return s;
        }

        public string AddBehavior()
        {
            return " and I bought a cappuccino";
        }
        
    }

}