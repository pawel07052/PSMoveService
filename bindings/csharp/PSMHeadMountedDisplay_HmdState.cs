//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace PSMoveService {

public class PSMHeadMountedDisplay_HmdState : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PSMHeadMountedDisplay_HmdState(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PSMHeadMountedDisplay_HmdState obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PSMHeadMountedDisplay_HmdState() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PSMoveClientPINVOKE.delete_PSMHeadMountedDisplay_HmdState(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public PSMMorpheus MorpheusState {
    get {
      global::System.IntPtr cPtr = PSMoveClientPINVOKE.PSMHeadMountedDisplay_HmdState_MorpheusState_get(swigCPtr);
      PSMMorpheus ret = (cPtr == global::System.IntPtr.Zero) ? null : new PSMMorpheus(cPtr, false);
      return ret;
    } 
  }

  public PSMVirtualHMD VirtualHMDState {
    get {
      global::System.IntPtr cPtr = PSMoveClientPINVOKE.PSMHeadMountedDisplay_HmdState_VirtualHMDState_get(swigCPtr);
      PSMVirtualHMD ret = (cPtr == global::System.IntPtr.Zero) ? null : new PSMVirtualHMD(cPtr, false);
      return ret;
    } 
  }

  public PSMHeadMountedDisplay_HmdState() : this(PSMoveClientPINVOKE.new_PSMHeadMountedDisplay_HmdState(), true) {
  }

}

}