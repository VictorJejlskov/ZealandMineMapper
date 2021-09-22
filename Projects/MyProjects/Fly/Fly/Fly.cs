using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Fly
{
    class Fly
    {
        private double _xPosition;
        private double _yPosition;
        private double _xSpeed;
        private double _ySpeed;
        private string _flyID;

        public double XPosition
        {
            get { return _xPosition; }
            set { _xPosition = value; }
        }
        public double YPosition
        {
            get { return _yPosition; }
            set { _yPosition = value; }
        }
        public double XSpeed
        {
            get { return _xSpeed; }
            set { _xSpeed = value; }
        }
        public double YSpeed
        {
            get { return _ySpeed; }
            set { _ySpeed = value; }
        }

        public string FlyID
        {
            get { return _flyID; }
        }

        //public Fly(string flyID)
        //{
        //    _flyID = flyID;
        //}

        public Fly(string flyID, double xPosition, double yPosition, double xSpeed, double ySpeed)
        {
            _flyID = flyID;
            _xPosition = xPosition;
            _yPosition = yPosition;
            _xSpeed = xSpeed;
            _ySpeed = ySpeed;
            FirstTime = true;
        }

        public void Move()
        {
            XPosition += XSpeed;
            YPosition += YSpeed;
        }

        public void Accelerate()
        {
            XSpeed = XSpeed * 1.1;
            YSpeed = YSpeed * 1.1;
        }

        public void Decelerate()
        {
            XSpeed = XSpeed * 0.9;
            YSpeed = YSpeed * 0.9;
        }

        public void Stop()
        {
            XSpeed = 0;
            YSpeed = 0;
        }

        public void Turn(double newXSpeed, double newYSpeed)
        {
            _xSpeed += newXSpeed;
            _ySpeed += newYSpeed;
        }

        public void LiftOff()
        {
            _xSpeed = 1.0;
            _ySpeed = 1.0;
        }

        public string FlyData()
        {
            return $"Name of the plane: {FlyID}\n" +
                   $"It's current position is - X: {Math.Round(XPosition,2)} & Y: {Math.Round(YPosition,2)}\n" +
                   $"It's current speeds are - X: {Math.Round(XSpeed,2)} & Y: {Math.Round(YSpeed,2)}\n";
        }
        public bool IsFlying { get; set; }
        public bool FirstTime { get; set; }
        public string Instructions()
        {
            if (FirstTime)
            {
                return $"Welcome and thank you for flying air Jejlskov!\n" +
                       $"Since this is your first time here, let's start with a liftoff!\n" +
                       $"Press 'SPACEBAR' to begin\n";
            }
            return $"To turn left, click 'A'\n"+
                   $"To turn right, click 'D'\n"+
                   $"To accelerate, click 'W'\n"+
                   $"To decelerate, click 'S'\n"+
                   $"To move keeping current direction, click 'Spacebar'\n"+
                   $"To stop all movement, 'K' (and again to liftoff once more)\n";
        }
    }

}
