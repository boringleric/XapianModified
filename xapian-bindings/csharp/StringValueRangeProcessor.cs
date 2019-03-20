/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.5
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace Xapian {

using System;
using System.Runtime.InteropServices;

public class StringValueRangeProcessor : ValueRangeProcessor {
  private HandleRef swigCPtr;

  internal StringValueRangeProcessor(IntPtr cPtr, bool cMemoryOwn) : base(XapianPINVOKE.StringValueRangeProcessor_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(StringValueRangeProcessor obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~StringValueRangeProcessor() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          XapianPINVOKE.delete_StringValueRangeProcessor(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public StringValueRangeProcessor(uint slot_) : this(XapianPINVOKE.new_StringValueRangeProcessor__SWIG_0(slot_), true) {
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public StringValueRangeProcessor(uint slot_, string str_, bool prefix_) : this(XapianPINVOKE.new_StringValueRangeProcessor__SWIG_1(slot_, str_, prefix_), true) {
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public StringValueRangeProcessor(uint slot_, string str_) : this(XapianPINVOKE.new_StringValueRangeProcessor__SWIG_2(slot_, str_), true) {
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public override uint Apply(SWIGTYPE_p_std__string begin, SWIGTYPE_p_std__string end) {
    uint ret = XapianPINVOKE.StringValueRangeProcessor_Apply(swigCPtr, SWIGTYPE_p_std__string.getCPtr(begin), SWIGTYPE_p_std__string.getCPtr(end));
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
