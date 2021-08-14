//-----------------------------------------------------------------------------
//	Copyright Endurance R/C 2008
//
//	PCTx/Servo Controller 9 Channel Sample Application
//
//	Please see the file license.txt for more info
//-----------------------------------------------------------------------------

#include <stdafx.h>
#include "controller.h"

using namespace std;

//PCTx/Servo Controller USB device info
const unsigned int VendorID =	0x0925;
const unsigned int ProductID =	0x1299;

controller::controller(void){
	connected = false;
	connect();
}

controller::~controller(void){
}

//Connect to the PCTx/Servo Controller
bool controller::connect(){
	GUID								HidGuid;
	HANDLE								hDevInfo;
	SP_DEVICE_INTERFACE_DATA			devInfoData;
	int									MemberIndex = 0;
	bool								MyDeviceDetected = FALSE;
	bool								LastDevice = FALSE;
	ULONG								Length;
	PSP_DEVICE_INTERFACE_DETAIL_DATA	detailData;
	ULONG								Required;
	HIDD_ATTRIBUTES						Attributes;
	PHIDP_PREPARSED_DATA				PreparsedData;

	// Get the GUID for all system HIDs
	HidD_GetHidGuid(&HidGuid);

	// Get handle to device information set for all installed devices
	hDevInfo = SetupDiGetClassDevs(&HidGuid, NULL, NULL, DIGCF_PRESENT | DIGCF_INTERFACEDEVICE);

	// Set struct size before calling SetupDiEnumDeviceInterfaces
	devInfoData.cbSize = sizeof(devInfoData);

	do {
		MyDeviceDetected=FALSE;

		// Get handle to a SP_DEVICE_INTERFACE_DATA structure for a detected device
		result = SetupDiEnumDeviceInterfaces(hDevInfo, 0, &HidGuid, MemberIndex, &devInfoData);

		if (result) {
			result = SetupDiGetDeviceInterfaceDetail(hDevInfo, &devInfoData, NULL, 0, &Length, NULL);

			//Allocate memory for the hDevInfo structure, using the returned Length.
			detailData = (PSP_DEVICE_INTERFACE_DETAIL_DATA) malloc(Length);

			//Set cbSize in the detailData structure.
			detailData->cbSize = sizeof(SP_DEVICE_INTERFACE_DETAIL_DATA);

			//Call the function again, this time passing it the returned buffer size.
			result = SetupDiGetDeviceInterfaceDetail(hDevInfo, &devInfoData, detailData, Length, &Required, NULL);

			DeviceHandle = CreateFile 
				(detailData->DevicePath, 
				GENERIC_READ | GENERIC_WRITE, 
				FILE_SHARE_READ | FILE_SHARE_WRITE, 
				(LPSECURITY_ATTRIBUTES) NULL,
				OPEN_EXISTING, 
				0, 
				NULL);
			
			Attributes.Size = sizeof(Attributes);

			result = HidD_GetAttributes(DeviceHandle, &Attributes);

			if (Attributes.VendorID == VendorID) {
				if (Attributes.ProductID == ProductID) {
					//Both the Product and Vendor IDs match.
					MyDeviceDetected = TRUE;
				}
				else {
					CloseHandle(DeviceHandle);
				}
			} 
			else {
				CloseHandle(DeviceHandle);
			}
			//Free the memory used by the detailData structure (no longer needed).
			free(detailData);
		}
		else {
			//SetupDiEnumDeviceInterfaces returned 0, so there are no more devices to check.
			LastDevice=TRUE;
		}
		//If we haven't found the device yet, and haven't tried every available device,
		//try the next one.
		MemberIndex++;
	} while ((LastDevice == FALSE) && (MyDeviceDetected == FALSE));

	if (MyDeviceDetected == FALSE) {
		SetupDiDestroyDeviceInfoList(hDevInfo);

		connected = false;
		return false;
	}

	//Free the memory reserved for hDevInfo by SetupDiClassDevs.
	SetupDiDestroyDeviceInfoList(hDevInfo);
	
	HidD_GetPreparsedData(DeviceHandle, &PreparsedData);
	HidP_GetCaps(PreparsedData, &Capabilities);

	HidD_FreePreparsedData(PreparsedData);
	connected = true;
	return true;
}


//Send new channel data to the PCTx/Servo Controller
bool controller::send(int delay1, int delay2, int delay3, int delay4, int delay5, int delay6, int delay7, int delay8, int delay9){
	OutputReport[0] = 0;  //do not remove, must be 0

	OutputReport[1] = delay1; //ch1
	OutputReport[2] = delay2; //ch2
	OutputReport[3] = delay3; //ch3

	OutputReport[4] = delay4; //ch4
	OutputReport[5] = delay5; //ch5
	OutputReport[6] = delay6; //ch6

	OutputReport[7] = delay7; //ch7
	OutputReport[8] = delay8; //ch8
	OutputReport[9] = delay9; //ch9

	if(!WriteFile(DeviceHandle, OutputReport, Capabilities.OutputReportByteLength, &BytesWritten, NULL)) {
		CloseHandle(DeviceHandle);
		connected = false;
		return false;
	}

	return true;
}