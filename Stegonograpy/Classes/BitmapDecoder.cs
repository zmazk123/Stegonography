using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stegonograpy.Classes
{
    class BitmapDecoder
    {
        const int bytesReservedForSize = 32;

        public static bool isMessageToLarge(Image image, uint largestMessageSize)
        {
            uint messageSize = decodeMessageLenght(image);

            if (messageSize >= largestMessageSize) return true;
            else return false;
        }

        public static uint decodeMessageLenght(Image image)
        {
            byte[] imageData = ImageOperations.ImageToByteArray(image);

            int dataBytesOffset = imageData[10];
            byte[] messageLenghtByteData = decode(imageData, dataBytesOffset, bytesReservedForSize / 8);
            return BitConverter.ToUInt32(messageLenghtByteData, 0);
        }

        public static string decodeMessage(Image image)
        {
            byte[] imageData = ImageOperations.ImageToByteArray(image);

            uint messageLenght = decodeMessageLenght(imageData);
            byte[] messageData = decodeMessageData(imageData, messageLenght);

            return Encoding.ASCII.GetString(messageData);
        }

        private static byte[] decodeMessageData(byte[] imageData, uint messageLenght)
        {
            int dataBytesOffset = imageData[10];
            return decode(imageData, dataBytesOffset + bytesReservedForSize, messageLenght);
        }

        private static uint decodeMessageLenght(byte[] imageData)
        {
            int dataBytesOffset = imageData[10];
            byte[] messageLenghtData = decode(imageData, dataBytesOffset, bytesReservedForSize / 8);
            return BitConverter.ToUInt32(messageLenghtData, 0);
        }

        private static byte[] decode(byte[] imageData, int offsetByte, uint messageLenght)
        {
            byte[] messageData = new byte[messageLenght];

            int bitIndex = 0;
            bool bitToBeWritten = false;
            int messageDataByteIndex = 0;

            for (int i = offsetByte; i < offsetByte + messageLenght * 8; i++)
            {
                bitToBeWritten = BitOperations.getBit(imageData[i], 0);
                messageData[messageDataByteIndex] = BitOperations.setBit(messageData[messageDataByteIndex], bitIndex, bitToBeWritten);

                bitIndex++;
                if (bitIndex == 8)
                {
                    messageDataByteIndex++;
                    bitIndex = 0;
                }
            }

            return messageData;
        }
    }
}
