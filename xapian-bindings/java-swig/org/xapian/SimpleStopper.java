/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.5
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.xapian;

public class SimpleStopper extends Stopper {
  private long swigCPtr;

  public SimpleStopper(long cPtr, boolean cMemoryOwn) {
    super(XapianJNI.SimpleStopper_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  public static long getCPtr(SimpleStopper obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        XapianJNI.delete_SimpleStopper(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public SimpleStopper() {
    this(XapianJNI.new_SimpleStopper(), true);
  }

  public void add(String word) {
    XapianJNI.SimpleStopper_add(swigCPtr, this, word);
  }

  public boolean apply(String term) {
    return XapianJNI.SimpleStopper_apply(swigCPtr, this, term);
  }

  public String toString() {
    return XapianJNI.SimpleStopper_toString(swigCPtr, this);
  }

}
