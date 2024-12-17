
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

public class XsRawGnssSatInfo {
  private transient long swigCPtr;
  protected transient boolean swigCMemOwn;

  protected XsRawGnssSatInfo(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(XsRawGnssSatInfo obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  @SuppressWarnings("deprecation")
  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        movelladot_pc_sdkJNI.delete_XsRawGnssSatInfo(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public void setM_itow(long value) {
    movelladot_pc_sdkJNI.XsRawGnssSatInfo_m_itow_set(swigCPtr, this, value);
  }

  public long getM_itow() {
    return movelladot_pc_sdkJNI.XsRawGnssSatInfo_m_itow_get(swigCPtr, this);
  }

  public void setM_numSvs(short value) {
    movelladot_pc_sdkJNI.XsRawGnssSatInfo_m_numSvs_set(swigCPtr, this, value);
  }

  public short getM_numSvs() {
    return movelladot_pc_sdkJNI.XsRawGnssSatInfo_m_numSvs_get(swigCPtr, this);
  }

  public void setM_res1(short value) {
    movelladot_pc_sdkJNI.XsRawGnssSatInfo_m_res1_set(swigCPtr, this, value);
  }

  public short getM_res1() {
    return movelladot_pc_sdkJNI.XsRawGnssSatInfo_m_res1_get(swigCPtr, this);
  }

  public void setM_res2(short value) {
    movelladot_pc_sdkJNI.XsRawGnssSatInfo_m_res2_set(swigCPtr, this, value);
  }

  public short getM_res2() {
    return movelladot_pc_sdkJNI.XsRawGnssSatInfo_m_res2_get(swigCPtr, this);
  }

  public void setM_res3(short value) {
    movelladot_pc_sdkJNI.XsRawGnssSatInfo_m_res3_set(swigCPtr, this, value);
  }

  public short getM_res3() {
    return movelladot_pc_sdkJNI.XsRawGnssSatInfo_m_res3_get(swigCPtr, this);
  }

  public void setM_satInfos(XsSatInfo value) {
    movelladot_pc_sdkJNI.XsRawGnssSatInfo_m_satInfos_set(swigCPtr, this, XsSatInfo.getCPtr(value), value);
  }

  public XsSatInfo getM_satInfos() {
    long cPtr = movelladot_pc_sdkJNI.XsRawGnssSatInfo_m_satInfos_get(swigCPtr, this);
    return (cPtr == 0) ? null : new XsSatInfo(cPtr, false);
  }

  public XsRawGnssSatInfo() {
    this(movelladot_pc_sdkJNI.new_XsRawGnssSatInfo(), true);
  }

}