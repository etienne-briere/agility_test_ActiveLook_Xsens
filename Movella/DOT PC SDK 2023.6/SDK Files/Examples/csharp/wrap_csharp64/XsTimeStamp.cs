
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

public class XsTimeStamp : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal XsTimeStamp(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(XsTimeStamp obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~XsTimeStamp() {
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
          movelladot_pc_sdkPINVOKE.delete_XsTimeStamp(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public XsTimeStamp(long t) : this(movelladot_pc_sdkPINVOKE.new_XsTimeStamp__SWIG_0(t), true) {
  }

  public XsTimeStamp() : this(movelladot_pc_sdkPINVOKE.new_XsTimeStamp__SWIG_1(), true) {
  }

  public XsTimeStamp(int t) : this(movelladot_pc_sdkPINVOKE.new_XsTimeStamp__SWIG_2(t), true) {
  }

  public XsTimeStamp(double t) : this(movelladot_pc_sdkPINVOKE.new_XsTimeStamp__SWIG_3(t), true) {
  }

  public XsTimeStamp(XsTimeStamp other) : this(movelladot_pc_sdkPINVOKE.new_XsTimeStamp__SWIG_4(XsTimeStamp.getCPtr(other)), true) {
    if (movelladot_pc_sdkPINVOKE.SWIGPendingException.Pending) throw movelladot_pc_sdkPINVOKE.SWIGPendingException.Retrieve();
  }

  public XsTimeStamp(XsTimeInfo info) : this(movelladot_pc_sdkPINVOKE.new_XsTimeStamp__SWIG_5(XsTimeInfo.getCPtr(info)), true) {
    if (movelladot_pc_sdkPINVOKE.SWIGPendingException.Pending) throw movelladot_pc_sdkPINVOKE.SWIGPendingException.Retrieve();
  }

  public XsTimeInfo toTimeInfo() {
    XsTimeInfo ret = new XsTimeInfo(movelladot_pc_sdkPINVOKE.XsTimeStamp_toTimeInfo__SWIG_0(swigCPtr), true);
    return ret;
  }

  public void toTimeInfo(XsTimeInfo info) {
    movelladot_pc_sdkPINVOKE.XsTimeStamp_toTimeInfo__SWIG_1(swigCPtr, XsTimeInfo.getCPtr(info));
    if (movelladot_pc_sdkPINVOKE.SWIGPendingException.Pending) throw movelladot_pc_sdkPINVOKE.SWIGPendingException.Retrieve();
  }

  public XsString toXsString() {
    XsString ret = new XsString(movelladot_pc_sdkPINVOKE.XsTimeStamp_toXsString(swigCPtr), true);
    return ret;
  }

  public long msTime() {
    long ret = movelladot_pc_sdkPINVOKE.XsTimeStamp_msTime(swigCPtr);
    return ret;
  }

  public void setMsTime(long t) {
    movelladot_pc_sdkPINVOKE.XsTimeStamp_setMsTime(swigCPtr, t);
  }

  public double timeOfDay() {
    double ret = movelladot_pc_sdkPINVOKE.XsTimeStamp_timeOfDay(swigCPtr);
    return ret;
  }

  public long msTimeOfDay() {
    long ret = movelladot_pc_sdkPINVOKE.XsTimeStamp_msTimeOfDay(swigCPtr);
    return ret;
  }

  public double secTime() {
    double ret = movelladot_pc_sdkPINVOKE.XsTimeStamp_secTime(swigCPtr);
    return ret;
  }

  public void setSecTime(double t) {
    movelladot_pc_sdkPINVOKE.XsTimeStamp_setSecTime(swigCPtr, t);
  }

  public long secondTime() {
    long ret = movelladot_pc_sdkPINVOKE.XsTimeStamp_secondTime(swigCPtr);
    return ret;
  }

  public int milliSecondPart() {
    int ret = movelladot_pc_sdkPINVOKE.XsTimeStamp_milliSecondPart(swigCPtr);
    return ret;
  }

  public int secondPart() {
    int ret = movelladot_pc_sdkPINVOKE.XsTimeStamp_secondPart(swigCPtr);
    return ret;
  }

  public int minutePart() {
    int ret = movelladot_pc_sdkPINVOKE.XsTimeStamp_minutePart(swigCPtr);
    return ret;
  }

  public int hourPart() {
    int ret = movelladot_pc_sdkPINVOKE.XsTimeStamp_hourPart(swigCPtr);
    return ret;
  }

  public static XsTimeStamp now() {
    XsTimeStamp ret = new XsTimeStamp(movelladot_pc_sdkPINVOKE.XsTimeStamp_now(), true);
    return ret;
  }

  public static long nowMs() {
    long ret = movelladot_pc_sdkPINVOKE.XsTimeStamp_nowMs();
    return ret;
  }

  public long elapsedToNow() {
    long ret = movelladot_pc_sdkPINVOKE.XsTimeStamp_elapsedToNow(swigCPtr);
    return ret;
  }

  public static XsTimeStamp maxValue() {
    XsTimeStamp ret = new XsTimeStamp(movelladot_pc_sdkPINVOKE.XsTimeStamp_maxValue(), true);
    return ret;
  }

  public XsTimeStamp utcToLocalTime() {
    XsTimeStamp ret = new XsTimeStamp(movelladot_pc_sdkPINVOKE.XsTimeStamp_utcToLocalTime__SWIG_0(swigCPtr), true);
    return ret;
  }

  public XsTimeStamp localToUtcTime() {
    XsTimeStamp ret = new XsTimeStamp(movelladot_pc_sdkPINVOKE.XsTimeStamp_localToUtcTime__SWIG_0(swigCPtr), true);
    return ret;
  }

  public XsTimeStamp utcToLocalTime(XsTimeInfo info) {
    XsTimeStamp ret = new XsTimeStamp(movelladot_pc_sdkPINVOKE.XsTimeStamp_utcToLocalTime__SWIG_1(swigCPtr, XsTimeInfo.getCPtr(info)), true);
    if (movelladot_pc_sdkPINVOKE.SWIGPendingException.Pending) throw movelladot_pc_sdkPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public XsTimeStamp localToUtcTime(XsTimeInfo info) {
    XsTimeStamp ret = new XsTimeStamp(movelladot_pc_sdkPINVOKE.XsTimeStamp_localToUtcTime__SWIG_1(swigCPtr, XsTimeInfo.getCPtr(info)), true);
    if (movelladot_pc_sdkPINVOKE.SWIGPendingException.Pending) throw movelladot_pc_sdkPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public XsTimeStamp utcToLocalTime(long utcOffset) {
    XsTimeStamp ret = new XsTimeStamp(movelladot_pc_sdkPINVOKE.XsTimeStamp_utcToLocalTime__SWIG_2(swigCPtr, utcOffset), true);
    return ret;
  }

  public XsTimeStamp localToUtcTime(long utcOffset) {
    XsTimeStamp ret = new XsTimeStamp(movelladot_pc_sdkPINVOKE.XsTimeStamp_localToUtcTime__SWIG_2(swigCPtr, utcOffset), true);
    return ret;
  }

}

}
