/*

Controller.cpp: PCTx driver
Copyright (C) 2010  Wade Smith

This program is free software; you can redistribute it and/or
modify it under the terms of the GNU General Public License
as published by the Free Software Foundation; either version 2
of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program; if not, write to the Free Software
Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

*/

#include "pctx.h"

#define TRANSFER_TIMEOUT 200

#define DEBUG

#ifdef DEBUG
#include <iostream>
using namespace std;
#endif

Controller::Controller()
{
	output[0] = 0x00;
	output[1] = 0x00;
	output[2] = 0x00;
	output[3] = 0x00;
	output[4] = 0x00;
	output[5] = 0x00;
	output[6] = 0x00;
	output[7] = 0x00;
	output[8] = 0x00;


	connected = false;
}

Controller::~Controller()
{
	if (connected)
	{
		libusb_release_interface(usb_device_handle, 0);
		libusb_close(usb_device_handle);
		libusb_exit(usb_context);
	}
}

// Connect to the PCTx, may need to be run as root if the kernel driver is attached
bool Controller::connect()
{
	if (connected)
	{
		return true;
	}

	#ifdef DEBUG
	cout << "Init libusb" << endl;
	#endif

	if (libusb_init(&usb_context))
	{
		#ifdef DEBUG
		cout << "Failed to init libusb" << endl;
		#endif
		return false;
	}

	#ifdef DEBUG
	    libusb_set_option(usb_context, LIBUSB_OPTION_LOG_LEVEL, 4);
	#endif

	#ifdef DEBUG
	cout << "Success" << endl << "Opening device handle" << endl;
	#endif

	if (!(usb_device_handle = libusb_open_device_with_vid_pid(usb_context, vendor_id, product_id)))
	{
		#ifdef DEBUG
		cout << "Failed to open device" << endl;
		#endif
		return false;
	}

	if (libusb_kernel_driver_active(usb_device_handle, 0) == 1)
	{
		#ifdef DEBUG
		cout << "Detaching kernel driver" << endl;
		#endif
		libusb_detach_kernel_driver(usb_device_handle, 0);
	}

	#ifdef DEBUG
	cout << "Setting configuration" << endl;
	#endif
	libusb_set_configuration(usb_device_handle, 1);

	#ifdef DEBUG
	cout << "Claiming interface" << endl;
	#endif
	libusb_claim_interface(usb_device_handle, 0);

	#ifdef DEBUG
	cout << "Success" << endl;
	#endif

	connected = true;

	return true;
}

bool Controller::isConnected()
{
	return connected;
}

// Update data on all channels and send to the PCTx
bool Controller::transmit(int channel1, int channel2, int channel3, int channel4, int channel5,
							int channel6, int channel7, int channel8, int channel9)
{
	output[0] = channel1%256;
	output[1] = channel2%256;
	output[2] = channel3%256;
	output[3] = channel4%256;
	output[4] = channel5%256;
	output[5] = channel6%256;
	output[6] = channel7%256;
	output[7] = channel8%256;



	return writeToDevice();
}

// Update data on a single channel and send to the PCTx
bool Controller::updateChannel(int channelNum, int value)
{
	int refIndex = channelNum - 1;

	output[refIndex] = value%256;

	return writeToDevice();
}

bool Controller::writeToDevice(void)
{
	int transferred;
	unsigned char input[10];

	libusb_interrupt_transfer(usb_device_handle, 0x01, output, 8, &transferred, TRANSFER_TIMEOUT);


	if (transferred < 8)
	{
		#ifdef DEBUG
		cout << "Write failed" << endl;
		#endif
		return false;
	}
	libusb_interrupt_transfer(usb_device_handle, 0x81, input, 10, &transferred, TRANSFER_TIMEOUT);

	if (transferred < 10)
	{
		#ifdef DEBUG
		cout << "Read failed" << endl;
		#endif
		return false;
	}
	return true;
}

