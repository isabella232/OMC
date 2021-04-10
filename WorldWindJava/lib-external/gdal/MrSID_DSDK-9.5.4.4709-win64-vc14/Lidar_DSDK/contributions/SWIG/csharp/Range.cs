/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.8
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace LizardTech.LidarSDK {

using System;
using System.Runtime.InteropServices;

public class Range : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public Range(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  public static HandleRef getCPtr(Range obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Range() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          LidarDSDKPINVOKE.delete_Range(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public double min {
    set {
      LidarDSDKPINVOKE.Range_min_set(swigCPtr, value);
      if (LidarDSDKPINVOKE.SWIGPendingException.Pending) throw LidarDSDKPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = LidarDSDKPINVOKE.Range_min_get(swigCPtr);
      if (LidarDSDKPINVOKE.SWIGPendingException.Pending) throw LidarDSDKPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double max {
    set {
      LidarDSDKPINVOKE.Range_max_set(swigCPtr, value);
      if (LidarDSDKPINVOKE.SWIGPendingException.Pending) throw LidarDSDKPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = LidarDSDKPINVOKE.Range_max_get(swigCPtr);
      if (LidarDSDKPINVOKE.SWIGPendingException.Pending) throw LidarDSDKPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public Range(double amin, double amax) : this(LidarDSDKPINVOKE.new_Range__SWIG_0(amin, amax), true) {
    if (LidarDSDKPINVOKE.SWIGPendingException.Pending) throw LidarDSDKPINVOKE.SWIGPendingException.Retrieve();
  }

  public Range(double amin) : this(LidarDSDKPINVOKE.new_Range__SWIG_1(amin), true) {
    if (LidarDSDKPINVOKE.SWIGPendingException.Pending) throw LidarDSDKPINVOKE.SWIGPendingException.Retrieve();
  }

  public Range() : this(LidarDSDKPINVOKE.new_Range__SWIG_2(), true) {
    if (LidarDSDKPINVOKE.SWIGPendingException.Pending) throw LidarDSDKPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Equals(Range r) {
    bool ret = LidarDSDKPINVOKE.Range_Equals(swigCPtr, Range.getCPtr(r));
    if (LidarDSDKPINVOKE.SWIGPendingException.Pending) throw LidarDSDKPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool contains(double v) {
    bool ret = LidarDSDKPINVOKE.Range_contains(swigCPtr, v);
    if (LidarDSDKPINVOKE.SWIGPendingException.Pending) throw LidarDSDKPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool overlaps(Range r) {
    bool ret = LidarDSDKPINVOKE.Range_overlaps(swigCPtr, Range.getCPtr(r));
    if (LidarDSDKPINVOKE.SWIGPendingException.Pending) throw LidarDSDKPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool empty() {
    bool ret = LidarDSDKPINVOKE.Range_empty(swigCPtr);
    if (LidarDSDKPINVOKE.SWIGPendingException.Pending) throw LidarDSDKPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double length() {
    double ret = LidarDSDKPINVOKE.Range_length(swigCPtr);
    if (LidarDSDKPINVOKE.SWIGPendingException.Pending) throw LidarDSDKPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void shift(double v) {
    LidarDSDKPINVOKE.Range_shift(swigCPtr, v);
    if (LidarDSDKPINVOKE.SWIGPendingException.Pending) throw LidarDSDKPINVOKE.SWIGPendingException.Retrieve();
  }

  public void scale(double v) {
    LidarDSDKPINVOKE.Range_scale(swigCPtr, v);
    if (LidarDSDKPINVOKE.SWIGPendingException.Pending) throw LidarDSDKPINVOKE.SWIGPendingException.Retrieve();
  }

  public void clip(Range r) {
    LidarDSDKPINVOKE.Range_clip(swigCPtr, Range.getCPtr(r));
    if (LidarDSDKPINVOKE.SWIGPendingException.Pending) throw LidarDSDKPINVOKE.SWIGPendingException.Retrieve();
  }

  public void grow(Range r) {
    LidarDSDKPINVOKE.Range_grow__SWIG_0(swigCPtr, Range.getCPtr(r));
    if (LidarDSDKPINVOKE.SWIGPendingException.Pending) throw LidarDSDKPINVOKE.SWIGPendingException.Retrieve();
  }

  public void grow(double v) {
    LidarDSDKPINVOKE.Range_grow__SWIG_1(swigCPtr, v);
    if (LidarDSDKPINVOKE.SWIGPendingException.Pending) throw LidarDSDKPINVOKE.SWIGPendingException.Retrieve();
  }

}

}