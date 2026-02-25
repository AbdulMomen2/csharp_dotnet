namespace Practice01
{
    public class Hammer
    {
        public void Use()
        {
            Console.WriteLine("Hammering Nails");
        }
    }

    public class Saw
    {
        public void Use()
        {
            Console.WriteLine("Sawing Wood");
        }
        
    }

    public class Builder // the builder is depends omn the hammer and the saw; 
    {
        private Hammer _hammer;
        private Saw _saw;
        // public Builder()
        // {
        //     _hammer = new Hammer(); //builder is responsible for creating its  dependenciese
        //     _saw = new Saw();
        // }
        
            public Builder(Hammer hammer, Saw saw)
            {
            _hammer = hammer; //now it is full DI(Constructor Dependency Injector)
            _saw = saw;
            }
        

        public void BuildHouse()
        {
            _hammer.Use();
            _saw.Use();

        }
    }


}

