using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRC_IOT
{
    class Program
    {
        static void Main(string[] args)
        {
            byte slaveAddress = 1;
            byte functionCode = 3;
            ushort startAddress = 0;
            ushort numberOfPoints = 2;

            byte[] frame = new byte[8];
            frame[0] = slaveAddress;
            frame[1] = functionCode;
            frame[2] = (byte)(slaveAddress >> 8);
            frame[3] = (byte)startAddress;
            frame[4] = (byte)(numberOfPoints >> 8);
            frame[5] = (byte)numberOfPoints;
            byte[] checkSum = CRC(frame);
            frame[6] = checkSum[0];
            frame[7] = checkSum[1];






        }
        private static byte[] CRC(byte[] data)
        {
            tWord CRC16_Check_A(tByte Num) //Ham CRC 16
            {
                tByte x, y, i; tWord Crc; //Bien Cuc Bo

                Crc = 0xFFFF; //Init

                for (x = 0; x < Num; ++x) //Lap Vong
                {
                    y = BUFF_2_T[x]; //Lay Byte Trong Bo Dem CRC 16
                    Crc = Crc ^ y; //Calculate the CRC

                    for (i = 8; i != 0; --i) //Shift Right
                    {
                        if ((Crc & 0x0001) != 0) //If the LSB is set
                        {
                            Crc >>= 1; //Shift right and XOR 0xA001
                            Crc ^= 0xA001;
                        }
                        else //Else LSB is not set  
                        {
                            Crc >>= 1; //Just shift right
                        }
                    }
                }

                //Swapping of the high and low CRC bytes      
                return Crc; //Tra Ve CRC_16 Tinh Duoc
            }

        }
    }
}
