//-----------------------------------------------------------------------------
//	Copyright Endurance R/C 2008
//
//	PCTx/Servo Controller 9 Channel Sample Application
//
//	Please see the file license.txt for more info
//-----------------------------------------------------------------------------

#pragma once
#include <windows.h>
#include <stdio.h>
#include <conio.h>
#include <iostream>

extern "C" {
	#include "hidsdi.h"
	#include <setupapi.h>
}

class controller {
public:
	controller(void);
	~controller(void);

	bool connected;
	bool send(int,int,int,int,int,int,int,int,int);
	bool connect();

private:	
	HANDLE								DeviceHandle;
	HIDP_CAPS							Capabilities;
	BOOL								result;
	CHAR								OutputReport[10]; //Holds the data to be sent to the PCTx or Servo Controller
	DWORD								BytesWritten;
	DWORD								BytesRead;
};