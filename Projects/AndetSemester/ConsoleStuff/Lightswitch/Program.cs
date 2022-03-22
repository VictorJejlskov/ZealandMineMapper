using System;

namespace Lightswitch
{
    class Program
    {
        static void Main(string[] args)
        {
            IElectricalEquipment fan = new Fan();
            IElectricalEquipment light = new Light();

            Switch fancySwitch = new FancySwitch();
            Switch normalSwitch = new NormalSwitch();

            fancySwitch.Equipment = fan;
            

            fancySwitch.On();


            fancySwitch.Off();

            fancySwitch.Equipment = light;

            fancySwitch.On();
            fancySwitch.Off();


            normalSwitch.Equipment = light;
            normalSwitch.On(); 
            normalSwitch.Off(); 
        }
    }

    public class Switch
    {
        public IElectricalEquipment Equipment { get; set; }
        public void On()
        {
            Console.WriteLine("Switch turned on");
            Equipment.PowerOn();
        }

        public void Off()
        {
            Console.WriteLine("Switch turned off");
            Equipment.PowerOff();
        }
    }

    public class NormalSwitch : Switch
    {

    }

    public class FancySwitch : Switch
    {

    }

    public interface IElectricalEquipment
    {
        void PowerOn();
        void PowerOff();
    }

    public class Fan : IElectricalEquipment
    {
        public void PowerOn()
        {
            Console.WriteLine("Fan is on");
        }

        public void PowerOff()
        {
            Console.WriteLine("Fan is off");
        }
    }

    public class Light : IElectricalEquipment
    {
        public void PowerOn()
        {
            Console.WriteLine("Light is on");
        }

        public void PowerOff()
        {
            Console.WriteLine("Light is off");
        }
    }
}
