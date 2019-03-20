/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.5
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.xapian;

public class Stem {
  private long swigCPtr;
  protected boolean swigCMemOwn;

  public Stem(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  public static long getCPtr(Stem obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        XapianJNI.delete_Stem(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public Stem(String language) {
    this(XapianJNI.new_Stem__SWIG_0(language), true);
  }

  public Stem(StemImplementation p) {
    this(XapianJNI.new_Stem__SWIG_1(StemImplementation.getCPtr(p), p), true);
  }

  public String apply(String word) {
    return XapianJNI.Stem_apply(swigCPtr, this, word);
  }

  public String toString() {
    return XapianJNI.Stem_toString(swigCPtr, this);
  }

  public static String getAvailableLanguages() {
    return XapianJNI.Stem_getAvailableLanguages();
  }

}
