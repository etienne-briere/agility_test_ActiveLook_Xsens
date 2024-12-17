
//  Copyright (c) 2003-2023 Movella Technologies B.V. or subsidiaries worldwide.
//  All rights reserved.
//  
//  Redistribution and use in source and binary forms, with or without modification,
//  are permitted provided that the following conditions are met:
//  
//  1.	Redistributions of source code must retain the above copyright notice,
//  	this list of conditions and the following disclaimer.
//  
//  2.	Redistributions in binary form must reproduce the above copyright notice,
//  	this list of conditions and the following disclaimer in the documentation
//  	and/or other materials provided with the distribution.
//  
//  3.	Neither the names of the copyright holders nor the names of their contributors
//  	may be used to endorse or promote products derived from this software without
//  	specific prior written permission.
//  
//  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY
//  EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF
//  MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL
//  THE COPYRIGHT HOLDERS OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
//  SPECIAL, EXEMPLARY OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT
//  OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)
//  HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY OR
//  TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
//  SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
//  

#ifndef XSDEVICEPARAMETERIDENTIFIER_H
#define XSDEVICEPARAMETERIDENTIFIER_H

//////////////////////////////////////////////////////////////////////////////////////////
/*!	\addtogroup enums Global enumerations
    @{
*/

/*!	\enum XsDeviceParameterIdentifier
	\brief Defines the device parameter identifiers.
	\sa XsDevice::setDeviceParameter for a detailed description of the following identifiers.
*/
enum XsDeviceParameterIdentifier
{
	XDPI_Unknown			= 0x0000,	/*!< Invalid value, set if the desired parameter is not supported. */
	XDPI_PacketErrorRate	= 0x0001,
	XDPI_ExtendedBuffer		= 0x0002,
	XDPI_UplinkTimeout		= 0x0003,
	XDPI_SyncLossTimeout	= 0x0004,
};
/*! @} */

typedef enum XsDeviceParameterIdentifier XsDeviceParameterIdentifier;

#endif