
//  WARNING: COPYRIGHT (C) 2023 MOVELLA TECHNOLOGIES OR SUBSIDIARIES WORLDWIDE. ALL RIGHTS RESERVED.
//  THIS FILE AND THE SOURCE CODE IT CONTAINS (AND/OR THE BINARY CODE FILES FOUND IN THE SAME
//  FOLDER THAT CONTAINS THIS FILE) AND ALL RELATED SOFTWARE (COLLECTIVELY, "CODE") ARE SUBJECT
//  TO A RESTRICTED LICENSE AGREEMENT ("AGREEMENT") BETWEEN XSENS AS LICENSOR AND THE AUTHORIZED
//  LICENSEE UNDER THE AGREEMENT. THE CODE MUST BE USED SOLELY WITH XSENS PRODUCTS INCORPORATED
//  INTO LICENSEE PRODUCTS IN ACCORDANCE WITH THE AGREEMENT. ANY USE, MODIFICATION, COPYING OR
//  DISTRIBUTION OF THE CODE IS STRICTLY PROHIBITED UNLESS EXPRESSLY AUTHORIZED BY THE AGREEMENT.
//  IF YOU ARE NOT AN AUTHORIZED USER OF THE CODE IN ACCORDANCE WITH THE AGREEMENT, YOU MUST STOP
//  USING OR VIEWING THE CODE NOW, REMOVE ANY COPIES OF THE CODE FROM YOUR COMPUTER AND NOTIFY
//  XSENS IMMEDIATELY BY EMAIL TO INFO@XSENS.COM. ANY COPIES OR DERIVATIVES OF THE CODE (IN WHOLE
//  OR IN PART) IN SOURCE CODE FORM THAT ARE PERMITTED BY THE AGREEMENT MUST RETAIN THE ABOVE
//  COPYRIGHT NOTICE AND THIS PARAGRAPH IN ITS ENTIRETY, AS REQUIRED BY THE AGREEMENT.
//  

//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace MovellaDotPcSdk {

