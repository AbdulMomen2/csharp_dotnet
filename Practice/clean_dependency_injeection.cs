using System;
using System.Collections.Generic;

namespace Practice
{
    public interface ITool
    {
        void Use();
    }

    public class Hammer : ITool
    {
        public void Use() => Console.WriteLine("Hammering Nails");
    }

    public class Saw : ITool
    {
        public void Use() => Console.WriteLine("Sawing Wood");
    }

    public class Builder
    {
        private List<ITool> _tools;

        public Builder(IEnumerable<ITool> tools)
        {
            _tools = new List<ITool>(tools);
        }

        public void BuildHouse()
        {
            foreach (var tool in _tools)
                tool.Use();
        }
    }

    class Program
    {
        static void Main()
        {
            var tools = new List<ITool> { new Hammer(), new Saw() };
            Builder builder = new Builder(tools);
            builder.BuildHouse();
        }
    }
}