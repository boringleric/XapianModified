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

public class Query : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Query(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Query obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Query() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          XapianPINVOKE.delete_Query(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public static Query MatchAll = new Query("");
  public static Query MatchNothing = new Query();

  public Query(Query copyme) : this(XapianPINVOKE.new_Query__SWIG_0(Query.getCPtr(copyme)), true) {
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public Query() : this(XapianPINVOKE.new_Query__SWIG_1(), true) {
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public Query(string tname_, uint wqf_, uint pos_) : this(XapianPINVOKE.new_Query__SWIG_2(tname_, wqf_, pos_), true) {
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public Query(string tname_, uint wqf_) : this(XapianPINVOKE.new_Query__SWIG_3(tname_, wqf_), true) {
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public Query(string tname_) : this(XapianPINVOKE.new_Query__SWIG_4(tname_), true) {
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public Query(Query.op op_, Query left, Query right) : this(XapianPINVOKE.new_Query__SWIG_5((int)op_, Query.getCPtr(left), Query.getCPtr(right)), true) {
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public Query(Query.op op_, string left, string right) : this(XapianPINVOKE.new_Query__SWIG_6((int)op_, left, right), true) {
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public Query(Query.op op_, Query q, double parameter) : this(XapianPINVOKE.new_Query__SWIG_9((int)op_, Query.getCPtr(q), parameter), true) {
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public Query(Query.op op_, uint slot, string begin, string end) : this(XapianPINVOKE.new_Query__SWIG_10((int)op_, slot, begin, end), true) {
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public Query(Query.op op_, uint slot, string value) : this(XapianPINVOKE.new_Query__SWIG_11((int)op_, slot, value), true) {
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public Query(PostingSource external_source) : this(XapianPINVOKE.new_Query__SWIG_12(PostingSource.getCPtr(external_source)), true) {
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint GetLength() {
    uint ret = XapianPINVOKE.Query_GetLength(swigCPtr);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TermIterator GetTermsBegin() {
    TermIterator ret = new TermIterator(XapianPINVOKE.Query_GetTermsBegin(swigCPtr), true);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TermIterator GetTermsEnd() {
    TermIterator ret = new TermIterator(XapianPINVOKE.Query_GetTermsEnd(swigCPtr), true);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Empty() {
    bool ret = XapianPINVOKE.Query_Empty(swigCPtr);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string Serialise() {
    string ret = XapianPINVOKE.Query_Serialise(swigCPtr);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Query Unserialise(string s) {
    Query ret = new Query(XapianPINVOKE.Query_Unserialise__SWIG_0(s), true);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Query Unserialise(string s, Registry registry) {
    Query ret = new Query(XapianPINVOKE.Query_Unserialise__SWIG_1(s, Registry.getCPtr(registry)), true);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string GetDescription() {
    string ret = XapianPINVOKE.Query_GetDescription(swigCPtr);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Query(Query.op op, SWIGTYPE_p_std__vectorT_std__string_t subqs, uint param) : this(XapianPINVOKE.new_Query__SWIG_13((int)op, SWIGTYPE_p_std__vectorT_std__string_t.getCPtr(subqs), param), true) {
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public Query(Query.op op, SWIGTYPE_p_std__vectorT_std__string_t subqs) : this(XapianPINVOKE.new_Query__SWIG_14((int)op, SWIGTYPE_p_std__vectorT_std__string_t.getCPtr(subqs)), true) {
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public Query(Query.op op, SWIGTYPE_p_std__vectorT_Xapian__Query_t subqs, uint param) : this(XapianPINVOKE.new_Query__SWIG_15((int)op, SWIGTYPE_p_std__vectorT_Xapian__Query_t.getCPtr(subqs), param), true) {
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public Query(Query.op op, SWIGTYPE_p_std__vectorT_Xapian__Query_t subqs) : this(XapianPINVOKE.new_Query__SWIG_16((int)op, SWIGTYPE_p_std__vectorT_Xapian__Query_t.getCPtr(subqs)), true) {
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public enum op {
    OP_AND,
    OP_OR,
    OP_AND_NOT,
    OP_XOR,
    OP_AND_MAYBE,
    OP_FILTER,
    OP_NEAR,
    OP_PHRASE,
    OP_VALUE_RANGE,
    OP_SCALE_WEIGHT,
    OP_ELITE_SET,
    OP_VALUE_GE,
    OP_VALUE_LE,
    OP_SYNONYM
  }

}

}