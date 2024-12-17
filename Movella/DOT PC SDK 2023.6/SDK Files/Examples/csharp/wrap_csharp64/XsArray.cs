
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

public class XsArray : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal XsArray(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(XsArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~XsArray() {
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
          movelladot_pc_sdkPINVOKE.delete_XsArray(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public SWIGTYPE_p_void m_data {
    get {
      global::System.IntPtr cPtr = movelladot_pc_sdkPINVOKE.XsArray_m_data_get(swigCPtr);
      SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
      return ret;
    } 
  }

  public uint m_size {
    get {
      uint ret = movelladot_pc_sdkPINVOKE.XsArray_m_size_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_reserved {
    get {
      uint ret = movelladot_pc_sdkPINVOKE.XsArray_m_reserved_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_flags {
    get {
      uint ret = movelladot_pc_sdkPINVOKE.XsArray_m_flags_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_XsArrayDescriptor m_descriptor {
    get {
      global::System.IntPtr cPtr = movelladot_pc_sdkPINVOKE.XsArray_m_descriptor_get(swigCPtr);
      SWIGTYPE_p_XsArrayDescriptor ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_XsArrayDescriptor(cPtr, false);
      return ret;
    } 
  }

  public XsArray(SWIGTYPE_p_XsArrayDescriptor descriptor, uint count, SWIGTYPE_p_void src) : this(movelladot_pc_sdkPINVOKE.new_XsArray__SWIG_0(SWIGTYPE_p_XsArrayDescriptor.getCPtr(descriptor), count, SWIGTYPE_p_void.getCPtr(src)), true) {
  }

  public XsArray(XsArray src) : this(movelladot_pc_sdkPINVOKE.new_XsArray__SWIG_1(XsArray.getCPtr(src)), true) {
    if (movelladot_pc_sdkPINVOKE.SWIGPendingException.Pending) throw movelladot_pc_sdkPINVOKE.SWIGPendingException.Retrieve();
  }

  public XsArray(SWIGTYPE_p_XsArrayDescriptor descriptor, SWIGTYPE_p_void ref_, uint count, XsDataFlags flags) : this(movelladot_pc_sdkPINVOKE.new_XsArray__SWIG_2(SWIGTYPE_p_XsArrayDescriptor.getCPtr(descriptor), SWIGTYPE_p_void.getCPtr(ref_), count, (int)flags), true) {
  }

}

}