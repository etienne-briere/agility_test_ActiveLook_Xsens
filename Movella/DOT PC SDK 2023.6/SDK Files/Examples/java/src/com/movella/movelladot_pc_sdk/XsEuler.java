
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

public class XsEuler {
  private transient long swigCPtr;
  protected transient boolean swigCMemOwn;

  protected XsEuler(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(XsEuler obj) {
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
        movelladot_pc_sdkJNI.delete_XsEuler(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public XsEuler() {
    this(movelladot_pc_sdkJNI.new_XsEuler__SWIG_0(), true);
  }

  public XsEuler(double x_, double y_, double z_) {
    this(movelladot_pc_sdkJNI.new_XsEuler__SWIG_1(x_, y_, z_), true);
  }

  public XsEuler(XsEuler other) {
    this(movelladot_pc_sdkJNI.new_XsEuler__SWIG_2(XsEuler.getCPtr(other), other), true);
  }

  public XsEuler(XsVector other) {
    this(movelladot_pc_sdkJNI.new_XsEuler__SWIG_3(XsVector.getCPtr(other), other), true);
  }

  public XsEuler(XsQuaternion q) {
    this(movelladot_pc_sdkJNI.new_XsEuler__SWIG_4(XsQuaternion.getCPtr(q), q), true);
  }

  public boolean empty() {
    return movelladot_pc_sdkJNI.XsEuler_empty(swigCPtr, this);
  }

  public SWIGTYPE_p_double data() {
    long cPtr = movelladot_pc_sdkJNI.XsEuler_data(swigCPtr, this);
    return (cPtr == 0) ? null : new SWIGTYPE_p_double(cPtr, false);
  }

  public XsEuler fromQuaternion(XsQuaternion quat) {
    return new XsEuler(movelladot_pc_sdkJNI.XsEuler_fromQuaternion(swigCPtr, this, XsQuaternion.getCPtr(quat), quat), false);
  }

  public double roll() {
    return movelladot_pc_sdkJNI.XsEuler_roll(swigCPtr, this);
  }

  public double pitch() {
    return movelladot_pc_sdkJNI.XsEuler_pitch(swigCPtr, this);
  }

  public double yaw() {
    return movelladot_pc_sdkJNI.XsEuler_yaw(swigCPtr, this);
  }

  public double x() {
    return movelladot_pc_sdkJNI.XsEuler_x(swigCPtr, this);
  }

  public double y() {
    return movelladot_pc_sdkJNI.XsEuler_y(swigCPtr, this);
  }

  public double z() {
    return movelladot_pc_sdkJNI.XsEuler_z(swigCPtr, this);
  }

  public boolean isEqual(XsEuler other, double tolerance) {
    return movelladot_pc_sdkJNI.XsEuler_isEqual(swigCPtr, this, XsEuler.getCPtr(other), other, tolerance);
  }

}