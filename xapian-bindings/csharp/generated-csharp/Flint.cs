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

public class Flint : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Flint(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Flint obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public static Database Open(string dir) {
    Database ret = new Database(XapianPINVOKE.Flint_Open__SWIG_0(dir), true);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static WritableDatabase Open(string dir, int action, int block_size) {
    WritableDatabase ret = new WritableDatabase(XapianPINVOKE.Flint_Open__SWIG_1(dir, action, block_size), true);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static WritableDatabase Open(string dir, int action) {
    WritableDatabase ret = new WritableDatabase(XapianPINVOKE.Flint_Open__SWIG_2(dir, action), true);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
