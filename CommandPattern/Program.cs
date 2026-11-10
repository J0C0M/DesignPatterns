using CommandPattern.Classes;
using CommandPattern.Classes.Commands;
using CommandPattern.Interfaces;

namespace CommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();

            /* Define and instantiate the following Vendor classes
             * Kitchen Light : Light
             * Livingroom Light : Light
             * Livingroom ceiling fan : CeilingFan
             * Garage door: Garagedoor
             * Stereo : Stereo
             */
            Light kitchenLight = new Light("Kitchen");
            Light livingRoomLight = new Light("Living Room");
            CeilingFan livingRoomCeilingFan = new CeilingFan("Living Room Ceiling Fan");
            GarageDoor garageDoor = new GarageDoor(new Light("Garage"));
            Stereo stereo = new Stereo();
            // Define and instantiate an Off and On command for each Vendor class
            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);
            LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);
            CeilingFanMediumCommand ceilingFanMedium = new CeilingFanMediumCommand(livingRoomCeilingFan);
            CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(livingRoomCeilingFan);
            GarageDoorUpCommand garageDoorUp = new GarageDoorUpCommand(garageDoor);
            GarageDoorDownCommand garageDoorDown = new GarageDoorDownCommand(garageDoor);
            StereoOnWithCdCommand stereoOnWithCd = new StereoOnWithCdCommand(stereo);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            /* Set the On and Off commands to the appropriate slot:
             * 
             * 1: Living Room light
             * 2: Kitchen light
             * 3: Livingroom ceiling fan
             * 4: Garage door
             * 5: Stereo
             */
            remoteControl.SetCommand(1, livingRoomLightOn, livingRoomLightOff);
            remoteControl.SetCommand(2, kitchenLightOn, kitchenLightOff);
            remoteControl.SetCommand(3, ceilingFanMedium, ceilingFanOff);
            remoteControl.SetCommand(4, garageDoorUp, garageDoorDown);
            remoteControl.SetCommand(5, stereoOnWithCd, stereoOff);

            remoteControl.SetCommand(0, new CeilingFanHighCommand(livingRoomCeilingFan), new CeilingFanLowCommand(livingRoomCeilingFan));
            remoteControl.SetCommand(6, new StereoOnWithDvdCommand(stereo), new StereoOnWithRadioCommand(stereo));

            Console.WriteLine(remoteControl);

            // Test the pressing of Buttons here
            Console.WriteLine("# Press On, Off and On again for every slot ");
            for (int slot = 0; slot < 7; slot++)
            {
                remoteControl.OnButtonWasPushed(slot);
                remoteControl.OffButtonWasPushed(slot);
                remoteControl.OnButtonWasPushed(slot);
            }

            // The presses get undone
            Console.WriteLine("\n# Undo everything ");
            for (int i = 0; i < 22; i++)
            {
                remoteControl.UndoButtonWasPushed();
            }

            // The fan is the only one with a state and after undoing eveyrthing it has to be off again
            Console.WriteLine(livingRoomCeilingFan.GetSpeed() == livingRoomCeilingFan.OFF ? "PASS: fan is off again" : "FAIL: fan is not off again");
        }
    }
}