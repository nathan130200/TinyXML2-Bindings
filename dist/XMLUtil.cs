//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.2.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class XMLUtil : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal XMLUtil(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(XMLUtil obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(XMLUtil obj) {
    if (obj != null) {
      if (!obj.swigCMemOwn)
        throw new global::System.ApplicationException("Cannot release ownership as memory is not owned");
      global::System.Runtime.InteropServices.HandleRef ptr = obj.swigCPtr;
      obj.swigCMemOwn = false;
      obj.Dispose();
      return ptr;
    } else {
      return new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
    }
  }

  ~XMLUtil() {
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
          cstinyxml2PINVOKE.delete_XMLUtil(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public static string SkipWhiteSpace(string p, SWIGTYPE_p_int curLineNumPtr) {
    string ret = cstinyxml2PINVOKE.XMLUtil_SkipWhiteSpace__SWIG_0(p, SWIGTYPE_p_int.getCPtr(curLineNumPtr));
    return ret;
  }

  public static bool IsWhiteSpace(char p) {
    bool ret = cstinyxml2PINVOKE.XMLUtil_IsWhiteSpace(p);
    return ret;
  }

  public static bool IsNameStartChar(byte ch) {
    bool ret = cstinyxml2PINVOKE.XMLUtil_IsNameStartChar(ch);
    return ret;
  }

  public static bool IsNameChar(byte ch) {
    bool ret = cstinyxml2PINVOKE.XMLUtil_IsNameChar(ch);
    return ret;
  }

  public static bool IsPrefixHex(string p) {
    bool ret = cstinyxml2PINVOKE.XMLUtil_IsPrefixHex(p);
    return ret;
  }

  public static bool StringEqual(string p, string q, int nChar) {
    bool ret = cstinyxml2PINVOKE.XMLUtil_StringEqual__SWIG_0(p, q, nChar);
    return ret;
  }

  public static bool StringEqual(string p, string q) {
    bool ret = cstinyxml2PINVOKE.XMLUtil_StringEqual__SWIG_1(p, q);
    return ret;
  }

  public static bool IsUTF8Continuation(char p) {
    bool ret = cstinyxml2PINVOKE.XMLUtil_IsUTF8Continuation(p);
    return ret;
  }

  public static string ReadBOM(string p, SWIGTYPE_p_bool hasBOM) {
    string ret = cstinyxml2PINVOKE.XMLUtil_ReadBOM(p, SWIGTYPE_p_bool.getCPtr(hasBOM));
    return ret;
  }

  public static string GetCharacterRef(string p, string value, SWIGTYPE_p_int length) {
    string ret = cstinyxml2PINVOKE.XMLUtil_GetCharacterRef(p, value, SWIGTYPE_p_int.getCPtr(length));
    return ret;
  }

  public static void ConvertUTF32ToUTF8(uint input, string output, SWIGTYPE_p_int length) {
    cstinyxml2PINVOKE.XMLUtil_ConvertUTF32ToUTF8(input, output, SWIGTYPE_p_int.getCPtr(length));
  }

  public static void ToStr(int v, string buffer, int bufferSize) {
    cstinyxml2PINVOKE.XMLUtil_ToStr__SWIG_0(v, buffer, bufferSize);
  }

  public static void ToStr(uint v, string buffer, int bufferSize) {
    cstinyxml2PINVOKE.XMLUtil_ToStr__SWIG_1(v, buffer, bufferSize);
  }

  public static void ToStr(bool v, string buffer, int bufferSize) {
    cstinyxml2PINVOKE.XMLUtil_ToStr__SWIG_2(v, buffer, bufferSize);
  }

  public static void ToStr(float v, string buffer, int bufferSize) {
    cstinyxml2PINVOKE.XMLUtil_ToStr__SWIG_3(v, buffer, bufferSize);
  }

  public static void ToStr(double v, string buffer, int bufferSize) {
    cstinyxml2PINVOKE.XMLUtil_ToStr__SWIG_4(v, buffer, bufferSize);
  }

  public static void ToStr(SWIGTYPE_p_int64_t v, string buffer, int bufferSize) {
    cstinyxml2PINVOKE.XMLUtil_ToStr__SWIG_5(SWIGTYPE_p_int64_t.getCPtr(v), buffer, bufferSize);
    if (cstinyxml2PINVOKE.SWIGPendingException.Pending) throw cstinyxml2PINVOKE.SWIGPendingException.Retrieve();
  }

  public static void ToStr(SWIGTYPE_p_uint64_t v, string buffer, int bufferSize) {
    cstinyxml2PINVOKE.XMLUtil_ToStr__SWIG_6(SWIGTYPE_p_uint64_t.getCPtr(v), buffer, bufferSize);
    if (cstinyxml2PINVOKE.SWIGPendingException.Pending) throw cstinyxml2PINVOKE.SWIGPendingException.Retrieve();
  }

  public static bool ToInt(string str, SWIGTYPE_p_int value) {
    bool ret = cstinyxml2PINVOKE.XMLUtil_ToInt(str, SWIGTYPE_p_int.getCPtr(value));
    return ret;
  }

  public static bool ToUnsigned(string str, SWIGTYPE_p_unsigned_int value) {
    bool ret = cstinyxml2PINVOKE.XMLUtil_ToUnsigned(str, SWIGTYPE_p_unsigned_int.getCPtr(value));
    return ret;
  }

  public static bool ToBool(string str, SWIGTYPE_p_bool value) {
    bool ret = cstinyxml2PINVOKE.XMLUtil_ToBool(str, SWIGTYPE_p_bool.getCPtr(value));
    return ret;
  }

  public static bool ToFloat(string str, SWIGTYPE_p_float value) {
    bool ret = cstinyxml2PINVOKE.XMLUtil_ToFloat(str, SWIGTYPE_p_float.getCPtr(value));
    return ret;
  }

  public static bool ToDouble(string str, SWIGTYPE_p_double value) {
    bool ret = cstinyxml2PINVOKE.XMLUtil_ToDouble(str, SWIGTYPE_p_double.getCPtr(value));
    return ret;
  }

  public static bool ToInt64(string str, SWIGTYPE_p_int64_t value) {
    bool ret = cstinyxml2PINVOKE.XMLUtil_ToInt64(str, SWIGTYPE_p_int64_t.getCPtr(value));
    return ret;
  }

  public static bool ToUnsigned64(string str, SWIGTYPE_p_uint64_t value) {
    bool ret = cstinyxml2PINVOKE.XMLUtil_ToUnsigned64(str, SWIGTYPE_p_uint64_t.getCPtr(value));
    return ret;
  }

  public static void SetBoolSerialization(string writeTrue, string writeFalse) {
    cstinyxml2PINVOKE.XMLUtil_SetBoolSerialization(writeTrue, writeFalse);
  }

  public XMLUtil() : this(cstinyxml2PINVOKE.new_XMLUtil(), true) {
  }

}
