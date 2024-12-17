
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

/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 4.0.1
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.movella.movelladot_pc_sdk;

public final class XsRecordingExportDataField {
  public final static XsRecordingExportDataField RecordingData_Timestamp = new XsRecordingExportDataField("RecordingData_Timestamp", movelladot_pc_sdkJNI.RecordingData_Timestamp_get());
  public final static XsRecordingExportDataField RecordingData_Quaternion = new XsRecordingExportDataField("RecordingData_Quaternion", movelladot_pc_sdkJNI.RecordingData_Quaternion_get());
  public final static XsRecordingExportDataField RecordingData_iQ = new XsRecordingExportDataField("RecordingData_iQ", movelladot_pc_sdkJNI.RecordingData_iQ_get());
  public final static XsRecordingExportDataField RecordingData_iV = new XsRecordingExportDataField("RecordingData_iV", movelladot_pc_sdkJNI.RecordingData_iV_get());
  public final static XsRecordingExportDataField RecordingData_Euler = new XsRecordingExportDataField("RecordingData_Euler", movelladot_pc_sdkJNI.RecordingData_Euler_get());
  public final static XsRecordingExportDataField RecordingData_dQ = new XsRecordingExportDataField("RecordingData_dQ", movelladot_pc_sdkJNI.RecordingData_dQ_get());
  public final static XsRecordingExportDataField RecordingData_dV = new XsRecordingExportDataField("RecordingData_dV", movelladot_pc_sdkJNI.RecordingData_dV_get());
  public final static XsRecordingExportDataField RecordingData_Acceleration = new XsRecordingExportDataField("RecordingData_Acceleration", movelladot_pc_sdkJNI.RecordingData_Acceleration_get());
  public final static XsRecordingExportDataField RecordingData_AngularVelocity = new XsRecordingExportDataField("RecordingData_AngularVelocity", movelladot_pc_sdkJNI.RecordingData_AngularVelocity_get());
  public final static XsRecordingExportDataField RecordingData_MagneticField = new XsRecordingExportDataField("RecordingData_MagneticField", movelladot_pc_sdkJNI.RecordingData_MagneticField_get());
  public final static XsRecordingExportDataField RecordingData_Status = new XsRecordingExportDataField("RecordingData_Status", movelladot_pc_sdkJNI.RecordingData_Status_get());
  public final static XsRecordingExportDataField RecordingData_ClipCountAcc = new XsRecordingExportDataField("RecordingData_ClipCountAcc", movelladot_pc_sdkJNI.RecordingData_ClipCountAcc_get());
  public final static XsRecordingExportDataField RecordingData_ClipCountGyro = new XsRecordingExportDataField("RecordingData_ClipCountGyro", movelladot_pc_sdkJNI.RecordingData_ClipCountGyro_get());

  public final int swigValue() {
    return swigValue;
  }

  public String toString() {
    return swigName;
  }

  public static XsRecordingExportDataField swigToEnum(int swigValue) {
    if (swigValue < swigValues.length && swigValue >= 0 && swigValues[swigValue].swigValue == swigValue)
      return swigValues[swigValue];
    for (int i = 0; i < swigValues.length; i++)
      if (swigValues[i].swigValue == swigValue)
        return swigValues[i];
    throw new IllegalArgumentException("No enum " + XsRecordingExportDataField.class + " with value " + swigValue);
  }

  private XsRecordingExportDataField(String swigName) {
    this.swigName = swigName;
    this.swigValue = swigNext++;
  }

  private XsRecordingExportDataField(String swigName, int swigValue) {
    this.swigName = swigName;
    this.swigValue = swigValue;
    swigNext = swigValue+1;
  }

  private XsRecordingExportDataField(String swigName, XsRecordingExportDataField swigEnum) {
    this.swigName = swigName;
    this.swigValue = swigEnum.swigValue;
    swigNext = this.swigValue+1;
  }

  private static XsRecordingExportDataField[] swigValues = { RecordingData_Timestamp, RecordingData_Quaternion, RecordingData_iQ, RecordingData_iV, RecordingData_Euler, RecordingData_dQ, RecordingData_dV, RecordingData_Acceleration, RecordingData_AngularVelocity, RecordingData_MagneticField, RecordingData_Status, RecordingData_ClipCountAcc, RecordingData_ClipCountGyro };
  private static int swigNext = 0;
  private final int swigValue;
  private final String swigName;
}

