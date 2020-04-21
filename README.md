# Stegonography

This program can conceal a text message inside a bitmap(.bmp) image. It basically overwrites the least significant bit in each byte of image data with the message bits. This does't change the image to the human eye but there is a small diffrence in the image nevertheless. The program can write any message to those bits and than read it back. Currently there is no encription added to the message, so make sure no one knows that the message is in the image :)

You can download the program [here](https://github.com/zmazk123/Stegonography/blob/master/Stegonograpy/bin/Release/Stegonograpy.exe?raw=true).

## Instructions

![alt text](https://github.com/zmazk123/Stegonography/blob/master/program_image.png "Program")

### Encoding

1. Click on Open file an choose your bitmap image(i have already uploaded one)
2. Write your super secret message in the textbox and make sure that the message is not longer than the maximum message lenght displayed in the program.
4. Click on Encode
5. Save the image with the encoded message by clicking on Save

### Decoding

1. Click on Open file an choose your bitmap image(i have already uploaded one)
2. Click on Decode and the message will appear in the textbox
