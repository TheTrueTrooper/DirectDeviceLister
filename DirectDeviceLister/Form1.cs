using SharpDX.DirectInput;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectDeviceLister
{
    public partial class DirectDeviceListForm : Form
    {
        static DirectInput DirectInputDriversInfo = new DirectInput();

        public DirectDeviceListForm()
        {
            InitializeComponent();
        }

        private void DirectDeviceListForm_Load(object sender, EventArgs e)
        {
            ListDirectDevices();
        }

        private void Bu_RefreshList_Click(object sender, EventArgs e)
        {
            ListDirectDevices();
        }

        void ListDirectDevices()
        {
            TrVi_List.Nodes.Clear();

            TrVi_List.Nodes.Add("Devices");
            DeviceInstance[] Devices = DirectInputDriversInfo.GetDevices(DeviceType.Device, DeviceEnumerationFlags.AttachedOnly).ToArray();
            foreach (DeviceInstance Dev in Devices)
                TrVi_List.Nodes[TrVi_List.Nodes.Count - 1].Nodes.Add($"{Dev.ProductName} - {Dev.ProductGuid} - {Dev.InstanceName} - {Dev.InstanceGuid}");

            TrVi_List.Nodes.Add("ControlDevices");
            DeviceInstance[] ControlDevices = DirectInputDriversInfo.GetDevices(DeviceType.ControlDevice, DeviceEnumerationFlags.AttachedOnly).ToArray();
            foreach (DeviceInstance Dev in ControlDevices)
                TrVi_List.Nodes[TrVi_List.Nodes.Count - 1].Nodes.Add($"{Dev.ProductName} - {Dev.ProductGuid} - {Dev.InstanceName} - {Dev.InstanceGuid}");

            TrVi_List.Nodes.Add("DrivingDevices");
            DeviceInstance[] DrivingDevices = DirectInputDriversInfo.GetDevices(DeviceType.Driving, DeviceEnumerationFlags.AttachedOnly).ToArray();
            foreach (DeviceInstance Dev in DrivingDevices)
                TrVi_List.Nodes[TrVi_List.Nodes.Count - 1].Nodes.Add($"{Dev.ProductName} - {Dev.ProductGuid} - {Dev.InstanceName} - {Dev.InstanceGuid}");

            TrVi_List.Nodes.Add("FirstPersonDevices");
            DeviceInstance[] FirstPersonDevices = DirectInputDriversInfo.GetDevices(DeviceType.FirstPerson, DeviceEnumerationFlags.AttachedOnly).ToArray();
            foreach (DeviceInstance Dev in FirstPersonDevices)
                TrVi_List.Nodes[TrVi_List.Nodes.Count - 1].Nodes.Add($"{Dev.ProductName} - {Dev.ProductGuid} - {Dev.InstanceName} - {Dev.InstanceGuid}");

            TrVi_List.Nodes.Add("FlightDevices");
            DeviceInstance[] FlightDevices = DirectInputDriversInfo.GetDevices(DeviceType.Flight, DeviceEnumerationFlags.AttachedOnly).ToArray();
            foreach (DeviceInstance Dev in FlightDevices)
                TrVi_List.Nodes[TrVi_List.Nodes.Count - 1].Nodes.Add($"{Dev.ProductName} - {Dev.ProductGuid} - {Dev.InstanceName} - {Dev.InstanceGuid}");

            TrVi_List.Nodes.Add("GamePadDevices");
            DeviceInstance[] GamePadDevices = DirectInputDriversInfo.GetDevices(DeviceType.Gamepad, DeviceEnumerationFlags.AttachedOnly).ToArray();
            foreach (DeviceInstance Dev in GamePadDevices)
                TrVi_List.Nodes[TrVi_List.Nodes.Count - 1].Nodes.Add($"{Dev.ProductName} - {Dev.ProductGuid} - {Dev.InstanceName} - {Dev.InstanceGuid}");

            TrVi_List.Nodes.Add("JoystickDevices");
            DeviceInstance[] JoystickDevices = DirectInputDriversInfo.GetDevices(DeviceType.Joystick, DeviceEnumerationFlags.AttachedOnly).ToArray();
            foreach (DeviceInstance Dev in JoystickDevices)
                TrVi_List.Nodes[TrVi_List.Nodes.Count - 1].Nodes.Add($"{Dev.ProductName} - {Dev.ProductGuid} - {Dev.InstanceName} - {Dev.InstanceGuid}");

            TrVi_List.Nodes.Add("KeyboardDevices");
            DeviceInstance[] KeyboardDevices = DirectInputDriversInfo.GetDevices(DeviceType.Keyboard, DeviceEnumerationFlags.AttachedOnly).ToArray();
            foreach (DeviceInstance Dev in KeyboardDevices)
                TrVi_List.Nodes[TrVi_List.Nodes.Count - 1].Nodes.Add($"{Dev.ProductName} - {Dev.ProductGuid} - {Dev.InstanceName} - {Dev.InstanceGuid}");

            TrVi_List.Nodes.Add("MouseDevices");
            DeviceInstance[] MouseDevices = DirectInputDriversInfo.GetDevices(DeviceType.Mouse, DeviceEnumerationFlags.AttachedOnly).ToArray();
            foreach (DeviceInstance Dev in MouseDevices)
                TrVi_List.Nodes[TrVi_List.Nodes.Count - 1].Nodes.Add($"{Dev.ProductName} - {Dev.ProductGuid} - {Dev.InstanceName} - {Dev.InstanceGuid}");

            TrVi_List.Nodes.Add("RemoteDevices");
            DeviceInstance[] RemoteDevices = DirectInputDriversInfo.GetDevices(DeviceType.Remote, DeviceEnumerationFlags.AttachedOnly).ToArray();
            foreach (DeviceInstance Dev in RemoteDevices)
                TrVi_List.Nodes[TrVi_List.Nodes.Count - 1].Nodes.Add($"{Dev.ProductName} - {Dev.ProductGuid} - {Dev.InstanceName} - {Dev.InstanceGuid}");

            TrVi_List.Nodes.Add("ScreenPointerDevices");
            DeviceInstance[] ScreenPointerDevices = DirectInputDriversInfo.GetDevices(DeviceType.ScreenPointer, DeviceEnumerationFlags.AttachedOnly).ToArray();
            foreach (DeviceInstance Dev in ScreenPointerDevices)
                TrVi_List.Nodes[TrVi_List.Nodes.Count - 1].Nodes.Add($"{Dev.ProductName} - {Dev.ProductGuid} - {Dev.InstanceName} - {Dev.InstanceGuid}");

            TrVi_List.Nodes.Add("SupplementalDevices");
            DeviceInstance[] SupplementalDevices = DirectInputDriversInfo.GetDevices(DeviceType.Supplemental, DeviceEnumerationFlags.AttachedOnly).ToArray();
            foreach (DeviceInstance Dev in SupplementalDevices)
                TrVi_List.Nodes[TrVi_List.Nodes.Count - 1].Nodes.Add($"{Dev.ProductName} - {Dev.ProductGuid} - {Dev.InstanceName} - {Dev.InstanceGuid}");
        }
    }
}
