using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Racing.Models {
    public class Car {
        public Car() {

        }
        public Car(string model, int speed) {
            Model = model;
            Speed = speed;
        }

        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver CarDriver { get; set; }

        public double CalculateSpeed() {
            return Speed * CarDriver.Level;
        }
    }
}
