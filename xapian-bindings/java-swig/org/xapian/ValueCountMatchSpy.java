/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.5
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.xapian;

public class ValueCountMatchSpy extends MatchSpy {
  private long swigCPtr;

  public ValueCountMatchSpy(long cPtr, boolean cMemoryOwn) {
    super(XapianJNI.ValueCountMatchSpy_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  public static long getCPtr(ValueCountMatchSpy obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        XapianJNI.delete_ValueCountMatchSpy(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public ValueCountMatchSpy() {
    this(XapianJNI.new_ValueCountMatchSpy__SWIG_0(), true);
  }

  public ValueCountMatchSpy(int slot_) {
    this(XapianJNI.new_ValueCountMatchSpy__SWIG_1(slot_), true);
  }

  public long getTotal() {
    return XapianJNI.ValueCountMatchSpy_getTotal(swigCPtr, this);
  }

  public TermIterator valuesBegin() {
    return new TermIterator(XapianJNI.ValueCountMatchSpy_valuesBegin(swigCPtr, this), true);
  }

  public TermIterator valuesEnd() {
    return new TermIterator(XapianJNI.ValueCountMatchSpy_valuesEnd(swigCPtr, this), true);
  }

  public TermIterator topValuesBegin(long maxvalues) {
    return new TermIterator(XapianJNI.ValueCountMatchSpy_topValuesBegin(swigCPtr, this, maxvalues), true);
  }

  public TermIterator topValuesEnd(long arg0) {
    return new TermIterator(XapianJNI.ValueCountMatchSpy_topValuesEnd(swigCPtr, this, arg0), true);
  }

  public void apply(Document doc, double wt) {
    XapianJNI.ValueCountMatchSpy_apply(swigCPtr, this, Document.getCPtr(doc), doc, wt);
  }

  public String name() {
    return XapianJNI.ValueCountMatchSpy_name(swigCPtr, this);
  }

  public void mergeResults(String s) {
    XapianJNI.ValueCountMatchSpy_mergeResults(swigCPtr, this, s);
  }

  public String toString() {
    return XapianJNI.ValueCountMatchSpy_toString(swigCPtr, this);
  }

}
