using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using MultiTool.Abstractions;


namespace MultiTool.Model.Connections
{
    public class SerialConnection : IConnection
    {
        public SerialConnection()
        {
            serialPort = new SerialPort();
        }
        public SerialConnection(string portName)
        {
            serialPort = new SerialPort(portName);
        }
        public SerialConnection(string portName, int baudRate)
        {
            serialPort = new SerialPort(portName, baudRate);
        }
        public SerialConnection(string portName, int baudRate, Parity parity)
        {
            serialPort = new SerialPort(portName, baudRate, parity);
        }
        public SerialConnection(string portName, int baudRate, Parity parity, int dataBits)
        {
            serialPort = new SerialPort(portName, baudRate, parity, dataBits);
        }
        public SerialConnection(string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits)
        {
            serialPort = new SerialPort(portName, baudRate, parity, dataBits, stopBits);
        }

        private SerialPort serialPort;

        public SerialPort SerialPort
        {
            get => serialPort;
            set => serialPort = value;
        }

        public Handshake Handshake
        {
            get => serialPort.Handshake;
            set => serialPort.Handshake = value;
        }
        public Encoding Encoding
        {
            get => serialPort.Encoding;
            set => serialPort.Encoding = value;
        }
        public bool DtrEnable
        {
            get => serialPort.DtrEnable;
            set => serialPort.DtrEnable = value;
        }
        public bool CtsHolding => serialPort.CtsHolding;
        public bool DiscardNull { get; private set; }
        public int DataBits
        {
            get => serialPort.DataBits;
            set => serialPort.DataBits = value;
        }
        public bool IsOpen => serialPort.IsOpen;

        public bool DsrHolding => serialPort.DsrHolding;
        public string NewLine { get; private set; }
        public int ReadBufferSize { get; private set; }
        public byte ParityReplace { get; private set; }
        public string PortName
        {
            get => serialPort.PortName;
            set => serialPort.PortName = value;
        }
        public bool CDHolding => serialPort.CDHolding;
        public int ReadTimeout { get; private set; }
        public int ReceivedBytesThreshold { get; private set; }
        public bool RtsEnable
        {
            get => serialPort.RtsEnable;
            set => serialPort.RtsEnable = value;
        }
        public StopBits StopBits
        {
            get => serialPort.StopBits;
            set => serialPort.StopBits = value;
        }
        public int WriteBufferSize { get; private set; }
        public int WriteTimeout { get; private set; }
        public Parity Parity
        {

            get => serialPort.Parity;
            set => serialPort.Parity = value;
        }
        public int BytesToRead => serialPort.BytesToRead;

        public int BaudRate
        {
            get => serialPort.BaudRate;
            set => serialPort.BaudRate = value;
        }
        public bool BreakState
        {
            get => serialPort.BreakState;
            set => serialPort.BreakState = value;
        }
        public Stream BaseStream { get; }
        public int BytesToWrite => serialPort.BytesToWrite;

        public void Open() => serialPort.Open();

        public void Close() => serialPort.Close();

        public int Read(ref ICollection<byte> inputBuffer, int offset, int size)
        {
            return SerialPort.Read(inputBuffer.ToArray(), offset, size);
        }

        public void Write(ICollection<byte> data, int offset, int size)
        {
            serialPort.Write(data.ToArray(), offset, size);
        }
    }
}