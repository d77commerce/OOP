using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    class Robots : IModel, IId
    {
        public Robots(string model, string id)
        {
            Model = model;
            Id = id;
        }

        public string Model { get; }

        public string Id { get; }
    }
}
