
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

public class XsDotConnectionManager {
  private transient long swigCPtr;
  protected transient boolean swigCMemOwn;

  protected XsDotConnectionManager(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(XsDotConnectionManager obj) {
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
        movelladot_pc_sdkJNI.delete_XsDotConnectionManager(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public static XsDotConnectionManager construct() {
    long cPtr = movelladot_pc_sdkJNI.XsDotConnectionManager_construct();
    return (cPtr == 0) ? null : new XsDotConnectionManager(cPtr, false);
  }

  public void destruct() {
    movelladot_pc_sdkJNI.XsDotConnectionManager_destruct(swigCPtr, this);
  }

  public static XsVersion version() {
    return new XsVersion(movelladot_pc_sdkJNI.XsDotConnectionManager_version(), true);
  }

  public void reset() {
    movelladot_pc_sdkJNI.XsDotConnectionManager_reset(swigCPtr, this);
  }

  public XsStringArray getAvailableBluetoothAdapters() {
    return new XsStringArray(movelladot_pc_sdkJNI.XsDotConnectionManager_getAvailableBluetoothAdapters(swigCPtr, this), true);
  }

  public boolean setPreferredBluetoothAdapter(XsString adapterName) {
    return movelladot_pc_sdkJNI.XsDotConnectionManager_setPreferredBluetoothAdapter(swigCPtr, this, XsString.getCPtr(adapterName), adapterName);
  }

  public boolean enableDeviceDetection() {
    return movelladot_pc_sdkJNI.XsDotConnectionManager_enableDeviceDetection(swigCPtr, this);
  }

  public void disableDeviceDetection() {
    movelladot_pc_sdkJNI.XsDotConnectionManager_disableDeviceDetection(swigCPtr, this);
  }

  public XsPortInfoArray detectUsbDevices() {
    return new XsPortInfoArray(movelladot_pc_sdkJNI.XsDotConnectionManager_detectUsbDevices(swigCPtr, this), true);
  }

  public boolean openPort(XsPortInfo portinfo) {
    return movelladot_pc_sdkJNI.XsDotConnectionManager_openPort(swigCPtr, this, XsPortInfo.getCPtr(portinfo), portinfo);
  }

  public void closePort(XsPortInfo portinfo) {
    movelladot_pc_sdkJNI.XsDotConnectionManager_closePort(swigCPtr, this, XsPortInfo.getCPtr(portinfo), portinfo);
  }

  public XsDotDevice device(XsDeviceId deviceId) {
    long cPtr = movelladot_pc_sdkJNI.XsDotConnectionManager_device(swigCPtr, this, XsDeviceId.getCPtr(deviceId), deviceId);
    return (cPtr == 0) ? null : new XsDotDevice(cPtr, false);
  }

  public XsDotUsbDevice usbDevice(XsDeviceId deviceId) {
    long cPtr = movelladot_pc_sdkJNI.XsDotConnectionManager_usbDevice(swigCPtr, this, XsDeviceId.getCPtr(deviceId), deviceId);
    return (cPtr == 0) ? null : new XsDotUsbDevice(cPtr, false);
  }

  public void close() {
    movelladot_pc_sdkJNI.XsDotConnectionManager_close(swigCPtr, this);
  }

  public XsResultValue lastResult() {
    return XsResultValue.swigToEnum(movelladot_pc_sdkJNI.XsDotConnectionManager_lastResult(swigCPtr, this));
  }

  public XsString lastResultText() {
    return new XsString(movelladot_pc_sdkJNI.XsDotConnectionManager_lastResultText(swigCPtr, this), true);
  }

  public boolean startLogging() {
    return movelladot_pc_sdkJNI.XsDotConnectionManager_startLogging(swigCPtr, this);
  }

  public boolean stopLogging() {
    return movelladot_pc_sdkJNI.XsDotConnectionManager_stopLogging(swigCPtr, this);
  }

  public boolean closeLogFile() {
    return movelladot_pc_sdkJNI.XsDotConnectionManager_closeLogFile(swigCPtr, this);
  }

  public boolean startSync(XsString rootNodeMac) {
    return movelladot_pc_sdkJNI.XsDotConnectionManager_startSync(swigCPtr, this, XsString.getCPtr(rootNodeMac), rootNodeMac);
  }

  public boolean stopSync() {
    return movelladot_pc_sdkJNI.XsDotConnectionManager_stopSync(swigCPtr, this);
  }

  public void clearXsDotCallbackHandlers(boolean chain) {
    movelladot_pc_sdkJNI.XsDotConnectionManager_clearXsDotCallbackHandlers__SWIG_0(swigCPtr, this, chain);
  }

  public void clearXsDotCallbackHandlers() {
    movelladot_pc_sdkJNI.XsDotConnectionManager_clearXsDotCallbackHandlers__SWIG_1(swigCPtr, this);
  }

  public XsDotConnectionManager() {
    this(movelladot_pc_sdkJNI.new_XsDotConnectionManager(), true);
  }

  public void addXsDotCallbackHandler(XsDotCallback cb, boolean chain) {
    movelladot_pc_sdkJNI.XsDotConnectionManager_addXsDotCallbackHandler__SWIG_0(swigCPtr, this, XsDotCallback.getCPtr(cb), cb, chain);
  }

  public void addXsDotCallbackHandler(XsDotCallback cb) {
    movelladot_pc_sdkJNI.XsDotConnectionManager_addXsDotCallbackHandler__SWIG_1(swigCPtr, this, XsDotCallback.getCPtr(cb), cb);
  }

  public void removeXsDotCallbackHandler(XsDotCallback cb, boolean chain) {
    movelladot_pc_sdkJNI.XsDotConnectionManager_removeXsDotCallbackHandler__SWIG_0(swigCPtr, this, XsDotCallback.getCPtr(cb), cb, chain);
  }

  public void removeXsDotCallbackHandler(XsDotCallback cb) {
    movelladot_pc_sdkJNI.XsDotConnectionManager_removeXsDotCallbackHandler__SWIG_1(swigCPtr, this, XsDotCallback.getCPtr(cb), cb);
  }

}