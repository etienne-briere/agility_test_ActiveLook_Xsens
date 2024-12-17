
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

public class XsFilterProfileArray : XsFilterProfileArrayImpl {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal XsFilterProfileArray(global::System.IntPtr cPtr, bool cMemoryOwn) : base(movelladot_pc_sdkPINVOKE.XsFilterProfileArray_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(XsFilterProfileArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          movelladot_pc_sdkPINVOKE.delete_XsFilterProfileArray(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public XsFilterProfileArray(uint sz, XsFilterProfile src) : this(movelladot_pc_sdkPINVOKE.new_XsFilterProfileArray__SWIG_0(sz, XsFilterProfile.getCPtr(src)), true) {
  }

  public XsFilterProfileArray(uint sz) : this(movelladot_pc_sdkPINVOKE.new_XsFilterProfileArray__SWIG_1(sz), true) {
  }

  public XsFilterProfileArray() : this(movelladot_pc_sdkPINVOKE.new_XsFilterProfileArray__SWIG_2(), true) {
  }

  public XsFilterProfileArray(XsFilterProfileArray other) : this(movelladot_pc_sdkPINVOKE.new_XsFilterProfileArray__SWIG_3(XsFilterProfileArray.getCPtr(other)), true) {
    if (movelladot_pc_sdkPINVOKE.SWIGPendingException.Pending) throw movelladot_pc_sdkPINVOKE.SWIGPendingException.Retrieve();
  }

  public XsFilterProfileArray(XsFilterProfile ref_, uint sz, XsDataFlags flags) : this(movelladot_pc_sdkPINVOKE.new_XsFilterProfileArray__SWIG_4(XsFilterProfile.getCPtr(ref_), sz, (int)flags), true) {
  }

}

}
