using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stegonograpy.Classes
{
    class BitmapEncoder
    {
        const int bytesReservedForSize = 32;

        public static bool isMessageToLarge(Image image, string message)
        {
            uint largestMessageSize = calculateLargestMessageSize(image);

            byte[] messageData = ASCIIEncoding.ASCII.GetBytes(message);

            if (messageData.Length >= largestMessageSize) return true;
            else return false;
        }

        public static uint calculateLargestMessageSize(Image image)
        {
            byte[] imageData = ImageOperations.ImageToByteArray(image);

            uint dataBytesOffset = imageData[10];
            uint availableBytes = Convert.ToUInt32(imageData.Length) - dataBytesOffset - bytesReservedForSize;
            uint largestMessageSize = availableBytes / 8;

            return largestMessageSize;
        }

        public static void encodeMessage(ref Image image, string message)
        {
            byte[] imageData = ImageOperations.ImageToByteArray(image);
            byte[] messageData = ASCIIEncoding.ASCII.GetBytes(message);

            encodeMessageLenght(ref imageData, messageData);
            encodeMessageData(ref imageData, messageData);

            image = ImageOperations.byteArrayToImage(imageData);
        }

        private static void encodeMessageLenght(ref byte[] imageData, byte[] messageData)
        {
            encode(ref imageData, BitConverter.GetBytes(messageData.Length), imageData[10]);
        }

        private static void encodeMessageData(ref byte[] imageData, byte[] messageData)
        {
            int dataBytesOffset = imageData[10];
            encode(ref imageData, messageData, dataBytesOffset + bytesReservedForSize);
        }

        private static void encode(ref byte[] imageData, byte[] messageData, int offsetByte)
        {
            uint messageLenght = Convert.ToUInt32(messageData.Length);

            int bitIndex = 0;
            int messageDataByteIndex = 0;

            for (int i = offsetByte; i < offsetByte + messageLenght * 8; i++)
            {
                if (BitOperations.getBit(messageData[messageDataByteIndex], bitIndex) == true)
                {
                    imageData[i] = BitOperations.setLeastSignificantBitToOne(imageData[i]);
                }
                else
                {
                    imageData[i] = BitOperations.setLeastSignificantBitToZero(imageData[i]);
                }

                bitIndex++;
                if (bitIndex == 8)
                {
                    messageDataByteIndex++;
                    bitIndex = 0;
                }
            }
        }
    }
}
