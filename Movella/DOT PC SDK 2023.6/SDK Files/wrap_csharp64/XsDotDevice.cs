
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

public class XsDotDevice : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal XsDotDevice(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(XsDotDevice obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~XsDotDevice() {
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
          movelladot_pc_sdkPINVOKE.delete_XsDotDevice(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public void readDeviceControl() {
    movelladot_pc_sdkPINVOKE.XsDotDevice_readDeviceControl(swigCPtr);
  }

  public XsVersion firmwareVersion() {
    XsVersion ret = new XsVersion(movelladot_pc_sdkPINVOKE.XsDotDevice_firmwareVersion(swigCPtr), true);
    return ret;
  }

  public XsVersion hardwareVersion() {
    XsVersion ret = new XsVersion(movelladot_pc_sdkPINVOKE.XsDotDevice_hardwareVersion(swigCPtr), true);
    return ret;
  }

  public XsString buildInfo() {
    XsString ret = new XsString(movelladot_pc_sdkPINVOKE.XsDotDevice_buildInfo(swigCPtr), true);
    return ret;
  }

  public XsString bluetoothAddress() {
    XsString ret = new XsString(movelladot_pc_sdkPINVOKE.XsDotDevice_bluetoothAddress(swigCPtr), true);
    return ret;
  }

  public XsString productCode() {
    XsString ret = new XsString(movelladot_pc_sdkPINVOKE.XsDotDevice_productCode(swigCPtr), true);
    return ret;
  }

  public uint softDeviceVersion() {
    uint ret = movelladot_pc_sdkPINVOKE.XsDotDevice_softDeviceVersion(swigCPtr);
    return ret;
  }

  public XsString deviceTagName() {
    XsString ret = new XsString(movelladot_pc_sdkPINVOKE.XsDotDevice_deviceTagName(swigCPtr), true);
    return ret;
  }

  public bool setDeviceTagName(XsString tagName) {
    bool ret = movelladot_pc_sdkPINVOKE.XsDotDevice_setDeviceTagName(swigCPtr, XsString.getCPtr(tagName));
    if (movelladot_pc_sdkPINVOKE.SWIGPendingException.Pending) throw movelladot_pc_sdkPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ushort outputRate() {
    ushort ret = movelladot_pc_sdkPINVOKE.XsDotDevice_outputRate(swigCPtr);
    return ret;
  }

  public bool setOutputRate(ushort outputRate) {
    bool ret = movelladot_pc_sdkPINVOKE.XsDotDevice_setOutputRate(swigCPtr, outputRate);
    return ret;
  }

  public bool identify() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDotDevice_identify(swigCPtr);
    return ret;
  }

  public bool powerOff() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDotDevice_powerOff(swigCPtr);
    return ret;
  }

  public bool setPowerOnByUsb(bool enable) {
    bool ret = movelladot_pc_sdkPINVOKE.XsDotDevice_setPowerOnByUsb(swigCPtr, enable);
    return ret;
  }

  public bool setPowerSavingOptions(int advertisementTimeout, int connectedDeviceTimeout) {
    bool ret = movelladot_pc_sdkPINVOKE.XsDotDevice_setPowerSavingOptions(swigCPtr, advertisementTimeout, connectedDeviceTimeout);
    return ret;
  }

  public int getAdvertisementPowerSavingTimeout() {
    int ret = movelladot_pc_sdkPINVOKE.XsDotDevice_getAdvertisementPowerSavingTimeout(swigCPtr);
    return ret;
  }

  public int getConnectedPowerSavingTimeout() {
    int ret = movelladot_pc_sdkPINVOKE.XsDotDevice_getConnectedPowerSavingTimeout(swigCPtr);
    return ret;
  }

  public bool isCharging() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDotDevice_isCharging(swigCPtr);
    return ret;
  }

  public int batteryLevel() {
    int ret = movelladot_pc_sdkPINVOKE.XsDotDevice_batteryLevel(swigCPtr);
    return ret;
  }

  public XsFilterProfile onboardFilterProfile() {
    XsFilterProfile ret = new XsFilterProfile(movelladot_pc_sdkPINVOKE.XsDotDevice_onboardFilterProfile(swigCPtr), true);
    return ret;
  }

  public bool setOnboardFilterProfile(XsString profileType) {
    bool ret = movelladot_pc_sdkPINVOKE.XsDotDevice_setOnboardFilterProfile(swigCPtr, XsString.getCPtr(profileType));
    if (movelladot_pc_sdkPINVOKE.SWIGPendingException.Pending) throw movelladot_pc_sdkPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public XsFilterProfileArray getAvailableFilterProfiles() {
    XsFilterProfileArray ret = new XsFilterProfileArray(movelladot_pc_sdkPINVOKE.XsDotDevice_getAvailableFilterProfiles(swigCPtr), true);
    return ret;
  }

  public XsStringArray getCharacteristicStrings() {
    XsStringArray ret = new XsStringArray(movelladot_pc_sdkPINVOKE.XsDotDevice_getCharacteristicStrings(swigCPtr), true);
    return ret;
  }

  public bool restoreFactoryDefaults() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDotDevice_restoreFactoryDefaults(swigCPtr);
    return ret;
  }

  public XsPayloadMode payloadMode() {
    XsPayloadMode ret = (XsPayloadMode)movelladot_pc_sdkPINVOKE.XsDotDevice_payloadMode(swigCPtr);
    return ret;
  }

  public bool startMeasurement(XsPayloadMode mode) {
    bool ret = movelladot_pc_sdkPINVOKE.XsDotDevice_startMeasurement(swigCPtr, (int)mode);
    return ret;
  }

  public bool stopMeasurement() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDotDevice_stopMeasurement(swigCPtr);
    return ret;
  }

  public XsRecordingAcknowledgeResult getRecordingAckResult() {
    XsRecordingAcknowledgeResult ret = (XsRecordingAcknowledgeResult)movelladot_pc_sdkPINVOKE.XsDotDevice_getRecordingAckResult(swigCPtr);
    return ret;
  }

  public bool startRecording() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDotDevice_startRecording(swigCPtr);
    return ret;
  }

  public bool startTimedRecording(int seconds) {
    bool ret = movelladot_pc_sdkPINVOKE.XsDotDevice_startTimedRecording(swigCPtr, seconds);
    return ret;
  }

  public bool stopRecording() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDotDevice_stopRecording(swigCPtr);
    return ret;
  }

  public bool eraseFlash() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDotDevice_eraseFlash(swigCPtr);
    return ret;
  }

  public XsRecordingTimeInfo getRecordingTime() {
    XsRecordingTimeInfo ret = new XsRecordingTimeInfo(movelladot_pc_sdkPINVOKE.XsDotDevice_getRecordingTime(swigCPtr), true);
    return ret;
  }

  public int recordingCount() {
    int ret = movelladot_pc_sdkPINVOKE.XsDotDevice_recordingCount(swigCPtr);
    return ret;
  }

  public int usedFlashSizeTotal() {
    int ret = movelladot_pc_sdkPINVOKE.XsDotDevice_usedFlashSizeTotal(swigCPtr);
    return ret;
  }

  public XsRecordingInfo getRecordingInfo(int recordingIndex) {
    XsRecordingInfo ret = new XsRecordingInfo(movelladot_pc_sdkPINVOKE.XsDotDevice_getRecordingInfo(swigCPtr, recordingIndex), true);
    return ret;
  }

  public bool selectExportData(XsIntArray selectedDataFields) {
    bool ret = movelladot_pc_sdkPINVOKE.XsDotDevice_selectExportData(swigCPtr, XsIntArray.getCPtr(selectedDataFields));
    if (movelladot_pc_sdkPINVOKE.SWIGPendingException.Pending) throw movelladot_pc_sdkPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool startExportRecording(int recordingIndex) {
    bool ret = movelladot_pc_sdkPINVOKE.XsDotDevice_startExportRecording(swigCPtr, recordingIndex);
    return ret;
  }

  public bool stopExportRecording() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDotDevice_stopExportRecording(swigCPtr);
    return ret;
  }

  public bool startSync(XsString rootNodeMac) {
    bool ret = movelladot_pc_sdkPINVOKE.XsDotDevice_startSync(swigCPtr, XsString.getCPtr(rootNodeMac));
    if (movelladot_pc_sdkPINVOKE.SWIGPendingException.Pending) throw movelladot_pc_sdkPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool stopSync() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDotDevice_stopSync(swigCPtr);
    return ret;
  }

  public XsSyncAcknowledgeResult getSyncStatus() {
    XsSyncAcknowledgeResult ret = (XsSyncAcknowledgeResult)movelladot_pc_sdkPINVOKE.XsDotDevice_getSyncStatus(swigCPtr);
    return ret;
  }

  public XsSyncAcknowledgeResult getSyncResult() {
    XsSyncAcknowledgeResult ret = (XsSyncAcknowledgeResult)movelladot_pc_sdkPINVOKE.XsDotDevice_getSyncResult(swigCPtr);
    return ret;
  }

  public bool resetOrientation(XsResetMethod resetMethod) {
    bool ret = movelladot_pc_sdkPINVOKE.XsDotDevice_resetOrientation(swigCPtr, (int)resetMethod);
    return ret;
  }

  public XsVersion checkForFirmwareUpdate() {
    XsVersion ret = new XsVersion(movelladot_pc_sdkPINVOKE.XsDotDevice_checkForFirmwareUpdate(swigCPtr), true);
    return ret;
  }

  public XsVersion checkForFirmwareRollback() {
    XsVersion ret = new XsVersion(movelladot_pc_sdkPINVOKE.XsDotDevice_checkForFirmwareRollback(swigCPtr), true);
    return ret;
  }

  public XsVersion startFirmwareUpdateFromServer() {
    XsVersion ret = new XsVersion(movelladot_pc_sdkPINVOKE.XsDotDevice_startFirmwareUpdateFromServer(swigCPtr), true);
    return ret;
  }

  public XsVersion startFirmwareRollbackFromServer() {
    XsVersion ret = new XsVersion(movelladot_pc_sdkPINVOKE.XsDotDevice_startFirmwareRollbackFromServer(swigCPtr), true);
    return ret;
  }

  public void startFirmwareUpdateFromFile(XsString firmwareFile) {
    movelladot_pc_sdkPINVOKE.XsDotDevice_startFirmwareUpdateFromFile(swigCPtr, XsString.getCPtr(firmwareFile));
    if (movelladot_pc_sdkPINVOKE.SWIGPendingException.Pending) throw movelladot_pc_sdkPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool startMagneticFieldMapping() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDotDevice_startMagneticFieldMapping(swigCPtr);
    return ret;
  }

  public bool stopMagneticFieldMapping() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDotDevice_stopMagneticFieldMapping(swigCPtr);
    return ret;
  }

  public bool processMagneticFieldMapping(XsString filename, XsByteArray mfmResult) {
    bool ret = movelladot_pc_sdkPINVOKE.XsDotDevice_processMagneticFieldMapping(swigCPtr, XsString.getCPtr(filename), XsByteArray.getCPtr(mfmResult));
    if (movelladot_pc_sdkPINVOKE.SWIGPendingException.Pending) throw movelladot_pc_sdkPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool storeMagneticFieldMapping(XsByteArray mfmResult) {
    bool ret = movelladot_pc_sdkPINVOKE.XsDotDevice_storeMagneticFieldMapping(swigCPtr, XsByteArray.getCPtr(mfmResult));
    if (movelladot_pc_sdkPINVOKE.SWIGPendingException.Pending) throw movelladot_pc_sdkPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool gotoConfig() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDotDevice_gotoConfig(swigCPtr);
    return ret;
  }

  public bool enableLogging(XsString filename) {
    bool ret = movelladot_pc_sdkPINVOKE.XsDotDevice_enableLogging(swigCPtr, XsString.getCPtr(filename));
    if (movelladot_pc_sdkPINVOKE.SWIGPendingException.Pending) throw movelladot_pc_sdkPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool disableLogging() {
    bool ret = movelladot_pc_sdkPINVOKE.XsDotDevice_disableLogging(swigCPtr);
    return ret;
  }

  public void setLogOptions(XsLogOptions options) {
    movelladot_pc_sdkPINVOKE.XsDotDevice_setLogOptions(swigCPtr, (int)options);
  }

  public void writeDeviceSettingsToFile(XsPayloadMode mode) {
    movelladot_pc_sdkPINVOKE.XsDotDevice_writeDeviceSettingsToFile__SWIG_0(swigCPtr, (int)mode);
  }

  public void writeDeviceSettingsToFile() {
    movelladot_pc_sdkPINVOKE.XsDotDevice_writeDeviceSettingsToFile__SWIG_1(swigCPtr);
  }

  public XsString portName() {
    XsString ret = new XsString(movelladot_pc_sdkPINVOKE.XsDotDevice_portName(swigCPtr), true);
    return ret;
  }

  public XsPortInfo portInfo() {
    XsPortInfo ret = new XsPortInfo(movelladot_pc_sdkPINVOKE.XsDotDevice_portInfo(swigCPtr), true);
    return ret;
  }

  public XsDeviceId deviceId() {
    XsDeviceId ret = new XsDeviceId(movelladot_pc_sdkPINVOKE.XsDotDevice_deviceId(swigCPtr), true);
    return ret;
  }

  public XsResultValue lastResult() {
    XsResultValue ret = (XsResultValue)movelladot_pc_sdkPINVOKE.XsDotDevice_lastResult(swigCPtr);
    return ret;
  }

  public XsString lastResultText() {
    XsString ret = new XsString(movelladot_pc_sdkPINVOKE.XsDotDevice_lastResultText(swigCPtr), true);
    return ret;
  }

  public XsDeviceState deviceState() {
    XsDeviceState ret = (XsDeviceState)movelladot_pc_sdkPINVOKE.XsDotDevice_deviceState(swigCPtr);
    return ret;
  }

  public void addRef() {
    movelladot_pc_sdkPINVOKE.XsDotDevice_addRef(swigCPtr);
  }

  public void removeRef() {
    movelladot_pc_sdkPINVOKE.XsDotDevice_removeRef(swigCPtr);
  }

  public uint refCounter() {
    uint ret = movelladot_pc_sdkPINVOKE.XsDotDevice_refCounter(swigCPtr);
    return ret;
  }

  public void clearXsDotCallbackHandlers(bool chain) {
    movelladot_pc_sdkPINVOKE.XsDotDevice_clearXsDotCallbackHandlers__SWIG_0(swigCPtr, chain);
  }

  public void clearXsDotCallbackHandlers() {
    movelladot_pc_sdkPINVOKE.XsDotDevice_clearXsDotCallbackHandlers__SWIG_1(swigCPtr);
  }

  public void addXsDotCallbackHandler(XsDotCallbackPlainC cb, bool chain) {
    movelladot_pc_sdkPINVOKE.XsDotDevice_addXsDotCallbackHandler__SWIG_0(swigCPtr, XsDotCallbackPlainC.getCPtr(cb), chain);
  }

  public void addXsDotCallbackHandler(XsDotCallbackPlainC cb) {
    movelladot_pc_sdkPINVOKE.XsDotDevice_addXsDotCallbackHandler__SWIG_1(swigCPtr, XsDotCallbackPlainC.getCPtr(cb));
  }

  public void removeXsDotCallbackHandler(XsDotCallbackPlainC cb, bool chain) {
    movelladot_pc_sdkPINVOKE.XsDotDevice_removeXsDotCallbackHandler__SWIG_0(swigCPtr, XsDotCallbackPlainC.getCPtr(cb), chain);
  }

  public void removeXsDotCallbackHandler(XsDotCallbackPlainC cb) {
    movelladot_pc_sdkPINVOKE.XsDotDevice_removeXsDotCallbackHandler__SWIG_1(swigCPtr, XsDotCallbackPlainC.getCPtr(cb));
  }

  public XsDotDevice(XsDotDevice p) : this(movelladot_pc_sdkPINVOKE.new_XsDotDevice(XsDotDevice.getCPtr(p)), true) {
  }

}

}