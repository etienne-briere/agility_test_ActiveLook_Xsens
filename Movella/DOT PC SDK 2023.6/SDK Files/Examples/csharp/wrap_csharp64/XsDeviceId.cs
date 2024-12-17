
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

public class XsDeviceId : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal XsDeviceId(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(XsDeviceId obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~XsDeviceId() {
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
          movelladot_pc_sdkPINVOKE.delete_XsDeviceId(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public XsDeviceId(string productCode, ushort hardwareVersion, uint productVariant, ulong serialNumber, ushort subDevice) : this(movelladot_pc_sdkPINVOKE.new_XsDeviceId__SWIG_0(productCode, hardwareVersion, productVariant, serialNumber, subDevice), true) {
  }

  public XsDeviceId(string productCode, ushort hardwareVersion, uint productVariant, ulong serialNumber) : this(movelladot_pc_sdkPINVOKE.new_XsDeviceId__SWIG_1(productCode, hardwareVersion, productVariant, serialNumber), true) {
  }

  public XsDeviceId(ulong serialNumber) : this(movelladot_pc_sdkPINVOKE.new_XsDeviceId__SWIG_2(serialNumber), true) {
  }

  public XsDeviceId() : this(movelladot_pc_sdkPINVOKE.new_XsDeviceId__SWIG_3(), true) {
  }

  public XsDeviceId(XsDeviceId parent, ushort subDevice) : this(movelladot_pc_sdkPINVOKE.new_XsDeviceId__SWIG_4(XsDeviceId.getCPtr(parent), subDevice), true) {
    if (movelladot_pc_sdkPINVOKE.SWIGPendingException.Pending) throw movelladot_pc_sdkPINVOKE.SWIGPendingException.Retrieve();
  }

  public XsDeviceId(XsDeviceId other) : this(movelladot_pc_sdkPINVOKE.new_XsDeviceId__SWIG_5(XsDeviceId.getCPtr(other)), true) {
    if (movelladot_pc_sdkPINVOKE.SWIGPendingException.Pending) throw movelladot_pc_sdkPINVOKE.SWIGPendingException.Retrieve();
  }

  public static ulong legacyBit() {
    ulong ret = movelladot_pc_sdkPINVOKE.XsDeviceId_legacyBit();
    return ret;
  }

  public bool isLegacyDeviceId() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDeviceId_isLegacyDeviceId(swigCPtr);
    return ret;
  }

  public ulong toInt() {
    ulong ret = movelladot_pc_sdkPINVOKE.XsDeviceId_toInt(swigCPtr);
    return ret;
  }

  public XsString productCode() {
    XsString ret = new XsString(movelladot_pc_sdkPINVOKE.XsDeviceId_productCode(swigCPtr), true);
    return ret;
  }

  public uint productVariant() {
    uint ret = movelladot_pc_sdkPINVOKE.XsDeviceId_productVariant(swigCPtr);
    return ret;
  }

  public ushort hardwareVersion() {
    ushort ret = movelladot_pc_sdkPINVOKE.XsDeviceId_hardwareVersion(swigCPtr);
    return ret;
  }

  public ushort subDevice() {
    ushort ret = movelladot_pc_sdkPINVOKE.XsDeviceId_subDevice(swigCPtr);
    return ret;
  }

  public uint legacyDeviceId() {
    uint ret = movelladot_pc_sdkPINVOKE.XsDeviceId_legacyDeviceId(swigCPtr);
    return ret;
  }

  public bool isMtiX() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDeviceId_isMtiX(swigCPtr);
    return ret;
  }

  public bool isMtiX0() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDeviceId_isMtiX0(swigCPtr);
    return ret;
  }

  public bool isMtiX00() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDeviceId_isMtiX00(swigCPtr);
    return ret;
  }

  public bool isMtigX00() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDeviceId_isMtigX00(swigCPtr);
    return ret;
  }

  public bool isMtigX10() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDeviceId_isMtigX10(swigCPtr);
    return ret;
  }

  public bool isMti3X0() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDeviceId_isMti3X0(swigCPtr);
    return ret;
  }

  public bool isMti6X0() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDeviceId_isMti6X0(swigCPtr);
    return ret;
  }

  public bool isMti8X0() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDeviceId_isMti8X0(swigCPtr);
    return ret;
  }

  public bool isGlove() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDeviceId_isGlove(swigCPtr);
    return ret;
  }

  public XsHandId side() {
    XsHandId ret = (XsHandId)movelladot_pc_sdkPINVOKE.XsDeviceId_side(swigCPtr);
    return ret;
  }

  public bool isDot() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDeviceId_isDot(swigCPtr);
    return ret;
  }

  public bool isRugged() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDeviceId_isRugged(swigCPtr);
    return ret;
  }

  public bool isMtw() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDeviceId_isMtw(swigCPtr);
    return ret;
  }

  public bool isMtw2() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDeviceId_isMtw2(swigCPtr);
    return ret;
  }

  public bool isMtw2Obskur() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDeviceId_isMtw2Obskur(swigCPtr);
    return ret;
  }

  public bool isMtx() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDeviceId_isMtx(swigCPtr);
    return ret;
  }

  public bool isMtx2() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDeviceId_isMtx2(swigCPtr);
    return ret;
  }

  public bool isBodyPack() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDeviceId_isBodyPack(swigCPtr);
    return ret;
  }

  public bool isBodyPackV1() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDeviceId_isBodyPackV1(swigCPtr);
    return ret;
  }

  public bool isBodyPackV2() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDeviceId_isBodyPackV2(swigCPtr);
    return ret;
  }

  public bool isWirelessMaster() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDeviceId_isWirelessMaster(swigCPtr);
    return ret;
  }

  public bool isAwindaX() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDeviceId_isAwindaX(swigCPtr);
    return ret;
  }

  public bool isAwindaXStation() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDeviceId_isAwindaXStation(swigCPtr);
    return ret;
  }

  public bool isAwindaXDongle() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDeviceId_isAwindaXDongle(swigCPtr);
    return ret;
  }

  public bool isAwindaXOem() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDeviceId_isAwindaXOem(swigCPtr);
    return ret;
  }

  public bool isAwinda2() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDeviceId_isAwinda2(swigCPtr);
    return ret;
  }

  public bool isAwinda2Station() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDeviceId_isAwinda2Station(swigCPtr);
    return ret;
  }

  public bool isAwinda2Dongle() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDeviceId_isAwinda2Dongle(swigCPtr);
    return ret;
  }

  public bool isAwinda2Oem() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDeviceId_isAwinda2Oem(swigCPtr);
    return ret;
  }

  public bool isSyncStationX() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDeviceId_isSyncStationX(swigCPtr);
    return ret;
  }

  public bool isSyncStation2() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDeviceId_isSyncStation2(swigCPtr);
    return ret;
  }

  public bool isHilDevice() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDeviceId_isHilDevice(swigCPtr);
    return ret;
  }

  public bool isImu() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDeviceId_isImu(swigCPtr);
    return ret;
  }

  public bool isVru() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDeviceId_isVru(swigCPtr);
    return ret;
  }

  public bool isAhrs() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDeviceId_isAhrs(swigCPtr);
    return ret;
  }

  public bool isGnss() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDeviceId_isGnss(swigCPtr);
    return ret;
  }

  public bool isRtk() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDeviceId_isRtk(swigCPtr);
    return ret;
  }

  public bool hasInternalGnss() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDeviceId_hasInternalGnss(swigCPtr);
    return ret;
  }

  public bool isContainerDevice() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDeviceId_isContainerDevice(swigCPtr);
    return ret;
  }

  public bool isMt() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDeviceId_isMt(swigCPtr);
    return ret;
  }

  public bool isMti() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDeviceId_isMti(swigCPtr);
    return ret;
  }

  public bool isMtig() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDeviceId_isMtig(swigCPtr);
    return ret;
  }

  public bool isMtMark4() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDeviceId_isMtMark4(swigCPtr);
    return ret;
  }

  public bool isMtMark5() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDeviceId_isMtMark5(swigCPtr);
    return ret;
  }

  public XsString toXsString() {
    XsString ret = new XsString(movelladot_pc_sdkPINVOKE.XsDeviceId_toXsString(swigCPtr), true);
    return ret;
  }

  public void fromString(XsString str) {
    movelladot_pc_sdkPINVOKE.XsDeviceId_fromString(swigCPtr, XsString.getCPtr(str));
    if (movelladot_pc_sdkPINVOKE.SWIGPendingException.Pending) throw movelladot_pc_sdkPINVOKE.SWIGPendingException.Retrieve();
  }

  public XsString toDeviceTypeString(bool makeType) {
    XsString ret = new XsString(movelladot_pc_sdkPINVOKE.XsDeviceId_toDeviceTypeString__SWIG_0(swigCPtr, makeType), true);
    return ret;
  }

  public XsString toDeviceTypeString() {
    XsString ret = new XsString(movelladot_pc_sdkPINVOKE.XsDeviceId_toDeviceTypeString__SWIG_1(swigCPtr), true);
    return ret;
  }

  public void fromDeviceTypeString(XsString str) {
    movelladot_pc_sdkPINVOKE.XsDeviceId_fromDeviceTypeString(swigCPtr, XsString.getCPtr(str));
    if (movelladot_pc_sdkPINVOKE.SWIGPendingException.Pending) throw movelladot_pc_sdkPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool isValid() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDeviceId_isValid(swigCPtr);
    return ret;
  }

  public bool contains(XsDeviceId other) {
    bool ret = movelladot_pc_sdkPINVOKE.XsDeviceId_contains(swigCPtr, XsDeviceId.getCPtr(other));
    if (movelladot_pc_sdkPINVOKE.SWIGPendingException.Pending) throw movelladot_pc_sdkPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isType() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDeviceId_isType(swigCPtr);
    return ret;
  }

  public XsString typeName() {
    XsString ret = new XsString(movelladot_pc_sdkPINVOKE.XsDeviceId_typeName(swigCPtr), true);
    return ret;
  }

  public XsDeviceId type() {
    XsDeviceId ret = new XsDeviceId(movelladot_pc_sdkPINVOKE.XsDeviceId_type(swigCPtr), true);
    return ret;
  }

  public XsDeviceId deviceType(bool detailed) {
    XsDeviceId ret = new XsDeviceId(movelladot_pc_sdkPINVOKE.XsDeviceId_deviceType__SWIG_0(swigCPtr, detailed), true);
    return ret;
  }

  public XsDeviceId deviceType() {
    XsDeviceId ret = new XsDeviceId(movelladot_pc_sdkPINVOKE.XsDeviceId_deviceType__SWIG_1(swigCPtr), true);
    return ret;
  }

  public XsDeviceId deviceTypeMask(bool detailed) {
    XsDeviceId ret = new XsDeviceId(movelladot_pc_sdkPINVOKE.XsDeviceId_deviceTypeMask__SWIG_0(swigCPtr, detailed), true);
    return ret;
  }

  public XsDeviceId deviceTypeMask() {
    XsDeviceId ret = new XsDeviceId(movelladot_pc_sdkPINVOKE.XsDeviceId_deviceTypeMask__SWIG_1(swigCPtr), true);
    return ret;
  }

  public ushort basePart() {
    ushort ret = movelladot_pc_sdkPINVOKE.XsDeviceId_basePart(swigCPtr);
    return ret;
  }

}

}