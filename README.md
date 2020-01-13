# LTE-NB-IOT-Drive-Tester
VB.NET Drive Tester Implementation using the Wave Share Module

## Hardware
https://www.waveshare.com/wiki/SIM7000E_NB-IoT_HAT - Waveshare Module used in my instance.

## Overview
### Setup
Simple to use, clone the repo. Open in VS and build the programme. Find out the COM Port number of the AT Command Port use the convinently located Device Manager open button to find that out.
Set the Baud Rate and other properties (refer to your module manual) and Click Connect. Stop Bits mustn't be none since its not supported although the option has been included.

![Image 1](https://imgur.com/Mh84HZc.png)

Three tabs will be enabled after connecting which are as follows,

DT Soft - For drive testing

GPS - For the GPS Module

Funct. - To carry out basic functions

### DT Soft Tab

Get Details button returns the parsed result of the "AT+CPSI?;+CGNSINF" command if GPS isn't enabled or no location is fixed it will not record any value.
Logging works much the same way you can set the period of logging by changing the value in the text box, unit is in milliseconds (1 second = 1000 milliseconds)
Every session will be saved automatically to the export folder in the "YYYYmmDD-HHmm" format as CSV files. Clear the Log after each session or previous results will be saved again.

IOT and GSM buttons work as expected in switching the modes but on occassion it might have to be pressed twice or thrice since modules handle commands differently. It is recommended that RF functionality is put down before switching modes. (Refer to the Funct. Tab)

![Image of DT Tab](https://imgur.com/R480tcE.png)

### GPS Tab
GPS needs to be turned on to get location and turn it off before quitting to avoid unnnecessary power consumption. Get Location will return the current coordinates will sometimes return zero if the recieve buffer is saturated.

![Image of GPS Tab](https://imgur.com/zaNHKPj.png)

### Funct. Tab
RF Up and RF Down basically explains themselves the commands run are "AT+CFUN=1" and "AT+CFUN=4" respectively.
Lock EARFCN will prompt an Input Box, enter the NB IoT cells EARFCN,PCI in the specified format to lock the module to the cell. Affects only on IoT Mode.

![Image of Funct. Tab](https://imgur.com/DqMUxZ9.png)

## Things to Lookout for
Sometimes error values or unexpected values will be looged such as retunrs for previous commands due to the buffer being not cleared properly. Don't worry just repeat a few times.

![Leftover from Get Location Exec.](https://imgur.com/meeEds4.png)
![Leftover from RF Up Exec.](https://imgur.com/rKumwet.png)