public class XsDotCallbackPlainC : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal XsDotCallbackPlainC(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(XsDotCallbackPlainC obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~XsDotCallbackPlainC() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          movelladot_pc_sdkPINVOKE.delete_XsDotCallbackPlainC(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_q_const__XsPortInfo__void m_onAdvertisementFound {
    set {
      movelladot_pc_sdkPINVOKE.XsDotCallbackPlainC_m_onAdvertisementFound_set(swigCPtr, SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_q_const__XsPortInfo__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = movelladot_pc_sdkPINVOKE.XsDotCallbackPlainC_m_onAdvertisementFound_get(swigCPtr);
      SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_q_const__XsPortInfo__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_q_const__XsPortInfo__void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_XsDotDevice_int_int__void m_onBatteryUpdated {
    set {
      movelladot_pc_sdkPINVOKE.XsDotCallbackPlainC_m_onBatteryUpdated_set(swigCPtr, SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_XsDotDevice_int_int__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = movelladot_pc_sdkPINVOKE.XsDotCallbackPlainC_m_onBatteryUpdated_get(swigCPtr);
      SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_XsDotDevice_int_int__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_XsDotDevice_int_int__void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_XsDotDevice_p_q_const__XsDataPacket__void m_onLiveDataAvailable {
    set {
      movelladot_pc_sdkPINVOKE.XsDotCallbackPlainC_m_onLiveDataAvailable_set(swigCPtr, SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_XsDotDevice_p_q_const__XsDataPacket__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = movelladot_pc_sdkPINVOKE.XsDotCallbackPlainC_m_onLiveDataAvailable_get(swigCPtr);
      SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_XsDotDevice_p_q_const__XsDataPacket__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_XsDotDevice_p_q_const__XsDataPacket__void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_XsDotDevice_int_int_p_q_const__XsString__void m_onProgressUpdated {
    set {
      movelladot_pc_sdkPINVOKE.XsDotCallbackPlainC_m_onProgressUpdated_set(swigCPtr, SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_XsDotDevice_int_int_p_q_const__XsString__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = movelladot_pc_sdkPINVOKE.XsDotCallbackPlainC_m_onProgressUpdated_get(swigCPtr);
      SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_XsDotDevice_int_int_p_q_const__XsString__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_XsDotDevice_int_int_p_q_const__XsString__void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_q_const__XsPortInfo_enum_XsDotFirmwareUpdateResult__void m_onDeviceUpdateDone {
    set {
      movelladot_pc_sdkPINVOKE.XsDotCallbackPlainC_m_onDeviceUpdateDone_set(swigCPtr, SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_q_const__XsPortInfo_enum_XsDotFirmwareUpdateResult__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = movelladot_pc_sdkPINVOKE.XsDotCallbackPlainC_m_onDeviceUpdateDone_get(swigCPtr);
      SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_q_const__XsPortInfo_enum_XsDotFirmwareUpdateResult__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_q_const__XsPortInfo_enum_XsDotFirmwareUpdateResult__void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_XsDotCallbackPlainC_enum_XsResultValue_p_q_const__XsString__void m_onError {
    set {
      movelladot_pc_sdkPINVOKE.XsDotCallbackPlainC_m_onError_set(swigCPtr, SWIGTYPE_p_f_p_XsDotCallbackPlainC_enum_XsResultValue_p_q_const__XsString__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = movelladot_pc_sdkPINVOKE.XsDotCallbackPlainC_m_onError_get(swigCPtr);
      SWIGTYPE_p_f_p_XsDotCallbackPlainC_enum_XsResultValue_p_q_const__XsString__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_XsDotCallbackPlainC_enum_XsResultValue_p_q_const__XsString__void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_XsDotDevice_p_q_const__XsDataPacket__void m_onRecordedDataAvailable {
    set {
      movelladot_pc_sdkPINVOKE.XsDotCallbackPlainC_m_onRecordedDataAvailable_set(swigCPtr, SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_XsDotDevice_p_q_const__XsDataPacket__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = movelladot_pc_sdkPINVOKE.XsDotCallbackPlainC_m_onRecordedDataAvailable_get(swigCPtr);
      SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_XsDotDevice_p_q_const__XsDataPacket__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_XsDotDevice_p_q_const__XsDataPacket__void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_XsDotDevice__void m_onRecordingStopped {
    set {
      movelladot_pc_sdkPINVOKE.XsDotCallbackPlainC_m_onRecordingStopped_set(swigCPtr, SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_XsDotDevice__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = movelladot_pc_sdkPINVOKE.XsDotCallbackPlainC_m_onRecordingStopped_get(swigCPtr);
      SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_XsDotDevice__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_XsDotDevice__void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_XsDotDevice_enum_XsDeviceState_enum_XsDeviceState__void m_onDeviceStateChanged {
    set {
      movelladot_pc_sdkPINVOKE.XsDotCallbackPlainC_m_onDeviceStateChanged_set(swigCPtr, SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_XsDotDevice_enum_XsDeviceState_enum_XsDeviceState__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = movelladot_pc_sdkPINVOKE.XsDotCallbackPlainC_m_onDeviceStateChanged_get(swigCPtr);
      SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_XsDotDevice_enum_XsDeviceState_enum_XsDeviceState__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_XsDotDevice_enum_XsDeviceState_enum_XsDeviceState__void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_XsDotDevice_unsigned_int__void m_onButtonClicked {
    set {
      movelladot_pc_sdkPINVOKE.XsDotCallbackPlainC_m_onButtonClicked_set(swigCPtr, SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_XsDotDevice_unsigned_int__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = movelladot_pc_sdkPINVOKE.XsDotCallbackPlainC_m_onButtonClicked_get(swigCPtr);
      SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_XsDotDevice_unsigned_int__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_XsDotDevice_unsigned_int__void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_XsDotDevice__void m_onRecordedDataDone {
    set {
      movelladot_pc_sdkPINVOKE.XsDotCallbackPlainC_m_onRecordedDataDone_set(swigCPtr, SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_XsDotDevice__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = movelladot_pc_sdkPINVOKE.XsDotCallbackPlainC_m_onRecordedDataDone_get(swigCPtr);
      SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_XsDotDevice__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_XsDotDevice__void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_XsDotUsbDevice_int_int_p_q_const__XsString__void m_onUsbProgressUpdated {
    set {
      movelladot_pc_sdkPINVOKE.XsDotCallbackPlainC_m_onUsbProgressUpdated_set(swigCPtr, SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_XsDotUsbDevice_int_int_p_q_const__XsString__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = movelladot_pc_sdkPINVOKE.XsDotCallbackPlainC_m_onUsbProgressUpdated_get(swigCPtr);
      SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_XsDotUsbDevice_int_int_p_q_const__XsString__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_XsDotUsbDevice_int_int_p_q_const__XsString__void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_XsDotUsbDevice_p_q_const__XsDataPacket__void m_onUsbRecordedDataAvailable {
    set {
      movelladot_pc_sdkPINVOKE.XsDotCallbackPlainC_m_onUsbRecordedDataAvailable_set(swigCPtr, SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_XsDotUsbDevice_p_q_const__XsDataPacket__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = movelladot_pc_sdkPINVOKE.XsDotCallbackPlainC_m_onUsbRecordedDataAvailable_get(swigCPtr);
      SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_XsDotUsbDevice_p_q_const__XsDataPacket__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_XsDotUsbDevice_p_q_const__XsDataPacket__void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_XsDotUsbDevice__void m_onUsbRecordedDataDone {
    set {
      movelladot_pc_sdkPINVOKE.XsDotCallbackPlainC_m_onUsbRecordedDataDone_set(swigCPtr, SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_XsDotUsbDevice__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = movelladot_pc_sdkPINVOKE.XsDotCallbackPlainC_m_onUsbRecordedDataDone_get(swigCPtr);
      SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_XsDotUsbDevice__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_XsDotCallbackPlainC_p_XsDotUsbDevice__void(cPtr, false);
      return ret;
    } 
  }

  public XsDotCallbackPlainC() : this(movelladot_pc_sdkPINVOKE.new_XsDotCallbackPlainC(), true) {
  }

}

}